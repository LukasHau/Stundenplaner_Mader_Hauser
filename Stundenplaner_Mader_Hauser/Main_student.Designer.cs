namespace Stundenplaner_Mader_Hauser
{
    partial class Main_student
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
            this.lbl_wellcome = new System.Windows.Forms.Label();
            this.btn_timetalbe = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_wellcome
            // 
            this.lbl_wellcome.AutoSize = true;
            this.lbl_wellcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_wellcome.Location = new System.Drawing.Point(12, 113);
            this.lbl_wellcome.Name = "lbl_wellcome";
            this.lbl_wellcome.Size = new System.Drawing.Size(0, 25);
            this.lbl_wellcome.TabIndex = 13;
            // 
            // btn_timetalbe
            // 
            this.btn_timetalbe.Location = new System.Drawing.Point(12, 151);
            this.btn_timetalbe.Name = "btn_timetalbe";
            this.btn_timetalbe.Size = new System.Drawing.Size(280, 56);
            this.btn_timetalbe.TabIndex = 12;
            this.btn_timetalbe.Text = "Stundenplan";
            this.btn_timetalbe.UseVisualStyleBackColor = true;
            this.btn_timetalbe.Click += new System.EventHandler(this.btn_timetalbe_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(217, 213);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "Abmelden";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stundenplaner_Mader_Hauser.Properties.Resources.MicrosoftTeams_image1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Main_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 240);
            this.Controls.Add(this.lbl_wellcome);
            this.Controls.Add(this.btn_timetalbe);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main_student";
            this.Text = "Main_student";
            this.Load += new System.EventHandler(this.Main_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_wellcome;
        private Button btn_timetalbe;
        private Button btn_logout;
        private PictureBox pictureBox1;
    }
}