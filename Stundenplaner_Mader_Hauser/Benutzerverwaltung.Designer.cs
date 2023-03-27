namespace Stundenplaner_Mader_Hauser
{
    partial class Benutzerverwaltung
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
            this.dG_teacher = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dG_student = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_studentBack = new System.Windows.Forms.Button();
            this.dG_user = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dG_teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dG_teacher
            // 
            this.dG_teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_teacher.Location = new System.Drawing.Point(394, 237);
            this.dG_teacher.Name = "dG_teacher";
            this.dG_teacher.ReadOnly = true;
            this.dG_teacher.RowTemplate.Height = 25;
            this.dG_teacher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dG_teacher.Size = new System.Drawing.Size(394, 161);
            this.dG_teacher.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Lehrer:";
            // 
            // dG_student
            // 
            this.dG_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_student.Location = new System.Drawing.Point(394, 46);
            this.dG_student.Name = "dG_student";
            this.dG_student.ReadOnly = true;
            this.dG_student.RowTemplate.Height = 25;
            this.dG_student.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dG_student.Size = new System.Drawing.Size(394, 161);
            this.dG_student.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Schüler:";
            // 
            // btn_studentBack
            // 
            this.btn_studentBack.Location = new System.Drawing.Point(12, 410);
            this.btn_studentBack.Name = "btn_studentBack";
            this.btn_studentBack.Size = new System.Drawing.Size(89, 28);
            this.btn_studentBack.TabIndex = 45;
            this.btn_studentBack.Text = "Zurück";
            this.btn_studentBack.UseVisualStyleBackColor = true;
            this.btn_studentBack.Click += new System.EventHandler(this.btn_studentBack_Click);
            // 
            // dG_user
            // 
            this.dG_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_user.Location = new System.Drawing.Point(12, 46);
            this.dG_user.Name = "dG_user";
            this.dG_user.RowTemplate.Height = 25;
            this.dG_user.Size = new System.Drawing.Size(341, 351);
            this.dG_user.TabIndex = 46;
            // 
            // Benutzerverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dG_user);
            this.Controls.Add(this.btn_studentBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dG_student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dG_teacher);
            this.Name = "Benutzerverwaltung";
            this.Text = "Benutzerverwaltung";
            this.Load += new System.EventHandler(this.Benutzerverwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dG_teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dG_teacher;
        private Label label1;
        private DataGridView dG_student;
        private Label label2;
        private Button btn_studentBack;
        private DataGridView dG_user;
    }
}