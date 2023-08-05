namespace Phonebook_App1_0
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.inputLayout.SuspendLayout();
            this.buttonsFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputLayout
            // 
            this.inputLayout.ColumnCount = 3;
            this.inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.inputLayout.Controls.Add(this.emailBox, 1, 9);
            this.inputLayout.Controls.Add(this.infoBox, 1, 5);
            this.inputLayout.Controls.Add(this.lnameBox, 1, 3);
            this.inputLayout.Controls.Add(this.emailLabel, 1, 8);
            this.inputLayout.Controls.Add(this.phoneLabel, 1, 6);
            this.inputLayout.Controls.Add(this.infoLabel, 1, 4);
            this.inputLayout.Controls.Add(this.lnameLabel, 1, 2);
            this.inputLayout.Controls.Add(this.fnameLabel, 1, 0);
            this.inputLayout.Controls.Add(this.fnameBox, 1, 1);
            this.inputLayout.Controls.Add(this.phoneBox, 1, 7);
            this.inputLayout.Controls.Add(this.buttonsFlow, 1, 10);
            this.inputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputLayout.Location = new System.Drawing.Point(0, 0);
            this.inputLayout.Name = "inputLayout";
            this.inputLayout.RowCount = 11;
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputLayout.Size = new System.Drawing.Size(464, 441);
            this.inputLayout.TabIndex = 0;
            // 
            // emailBox
            // 
            this.emailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailBox.Location = new System.Drawing.Point(26, 354);
            this.emailBox.MaxLength = 64;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(411, 26);
            this.emailBox.TabIndex = 9;
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoBox
            // 
            this.infoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoBox.Location = new System.Drawing.Point(26, 198);
            this.infoBox.MaxLength = 64;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(411, 26);
            this.infoBox.TabIndex = 7;
            this.infoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnameBox
            // 
            this.lnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnameBox.Location = new System.Drawing.Point(26, 120);
            this.lnameBox.MaxLength = 32;
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(411, 26);
            this.lnameBox.TabIndex = 6;
            this.lnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLabel.Location = new System.Drawing.Point(26, 315);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(3);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(411, 33);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "E Mail";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneLabel.Location = new System.Drawing.Point(26, 237);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(3);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(411, 33);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone Number";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLabel.Location = new System.Drawing.Point(26, 159);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(3);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(411, 33);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Info";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnameLabel.Location = new System.Drawing.Point(26, 81);
            this.lnameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(411, 33);
            this.lnameLabel.TabIndex = 1;
            this.lnameLabel.Text = "Last Name";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fnameLabel.Location = new System.Drawing.Point(26, 3);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(411, 33);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fnameBox
            // 
            this.fnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fnameBox.Location = new System.Drawing.Point(26, 42);
            this.fnameBox.MaxLength = 32;
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(411, 26);
            this.fnameBox.TabIndex = 5;
            this.fnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneBox
            // 
            this.phoneBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneBox.Location = new System.Drawing.Point(26, 276);
            this.phoneBox.Mask = "(999) 000-0000";
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(411, 26);
            this.phoneBox.TabIndex = 8;
            this.phoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonsFlow
            // 
            this.buttonsFlow.Controls.Add(this.addButton);
            this.buttonsFlow.Controls.Add(this.deleteButton);
            this.buttonsFlow.Controls.Add(this.cancelButton);
            this.buttonsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsFlow.Location = new System.Drawing.Point(26, 393);
            this.buttonsFlow.Name = "buttonsFlow";
            this.buttonsFlow.Size = new System.Drawing.Size(411, 45);
            this.buttonsFlow.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(130, 40);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.Location = new System.Drawing.Point(139, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 40);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelButton.Location = new System.Drawing.Point(275, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 40);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.inputLayout);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.inputLayout.ResumeLayout(false);
            this.inputLayout.PerformLayout();
            this.buttonsFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel inputLayout;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.MaskedTextBox phoneBox;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlow;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
    }
}