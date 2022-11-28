namespace Stundenplaner_Mader_Hauser
{
    partial class Subject
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
            this.btn_teacherSearch = new System.Windows.Forms.Button();
            this.tb_teacherSearchDatabase = new System.Windows.Forms.TextBox();
            this.dG_teacher = new System.Windows.Forms.DataGridView();
            this.btn_teacherLoad = new System.Windows.Forms.Button();
            this.btn_teacherDelete = new System.Windows.Forms.Button();
            this.btn_teacherSave = new System.Windows.Forms.Button();
            this.btn_teacherBack = new System.Windows.Forms.Button();
            this.cb_subjectAdd = new System.Windows.Forms.CheckBox();
            this.tb_teacherName = new System.Windows.Forms.TextBox();
            this.lbl_subjectSchularbeit = new System.Windows.Forms.Label();
            this.lbl_subjectName = new System.Windows.Forms.Label();
            this.cB_subjectSchularbeit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dG_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_teacherSearch
            // 
            this.btn_teacherSearch.Location = new System.Drawing.Point(218, 133);
            this.btn_teacherSearch.Name = "btn_teacherSearch";
            this.btn_teacherSearch.Size = new System.Drawing.Size(89, 28);
            this.btn_teacherSearch.TabIndex = 60;
            this.btn_teacherSearch.Text = "Suchen";
            this.btn_teacherSearch.UseVisualStyleBackColor = true;
            // 
            // tb_teacherSearchDatabase
            // 
            this.tb_teacherSearchDatabase.Location = new System.Drawing.Point(9, 137);
            this.tb_teacherSearchDatabase.Name = "tb_teacherSearchDatabase";
            this.tb_teacherSearchDatabase.Size = new System.Drawing.Size(203, 23);
            this.tb_teacherSearchDatabase.TabIndex = 59;
            // 
            // dG_teacher
            // 
            this.dG_teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_teacher.Location = new System.Drawing.Point(9, 167);
            this.dG_teacher.Name = "dG_teacher";
            this.dG_teacher.ReadOnly = true;
            this.dG_teacher.RowTemplate.Height = 25;
            this.dG_teacher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dG_teacher.Size = new System.Drawing.Size(298, 229);
            this.dG_teacher.TabIndex = 58;
            // 
            // btn_teacherLoad
            // 
            this.btn_teacherLoad.Location = new System.Drawing.Point(86, 402);
            this.btn_teacherLoad.Name = "btn_teacherLoad";
            this.btn_teacherLoad.Size = new System.Drawing.Size(68, 28);
            this.btn_teacherLoad.TabIndex = 55;
            this.btn_teacherLoad.Text = "Laden";
            this.btn_teacherLoad.UseVisualStyleBackColor = true;
            // 
            // btn_teacherDelete
            // 
            this.btn_teacherDelete.Location = new System.Drawing.Point(160, 402);
            this.btn_teacherDelete.Name = "btn_teacherDelete";
            this.btn_teacherDelete.Size = new System.Drawing.Size(68, 28);
            this.btn_teacherDelete.TabIndex = 54;
            this.btn_teacherDelete.Text = "Löschen";
            this.btn_teacherDelete.UseVisualStyleBackColor = true;
            // 
            // btn_teacherSave
            // 
            this.btn_teacherSave.Location = new System.Drawing.Point(234, 402);
            this.btn_teacherSave.Name = "btn_teacherSave";
            this.btn_teacherSave.Size = new System.Drawing.Size(68, 28);
            this.btn_teacherSave.TabIndex = 53;
            this.btn_teacherSave.Text = "Speichern";
            this.btn_teacherSave.UseVisualStyleBackColor = true;
            // 
            // btn_teacherBack
            // 
            this.btn_teacherBack.Location = new System.Drawing.Point(12, 402);
            this.btn_teacherBack.Name = "btn_teacherBack";
            this.btn_teacherBack.Size = new System.Drawing.Size(68, 28);
            this.btn_teacherBack.TabIndex = 52;
            this.btn_teacherBack.Text = "Zurück";
            this.btn_teacherBack.UseVisualStyleBackColor = true;
            // 
            // cb_subjectAdd
            // 
            this.cb_subjectAdd.AutoSize = true;
            this.cb_subjectAdd.Location = new System.Drawing.Point(12, 12);
            this.cb_subjectAdd.Name = "cb_subjectAdd";
            this.cb_subjectAdd.Size = new System.Drawing.Size(114, 19);
            this.cb_subjectAdd.TabIndex = 51;
            this.cb_subjectAdd.Text = "Fach hinzufügen";
            this.cb_subjectAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cb_subjectAdd.UseVisualStyleBackColor = true;
            // 
            // tb_teacherName
            // 
            this.tb_teacherName.Location = new System.Drawing.Point(120, 48);
            this.tb_teacherName.Name = "tb_teacherName";
            this.tb_teacherName.Size = new System.Drawing.Size(187, 23);
            this.tb_teacherName.TabIndex = 47;
            // 
            // lbl_subjectSchularbeit
            // 
            this.lbl_subjectSchularbeit.AutoSize = true;
            this.lbl_subjectSchularbeit.Location = new System.Drawing.Point(9, 85);
            this.lbl_subjectSchularbeit.Name = "lbl_subjectSchularbeit";
            this.lbl_subjectSchularbeit.Size = new System.Drawing.Size(105, 15);
            this.lbl_subjectSchularbeit.TabIndex = 44;
            this.lbl_subjectSchularbeit.Text = "Schularbeitenfach:";
            // 
            // lbl_subjectName
            // 
            this.lbl_subjectName.AutoSize = true;
            this.lbl_subjectName.Location = new System.Drawing.Point(9, 51);
            this.lbl_subjectName.Name = "lbl_subjectName";
            this.lbl_subjectName.Size = new System.Drawing.Size(42, 15);
            this.lbl_subjectName.TabIndex = 43;
            this.lbl_subjectName.Text = "Name:";
            // 
            // cB_subjectSchularbeit
            // 
            this.cB_subjectSchularbeit.AutoSize = true;
            this.cB_subjectSchularbeit.Location = new System.Drawing.Point(120, 85);
            this.cB_subjectSchularbeit.Name = "cB_subjectSchularbeit";
            this.cB_subjectSchularbeit.Size = new System.Drawing.Size(15, 14);
            this.cB_subjectSchularbeit.TabIndex = 61;
            this.cB_subjectSchularbeit.UseVisualStyleBackColor = true;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 437);
            this.Controls.Add(this.cB_subjectSchularbeit);
            this.Controls.Add(this.btn_teacherSearch);
            this.Controls.Add(this.tb_teacherSearchDatabase);
            this.Controls.Add(this.dG_teacher);
            this.Controls.Add(this.btn_teacherLoad);
            this.Controls.Add(this.btn_teacherDelete);
            this.Controls.Add(this.btn_teacherSave);
            this.Controls.Add(this.btn_teacherBack);
            this.Controls.Add(this.cb_subjectAdd);
            this.Controls.Add(this.tb_teacherName);
            this.Controls.Add(this.lbl_subjectSchularbeit);
            this.Controls.Add(this.lbl_subjectName);
            this.Name = "Subject";
            this.Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)(this.dG_teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_teacherSearch;
        private TextBox tb_teacherSearchDatabase;
        private DataGridView dG_teacher;
        private Button btn_teacherLoad;
        private Button btn_teacherDelete;
        private Button btn_teacherSave;
        private Button btn_teacherBack;
        private CheckBox cb_subjectAdd;
        private TextBox tb_teacherName;
        private Label lbl_subjectSchularbeit;
        private Label lbl_subjectName;
        private CheckBox cB_subjectSchularbeit;
    }
}