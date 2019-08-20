namespace WindowsFormsApplication2
{
    partial class AdminRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegistration));
            this.Year = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.E_mail = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Label();
            this.adminpl = new System.Windows.Forms.Panel();
            this.adminpl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(922, 272);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 39;
            this.Year.Text = "Year";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.DimGray;
            this.Email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(3, 177);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(124, 19);
            this.Email.TabIndex = 31;
            this.Email.Text = "Name Of Admin";
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.BackColor = System.Drawing.Color.DimGray;
            this.Last_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Name.ForeColor = System.Drawing.Color.White;
            this.Last_Name.Location = new System.Drawing.Point(18, 131);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(81, 19);
            this.Last_Name.TabIndex = 30;
            this.Last_Name.Text = "Passward";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Password Of Admin";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.BackColor = System.Drawing.Color.DimGray;
            this.First_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name.ForeColor = System.Drawing.Color.White;
            this.First_Name.Location = new System.Drawing.Point(18, 90);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(104, 19);
            this.First_Name.TabIndex = 29;
            this.First_Name.Text = "Admin Name";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(163, 225);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(229, 20);
            this.Password.TabIndex = 42;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // E_mail
            // 
            this.E_mail.Location = new System.Drawing.Point(163, 178);
            this.E_mail.Name = "E_mail";
            this.E_mail.Size = new System.Drawing.Size(229, 20);
            this.E_mail.TabIndex = 28;
            this.E_mail.TextChanged += new System.EventHandler(this.E_mail_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(128, 130);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(229, 20);
            this.LastName.TabIndex = 27;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(128, 89);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(229, 20);
            this.FirstName.TabIndex = 26;
            // 
            // Submit
            // 
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(192, 284);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 25;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(105, 13);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(224, 43);
            this.Registration.TabIndex = 44;
            this.Registration.Text = "Registration";
            // 
            // adminpl
            // 
            this.adminpl.BackColor = System.Drawing.Color.DimGray;
            this.adminpl.Controls.Add(this.Registration);
            this.adminpl.Controls.Add(this.Submit);
            this.adminpl.Controls.Add(this.FirstName);
            this.adminpl.Controls.Add(this.LastName);
            this.adminpl.Controls.Add(this.E_mail);
            this.adminpl.Controls.Add(this.Password);
            this.adminpl.Controls.Add(this.First_Name);
            this.adminpl.Controls.Add(this.label2);
            this.adminpl.Controls.Add(this.Last_Name);
            this.adminpl.Controls.Add(this.Email);
            this.adminpl.Location = new System.Drawing.Point(158, 12);
            this.adminpl.Name = "adminpl";
            this.adminpl.Size = new System.Drawing.Size(510, 322);
            this.adminpl.TabIndex = 48;
            // 
            // AdminRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 458);
            this.Controls.Add(this.adminpl);
            this.Controls.Add(this.Year);
            this.DoubleBuffered = true;
            this.Name = "AdminRegistration";
            this.Text = "AdminRegistration";
            this.Load += new System.EventHandler(this.AdminRegistration_Load);
            this.adminpl.ResumeLayout(false);
            this.adminpl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox E_mail;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Panel adminpl;
    }
}