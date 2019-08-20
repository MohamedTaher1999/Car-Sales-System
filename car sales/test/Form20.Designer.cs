namespace WindowsFormsApplication2
{
    partial class admin_lgn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_lgn));
            this.Sign_up = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.log2 = new System.Windows.Forms.Panel();
            this.Submit_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sign_up
            // 
            this.Sign_up.AutoSize = true;
            this.Sign_up.Location = new System.Drawing.Point(252, 298);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(46, 13);
            this.Sign_up.TabIndex = 0;
            this.Sign_up.TabStop = true;
            this.Sign_up.Text = "Sign UP";
            this.Sign_up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sign_up_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 5;
            // 
            // log2
            // 
            this.log2.BackColor = System.Drawing.Color.DimGray;
            this.log2.Controls.Add(this.Submit_Login);
            this.log2.Controls.Add(this.label3);
            this.log2.Controls.Add(this.label1);
            this.log2.Controls.Add(this.label2);
            this.log2.Controls.Add(this.Sign_up);
            this.log2.Controls.Add(this.textBox2);
            this.log2.Controls.Add(this.textBox1);
            this.log2.Location = new System.Drawing.Point(147, 12);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(490, 346);
            this.log2.TabIndex = 7;
            // 
            // Submit_Login
            // 
            this.Submit_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit_Login.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Login.ForeColor = System.Drawing.Color.White;
            this.Submit_Login.Location = new System.Drawing.Point(211, 246);
            this.Submit_Login.Name = "Submit_Login";
            this.Submit_Login.Size = new System.Drawing.Size(120, 32);
            this.Submit_Login.TabIndex = 14;
            this.Submit_Login.Text = "Submit";
            this.Submit_Login.UseVisualStyleBackColor = true;
            this.Submit_Login.Click += new System.EventHandler(this.Submit_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(185, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 43);
            this.label3.TabIndex = 13;
            this.label3.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // admin_lgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 379);
            this.Controls.Add(this.log2);
            this.DoubleBuffered = true;
            this.Name = "admin_lgn";
            this.Text = "admin_lgn";
            this.Load += new System.EventHandler(this.admin_lgn_Load);
            this.log2.ResumeLayout(false);
            this.log2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel Sign_up;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel log2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Submit_Login;
    }
}