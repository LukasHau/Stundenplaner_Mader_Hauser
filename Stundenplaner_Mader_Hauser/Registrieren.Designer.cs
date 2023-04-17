namespace Stundenplaner_Mader_Hauser
{
    partial class Registrieren
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
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.tB_password2 = new System.Windows.Forms.TextBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(281, 249);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(91, 35);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Registrieren";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(9, 249);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(91, 35);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tB_password
            // 
            this.tB_password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_password.Location = new System.Drawing.Point(32, 106);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(317, 26);
            this.tB_password.TabIndex = 2;
            // 
            // tB_password2
            // 
            this.tB_password2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_password2.Location = new System.Drawing.Point(32, 186);
            this.tB_password2.Name = "tB_password2";
            this.tB_password2.Size = new System.Drawing.Size(317, 26);
            this.tB_password2.TabIndex = 3;
            // 
            // tB_name
            // 
            this.tB_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_name.Location = new System.Drawing.Point(32, 35);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(317, 26);
            this.tB_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Passwort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Passwort wiederholen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Benutzername:";
            // 
            // Registrieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(379, 288);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.tB_password2);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Registrieren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrieren";
            this.Load += new System.EventHandler(this.Registrieren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_register;
        private Button btn_back;
        private TextBox tB_password;
        private TextBox tB_password2;
        private TextBox tB_name;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}