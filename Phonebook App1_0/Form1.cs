using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Phonebook_App1_0
{
    public partial class MainForm : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PhonebookDB.mdf;Integrated Security=True";

        int pageNum = 0;
        List<Person> allPerson = new List<Person>();
        Control[,] controlGrid;

        public MainForm()
        {
            InitializeComponent();

            controlGrid = new Control[10, 6]
            {
                { fName1, lName1, info1, phone1, email1, editButton1 },
                { fName2, lName2, info2, phone2, email2, editButton2 },
                { fName3, lName3, info3, phone3, email3, editButton3 },
                { fName4, lName4, info4, phone4, email4, editButton4 },
                { fName5, lName5, info5, phone5, email5, editButton5 },
                { fName6, lName6, info6, phone6, email6, editButton6 },
                { fName7, lName7, info7, phone7, email7, editButton7 },
                { fName8, lName8, info8, phone8, email8, editButton8 },
                { fName9, lName9, info9, phone9, email9, editButton9 },
                { fName10, lName10, info10, phone10, email10, editButton10 }
            };

            GetData();
            ShowPersons(pageNum = 0);
            ShowPageControls();
        }

        /// <summary>
        /// Gets all from the Person table in the Database into the allPerson List.
        /// </summary>
        private void GetData()
        {
            allPerson.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Person";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fName = reader.GetString(1);
                            string lname = reader.GetString(2);
                            string info = reader.GetString(3);
                            string phoneNum = reader.GetString(4);
                            string eMail = reader.GetString(5);
                            Person person = new Person(fName, lname, info, phoneNum, eMail);
                            allPerson.Add(person);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Updates Person table in the Database with allPerson List.
        /// </summary>
        private void SetData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Person";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string insertQuery = "INSERT INTO Person (first_name, last_name, info, phone_number, e_mail) " +
                    "VALUES (@first_name, @last_name, @info, @phone_number, @e_mail)";
                using (SqlCommand command = new SqlCommand(@insertQuery, connection))
                {
                    foreach (Person person in allPerson)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@first_name", person.FirstName);
                        command.Parameters.AddWithValue("@last_name", person.LastName);
                        command.Parameters.AddWithValue("@info", person.Info);
                        command.Parameters.AddWithValue("@phone_number", person.PhoneNum);
                        command.Parameters.AddWithValue("@e_mail", person.Email);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// Puts Persons from allPerson List 10 by 10 into the controlGrid.
        /// </summary>
        /// <param name="page">Represents the page.</param>
        private void ShowPersons(int page)
        {
            for (int i = 0; i < 10; i++)
            {
                int personID = page * 10 + i;

                if (allPerson.Count > personID)
                {
                    ((Label)controlGrid[i, 0]).Text = allPerson[personID].FirstName;
                    ((Label)controlGrid[i, 1]).Text = allPerson[personID].LastName;
                    ((Label)controlGrid[i, 2]).Text = allPerson[personID].Info;
                    ((Label)controlGrid[i, 3]).Text = allPerson[personID].PhoneNum;
                    ((Label)controlGrid[i, 4]).Text = allPerson[personID].Email;
                    ((Button)controlGrid[i, 5]).Tag = allPerson.IndexOf(allPerson[personID]);
                    ((Button)controlGrid[i, 5]).Visible = true;
                }
                else
                {
                    ((Button)controlGrid[i, 5]).Visible = false;
                    for (int ii = 0; ii < 5; ii++)
                    {
                        controlGrid[i, ii].Text = "";
                    }
                }
            }
        }

        /// <summary>
        /// Adds new Person to the allPerson List.
        /// </summary>
        /// <param name="person">Person object.</param>
        public void AddToList(Person person)
        {
            allPerson.Add(person);
            ShowPersons(pageNum = 0);
            ShowPageControls();
        }

        /// <summary>
        /// Updates the Person with specified id in allPerson List.
        /// </summary>
        /// <param name="person">Updated object.</param>
        /// <param name="id">ID of the Person to be updated.</param>
        public void UpdateInList(Person person, int id)
        {
            allPerson[id] = person;
            ShowPersons(pageNum = 0);
            ShowPageControls();
        }

        /// <summary>
        /// Removes Person from allPerson.
        /// </summary>
        /// <param name="id">ID of the Person to be removed.</param>
        public void DeleteFromList(int id)
        {
            allPerson.Remove(allPerson[id]);
            ShowPersons(pageNum = 0);
            ShowPageControls();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SetData();
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.mainForm = this;
            inputForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int editNum = Convert.ToInt32(button.Tag);
            Person person = allPerson[editNum];
            InputForm inputForm = new InputForm(person, editNum);
            inputForm.mainForm = this;
            inputForm.ShowDialog();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            pageNum++;
            ShowPersons(pageNum);
            ShowPageControls();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            pageNum--;
            ShowPersons(pageNum);
            ShowPageControls();
        }

        /// <summary>
        /// Shows and Hides the Back and Next buttons to switch pages properly.
        /// </summary>
        private void ShowPageControls()
        {
            int pages = allPerson.Count / 10;
            if (pages > 0 && allPerson.Count % 10 == 0) pages--;

            if (pages > 0)
            {
                backButton.Visible = pageNum > 0 ? true : false;
                nextButton.Visible = pageNum < pages ? true : false;
            }
        }
    }

    /// <summary>
    /// Person object.
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }

        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Info = string.Empty;
            PhoneNum = string.Empty;
            Email = string.Empty;
        }

        public Person(string firstName, string lastName, string info, string phoneNum, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Info = info;
            this.PhoneNum = phoneNum;
            this.Email = email;
        }
    }
}
