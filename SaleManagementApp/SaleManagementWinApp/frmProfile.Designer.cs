namespace SaleManagementWinApp
{
    partial class frmProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            lbCustomerID = new Label();
            txtCustomerID = new TextBox();
            lbCustomerName = new Label();
            txtCustomerName = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            lbBirthday = new Label();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            dtpBirthday = new DateTimePicker();
            lbConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lbPassword = new Label();
            SuspendLayout();
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new Point(30, 57);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new Size(87, 20);
            lbCustomerID.TabIndex = 0;
            lbCustomerID.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(134, 53);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(207, 27);
            txtCustomerID.TabIndex = 1;
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(2, 93);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(116, 20);
            lbCustomerName.TabIndex = 0;
            lbCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(134, 89);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(207, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(69, 237);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 27);
            txtEmail.TabIndex = 1;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(78, 129);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(134, 125);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(207, 27);
            txtCity.TabIndex = 1;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(53, 165);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(134, 161);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(207, 27);
            txtCountry.TabIndex = 1;
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(51, 201);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(64, 20);
            lbBirthday.TabIndex = 0;
            lbBirthday.Text = "Birthday";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(491, 57);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(207, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(419, 197);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 65);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(603, 197);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 65);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(134, 197);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(207, 27);
            dtpBirthday.TabIndex = 3;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(366, 97);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(127, 20);
            lbConfirmPassword.TabIndex = 0;
            lbConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(491, 93);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(207, 27);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(419, 57);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 295);
            Controls.Add(dtpBirthday);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(lbPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(lbBirthday);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbEmail);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCustomerID);
            Name = "frmProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProfile";
            Load += frmProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCustomerID;
        private TextBox txtCustomerID;
        private Label lbCustomerName;
        private TextBox txtCustomerName;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbCountry;
        private TextBox txtCountry;
        private Label lbBirthday;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnClose;
        private DateTimePicker dtpBirthday;
        private Label lbConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lbPassword;
    }
}