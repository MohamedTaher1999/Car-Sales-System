namespace WindowsFormsApplication2
{
    partial class UserRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            this.Submit = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.E_mail = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Password = new System.Windows.Forms.TextBox();
            this.userpl = new System.Windows.Forms.Panel();
            this.First_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userpl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(238, 405);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 26);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(177, 108);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(229, 20);
            this.FirstName.TabIndex = 1;
            // 
            // E_mail
            // 
            this.E_mail.Location = new System.Drawing.Point(177, 148);
            this.E_mail.Name = "E_mail";
            this.E_mail.Size = new System.Drawing.Size(229, 20);
            this.E_mail.TabIndex = 3;
            this.E_mail.TextChanged += new System.EventHandler(this.E_mail_TextChanged);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(160, 33);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(224, 43);
            this.Registration.TabIndex = 9;
            this.Registration.Text = "Registration";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.ForeColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(177, 311);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 10;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.ForeColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(302, 311);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 11;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(177, 212);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(229, 20);
            this.Password.TabIndex = 22;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // userpl
            // 
            this.userpl.BackColor = System.Drawing.Color.DimGray;
            this.userpl.Controls.Add(this.textBox2);
            this.userpl.Controls.Add(this.textBox1);
            this.userpl.Controls.Add(this.label5);
            this.userpl.Controls.Add(this.label4);
            this.userpl.Controls.Add(this.First_Name);
            this.userpl.Controls.Add(this.label2);
            this.userpl.Controls.Add(this.Email);
            this.userpl.Controls.Add(this.label1);
            this.userpl.Controls.Add(this.Registration);
            this.userpl.Controls.Add(this.Submit);
            this.userpl.Controls.Add(this.Password);
            this.userpl.Controls.Add(this.FirstName);
            this.userpl.Controls.Add(this.E_mail);
            this.userpl.Controls.Add(this.Male);
            this.userpl.Controls.Add(this.Female);
            this.userpl.Location = new System.Drawing.Point(112, 21);
            this.userpl.Name = "userpl";
            this.userpl.Size = new System.Drawing.Size(548, 455);
            this.userpl.TabIndex = 25;
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.BackColor = System.Drawing.Color.DimGray;
            this.First_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name.ForeColor = System.Drawing.Color.White;
            this.First_Name.Location = new System.Drawing.Point(43, 109);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(88, 19);
            this.First_Name.TabIndex = 47;
            this.First_Name.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Password";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.DimGray;
            this.Email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(43, 149);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 19);
            this.Email.TabIndex = 49;
            this.Email.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Phone";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 57;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 58;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 488);
            this.Controls.Add(this.userpl);
            this.DoubleBuffered = true;
            this.Name = "UserRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.userpl.ResumeLayout(false);
            this.userpl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox E_mail;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Panel userpl;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}