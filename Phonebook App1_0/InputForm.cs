using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook_App1_0
{
    public partial class InputForm : Form
    {
        public MainForm mainForm;
        bool editMode;
        int editNum;
        public InputForm()
        {
            InitializeComponent();
        }

        public InputForm(Person person, int i)
        {
            InitializeComponent();

            fnameBox.Text = person.FirstName;
            lnameBox.Text = String.IsNullOrEmpty(person.LastName) ? "N/A" : person.LastName;
            infoBox.Text = String.IsNullOrEmpty(person.Info) ? "N/A" : person.Info;
            phoneBox.Text = person.PhoneNum;
            emailBox.Text = String.IsNullOrEmpty(person.Email) ? "N/A" : person.Email;

            addButton.Text = "Edit";
            deleteButton.Visible = true;
            cancelButton.Text = "Close";
            editNum = i;
            editMode = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fnameBox.Text) || phoneBox.Text.Length < 14)
            {
                MessageBox.Show("Missing Parameters. First Name and Phone Number are required");
                return;
            }
            else
            {
                string fName = fnameBox.Text;
                string lName = lnameBox.Text;
                string info = infoBox.Text;
                string phoneNum = phoneBox.Text;
                string eMail = emailBox.Text;
                Person person = new Person(fName, lName, info, phoneNum, eMail);

                if (editMode)
                {
                    mainForm.UpdateInList(person, editNum);
                }
                else
                {
                    mainForm.AddToList(person);
                }

                this.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete this Person?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                mainForm.DeleteFromList(editNum);
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
