namespace Stundenplaner_Mader_Hauser
{
    partial class Login
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
            this.tB_login_name = new System.Windows.Forms.TextBox();
            this.tB_login_password = new System.Windows.Forms.TextBox();
            this.cB_passwordChar = new System.Windows.Forms.CheckBox();
            this.pB_Login = new System.Windows.Forms.PictureBox();
            this.pB_addUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_addUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_login_name
            // 
            this.tB_login_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_login_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tB_login_name.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_login_name.Location = new System.Drawing.Point(27, 119);
            this.tB_login_name.Multiline = true;
            this.tB_login_name.Name = "tB_login_name";
            this.tB_login_name.Size = new System.Drawing.Size(426, 41);
            this.tB_login_name.TabIndex = 0;
            this.tB_login_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_login_name_KeyDown);
            // 
            // tB_login_password
            // 
            this.tB_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tB_login_password.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_login_password.Location = new System.Drawing.Point(27, 249);
            this.tB_login_password.Multiline = true;
            this.tB_login_password.Name = "tB_login_password";
            this.tB_login_password.Size = new System.Drawing.Size(426, 41);
            this.tB_login_password.TabIndex = 1;
            this.tB_login_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_login_password_KeyDown);
            // 
            // cB_passwordChar
            // 
            this.cB_passwordChar.AutoSize = true;
            this.cB_passwordChar.Location = new System.Drawing.Point(27, 333);
            this.cB_passwordChar.Name = "cB_passwordChar";
            this.cB_passwordChar.Size = new System.Drawing.Size(15, 14);
            this.cB_passwordChar.TabIndex = 2;
            this.cB_passwordChar.UseVisualStyleBackColor = true;
            this.cB_passwordChar.CheckedChanged += new System.EventHandler(this.cB_passwordChar_CheckedChanged);
            // 
            // pB_Login
            // 
            this.pB_Login.BackColor = System.Drawing.Color.Transparent;
            this.pB_Login.Location = new System.Drawing.Point(27, 378);
            this.pB_Login.Name = "pB_Login";
            this.pB_Login.Size = new System.Drawing.Size(426, 50);
            this.pB_Login.TabIndex = 3;
            this.pB_Login.TabStop = false;
            this.pB_Login.Click += new System.EventHandler(this.pB_Login_Click);
            // 
            // pB_addUser
            // 
            this.pB_addUser.BackColor = System.Drawing.Color.Transparent;
            this.pB_addUser.Location = new System.Drawing.Point(255, 460);
            this.pB_addUser.Name = "pB_addUser";
            this.pB_addUser.Size = new System.Drawing.Size(198, 26);
            this.pB_addUser.TabIndex = 4;
            this.pB_addUser.TabStop = false;
            this.pB_addUser.Click += new System.EventHandler(this.pB_addUser_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Stundenplaner_Mader_Hauser.Properties.Resources.MicrosoftTeams_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 533);
            this.Controls.Add(this.pB_addUser);
            this.Controls.Add(this.pB_Login);
            this.Controls.Add(this.cB_passwordChar);
            this.Controls.Add(this.tB_login_password);
            this.Controls.Add(this.tB_login_name);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_addUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tB_login_name;
        private TextBox tB_login_password;
        private CheckBox cB_passwordChar;
        private PictureBox pB_Login;
        private PictureBox pB_addUser;
    }
}