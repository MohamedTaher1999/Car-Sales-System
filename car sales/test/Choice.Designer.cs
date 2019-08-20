namespace WindowsFormsApplication2
{
    partial class choice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choice));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin_btn = new System.Windows.Forms.Button();
            this.User_btn = new System.Windows.Forms.Button();
            this.choicepl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.choicepl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hit your Type";
            // 
            // Admin_btn
            // 
            this.Admin_btn.BackgroundImage = global::test.Properties.Resources.settings;
            this.Admin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin_btn.Location = new System.Drawing.Point(301, 116);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(110, 61);
            this.Admin_btn.TabIndex = 1;
            this.Admin_btn.UseVisualStyleBackColor = true;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // User_btn
            // 
            this.User_btn.BackgroundImage = global::test.Properties.Resources.users;
            this.User_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_btn.Location = new System.Drawing.Point(72, 116);
            this.User_btn.Name = "User_btn";
            this.User_btn.Size = new System.Drawing.Size(113, 61);
            this.User_btn.TabIndex = 0;
            this.User_btn.UseVisualStyleBackColor = true;
            this.User_btn.Click += new System.EventHandler(this.User_btn_Click);
            // 
            // choicepl
            // 
            this.choicepl.BackColor = System.Drawing.Color.DimGray;
            this.choicepl.Controls.Add(this.label2);
            this.choicepl.Controls.Add(this.label3);
            this.choicepl.Controls.Add(this.User_btn);
            this.choicepl.Controls.Add(this.Admin_btn);
            this.choicepl.Controls.Add(this.label1);
            this.choicepl.Location = new System.Drawing.Point(126, 31);
            this.choicepl.Name = "choicepl";
            this.choicepl.Size = new System.Drawing.Size(539, 257);
            this.choicepl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin";
            // 
            // choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 333);
            this.Controls.Add(this.choicepl);
            this.DoubleBuffered = true;
            this.Name = "choice";
            this.Text = "choice ";
            this.Load += new System.EventHandler(this.choice_Load);
            this.choicepl.ResumeLayout(false);
            this.choicepl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button User_btn;
        private System.Windows.Forms.Button Admin_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel choicepl;
        private System.Windows.Forms.Label label2;
    }
}

