namespace Stundenplaner_Mader_Hauser
{
    partial class Main_admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_timetalbe = new System.Windows.Forms.Button();
            this.lbl_wellcome = new System.Windows.Forms.Label();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.btn_classes = new System.Windows.Forms.Button();
            this.btn_subjects = new System.Windows.Forms.Button();
            this.btn_createTimetable = new System.Windows.Forms.Button();
            this.btn_benutzer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stundenplaner_Mader_Hauser.Properties.Resources.MicrosoftTeams_image1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(211, 332);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Abmelden";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_timetalbe
            // 
            this.btn_timetalbe.Location = new System.Drawing.Point(14, 144);
            this.btn_timetalbe.Name = "btn_timetalbe";
            this.btn_timetalbe.Size = new System.Drawing.Size(123, 56);
            this.btn_timetalbe.TabIndex = 2;
            this.btn_timetalbe.Text = "Stundenplan";
            this.btn_timetalbe.UseVisualStyleBackColor = true;
            this.btn_timetalbe.Click += new System.EventHandler(this.btn_timetalbe_Click);
            // 
            // lbl_wellcome
            // 
            this.lbl_wellcome.AutoSize = true;
            this.lbl_wellcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_wellcome.Location = new System.Drawing.Point(12, 101);
            this.lbl_wellcome.Name = "lbl_wellcome";
            this.lbl_wellcome.Size = new System.Drawing.Size(0, 25);
            this.lbl_wellcome.TabIndex = 3;
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(143, 144);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(143, 41);
            this.btn_student.TabIndex = 4;
            this.btn_student.Text = "Schüler";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.Location = new System.Drawing.Point(143, 191);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(143, 41);
            this.btn_teacher.TabIndex = 5;
            this.btn_teacher.Text = "Lehrpersonen";
            this.btn_teacher.UseVisualStyleBackColor = true;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // btn_classes
            // 
            this.btn_classes.Location = new System.Drawing.Point(143, 238);
            this.btn_classes.Name = "btn_classes";
            this.btn_classes.Size = new System.Drawing.Size(143, 41);
            this.btn_classes.TabIndex = 6;
            this.btn_classes.Text = "Klassen";
            this.btn_classes.UseVisualStyleBackColor = true;
            this.btn_classes.Click += new System.EventHandler(this.btn_classes_Click);
            // 
            // btn_subjects
            // 
            this.btn_subjects.Location = new System.Drawing.Point(143, 285);
            this.btn_subjects.Name = "btn_subjects";
            this.btn_subjects.Size = new System.Drawing.Size(143, 41);
            this.btn_subjects.TabIndex = 7;
            this.btn_subjects.Text = "Fächer";
            this.btn_subjects.UseVisualStyleBackColor = true;
            this.btn_subjects.Click += new System.EventHandler(this.btn_subjects_Click);
            // 
            // btn_createTimetable
            // 
            this.btn_createTimetable.Location = new System.Drawing.Point(12, 208);
            this.btn_createTimetable.Name = "btn_createTimetable";
            this.btn_createTimetable.Size = new System.Drawing.Size(125, 56);
            this.btn_createTimetable.TabIndex = 8;
            this.btn_createTimetable.Text = "Stundenplan erstellen/ändern";
            this.btn_createTimetable.UseVisualStyleBackColor = true;
            this.btn_createTimetable.Click += new System.EventHandler(this.btn_createTimetable_Click);
            // 
            // btn_benutzer
            // 
            this.btn_benutzer.Location = new System.Drawing.Point(14, 270);
            this.btn_benutzer.Name = "btn_benutzer";
            this.btn_benutzer.Size = new System.Drawing.Size(123, 56);
            this.btn_benutzer.TabIndex = 9;
            this.btn_benutzer.Text = "Benutzerverwaltung";
            this.btn_benutzer.UseVisualStyleBackColor = true;
            this.btn_benutzer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(300, 367);
            this.Controls.Add(this.btn_benutzer);
            this.Controls.Add(this.btn_createTimetable);
            this.Controls.Add(this.btn_subjects);
            this.Controls.Add(this.btn_classes);
            this.Controls.Add(this.btn_teacher);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.lbl_wellcome);
            this.Controls.Add(this.btn_timetalbe);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Main_admin";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_admin";
            this.Load += new System.EventHandler(this.Main_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_logout;
        private Button btn_timetalbe;
        private Label lbl_wellcome;
        private Button btn_student;
        private Button btn_teacher;
        private Button btn_classes;
        private Button btn_subjects;
        private Button btn_createTimetable;
        private Button btn_benutzer;
    }
}