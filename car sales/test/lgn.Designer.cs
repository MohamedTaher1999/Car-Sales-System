namespace WindowsFormsApplication2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Submit_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.log1 = new System.Windows.Forms.Panel();
            this.log1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegisterLink.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLink.Location = new System.Drawing.Point(244, 293);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(49, 16);
            this.RegisterLink.TabIndex = 5;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Sign up";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Submit_Login
            // 
            this.Submit_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit_Login.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Login.ForeColor = System.Drawing.Color.White;
            this.Submit_Login.Location = new System.Drawing.Point(198, 241);
            this.Submit_Login.Name = "Submit_Login";
            this.Submit_Login.Size = new System.Drawing.Size(120, 32);
            this.Submit_Login.TabIndex = 9;
            this.Submit_Login.Text = "Submit";
            this.Submit_Login.UseVisualStyleBackColor = true;
            this.Submit_Login.Click += new System.EventHandler(this.Submit_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // log1
            // 
            this.log1.BackColor = System.Drawing.Color.DimGray;
            this.log1.Controls.Add(this.label3);
            this.log1.Controls.Add(this.RegisterLink);
            this.log1.Controls.Add(this.textBox2);
            this.log1.Controls.Add(this.label1);
            this.log1.Controls.Add(this.textBox1);
            this.log1.Controls.Add(this.label2);
            this.log1.Controls.Add(this.Submit_Login);
            this.log1.Location = new System.Drawing.Point(132, 12);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(529, 325);
            this.log1.TabIndex = 13;
            this.log1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 374);
            this.Controls.Add(this.log1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.log1.ResumeLayout(false);
            this.log1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Submit_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel log1;
    }
}