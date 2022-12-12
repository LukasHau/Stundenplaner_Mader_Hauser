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
            this.btn_subjectSearch = new System.Windows.Forms.Button();
            this.tb_subjectSearchDatabase = new System.Windows.Forms.TextBox();
            this.dG_subject = new System.Windows.Forms.DataGridView();
            this.btn_subjectLoad = new System.Windows.Forms.Button();
            this.btn_subejctDelete = new System.Windows.Forms.Button();
            this.btn_subejctSave = new System.Windows.Forms.Button();
            this.btn_subjectBack = new System.Windows.Forms.Button();
            this.cb_subjectAdd = new System.Windows.Forms.CheckBox();
            this.tb_SubjectName = new System.Windows.Forms.TextBox();
            this.lbl_subjectSchularbeit = new System.Windows.Forms.Label();
            this.lbl_subjectName = new System.Windows.Forms.Label();
            this.cB_subjectSchularbeit = new System.Windows.Forms.CheckBox();
            this.lbl_subjectFullname = new System.Windows.Forms.Label();
            this.tb_SubjectFullname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dG_subject)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_subjectSearch
            // 
            this.btn_subjectSearch.Location = new System.Drawing.Point(223, 155);
            this.btn_subjectSearch.Name = "btn_subjectSearch";
            this.btn_subjectSearch.Size = new System.Drawing.Size(89, 28);
            this.btn_subjectSearch.TabIndex = 60;
            this.btn_subjectSearch.Text = "Suchen";
            this.btn_subjectSearch.UseVisualStyleBackColor = true;
            this.btn_subjectSearch.Click += new System.EventHandler(this.btn_subjectSearch_Click);
            // 
            // tb_subjectSearchDatabase
            // 
            this.tb_subjectSearchDatabase.Location = new System.Drawing.Point(14, 159);
            this.tb_subjectSearchDatabase.Name = "tb_subjectSearchDatabase";
            this.tb_subjectSearchDatabase.Size = new System.Drawing.Size(203, 23);
            this.tb_subjectSearchDatabase.TabIndex = 59;
            this.tb_subjectSearchDatabase.TextChanged += new System.EventHandler(this.tb_subjectSearchDatabase_TextChanged);
            // 
            // dG_subject
            // 
            this.dG_subject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_subject.Location = new System.Drawing.Point(14, 189);
            this.dG_subject.Name = "dG_subject";
            this.dG_subject.ReadOnly = true;
            this.dG_subject.RowTemplate.Height = 25;
            this.dG_subject.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dG_subject.Size = new System.Drawing.Size(298, 229);
            this.dG_subject.TabIndex = 58;
            // 
            // btn_subjectLoad
            // 
            this.btn_subjectLoad.Location = new System.Drawing.Point(91, 424);
            this.btn_subjectLoad.Name = "btn_subjectLoad";
            this.btn_subjectLoad.Size = new System.Drawing.Size(68, 28);
            this.btn_subjectLoad.TabIndex = 55;
            this.btn_subjectLoad.Text = "Laden";
            this.btn_subjectLoad.UseVisualStyleBackColor = true;
            this.btn_subjectLoad.Click += new System.EventHandler(this.btn_subjectLoad_Click);
            // 
            // btn_subejctDelete
            // 
            this.btn_subejctDelete.Location = new System.Drawing.Point(165, 424);
            this.btn_subejctDelete.Name = "btn_subejctDelete";
            this.btn_subejctDelete.Size = new System.Drawing.Size(68, 28);
            this.btn_subejctDelete.TabIndex = 54;
            this.btn_subejctDelete.Text = "Löschen";
            this.btn_subejctDelete.UseVisualStyleBackColor = true;
            this.btn_subejctDelete.Click += new System.EventHandler(this.btn_subejctDelete_Click);
            // 
            // btn_subejctSave
            // 
            this.btn_subejctSave.Location = new System.Drawing.Point(239, 424);
            this.btn_subejctSave.Name = "btn_subejctSave";
            this.btn_subejctSave.Size = new System.Drawing.Size(68, 28);
            this.btn_subejctSave.TabIndex = 53;
            this.btn_subejctSave.Text = "Speichern";
            this.btn_subejctSave.UseVisualStyleBackColor = true;
            this.btn_subejctSave.Click += new System.EventHandler(this.btn_teacherSave_Click);
            // 
            // btn_subjectBack
            // 
            this.btn_subjectBack.Location = new System.Drawing.Point(17, 424);
            this.btn_subjectBack.Name = "btn_subjectBack";
            this.btn_subjectBack.Size = new System.Drawing.Size(68, 28);
            this.btn_subjectBack.TabIndex = 52;
            this.btn_subjectBack.Text = "Zurück";
            this.btn_subjectBack.UseVisualStyleBackColor = true;
            this.btn_subjectBack.Click += new System.EventHandler(this.btn_subjectBack_Click);
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
            this.cb_subjectAdd.CheckedChanged += new System.EventHandler(this.cb_subjectAdd_CheckedChanged);
            // 
            // tb_SubjectName
            // 
            this.tb_SubjectName.Location = new System.Drawing.Point(120, 48);
            this.tb_SubjectName.Name = "tb_SubjectName";
            this.tb_SubjectName.Size = new System.Drawing.Size(187, 23);
            this.tb_SubjectName.TabIndex = 47;
            // 
            // lbl_subjectSchularbeit
            // 
            this.lbl_subjectSchularbeit.AutoSize = true;
            this.lbl_subjectSchularbeit.Location = new System.Drawing.Point(11, 128);
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
            this.lbl_subjectName.Text = "Kürzel:";
            // 
            // cB_subjectSchularbeit
            // 
            this.cB_subjectSchularbeit.AutoSize = true;
            this.cB_subjectSchularbeit.Location = new System.Drawing.Point(122, 128);
            this.cB_subjectSchularbeit.Name = "cB_subjectSchularbeit";
            this.cB_subjectSchularbeit.Size = new System.Drawing.Size(15, 14);
            this.cB_subjectSchularbeit.TabIndex = 61;
            this.cB_subjectSchularbeit.UseVisualStyleBackColor = true;
            this.cB_subjectSchularbeit.CheckedChanged += new System.EventHandler(this.cB_subjectSchularbeit_CheckedChanged);
            // 
            // lbl_subjectFullname
            // 
            this.lbl_subjectFullname.AutoSize = true;
            this.lbl_subjectFullname.Location = new System.Drawing.Point(9, 91);
            this.lbl_subjectFullname.Name = "lbl_subjectFullname";
            this.lbl_subjectFullname.Size = new System.Drawing.Size(42, 15);
            this.lbl_subjectFullname.TabIndex = 62;
            this.lbl_subjectFullname.Text = "Name:";
            // 
            // tb_SubjectFullname
            // 
            this.tb_SubjectFullname.Location = new System.Drawing.Point(120, 88);
            this.tb_SubjectFullname.Name = "tb_SubjectFullname";
            this.tb_SubjectFullname.Size = new System.Drawing.Size(187, 23);
            this.tb_SubjectFullname.TabIndex = 63;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 464);
            this.Controls.Add(this.tb_SubjectFullname);
            this.Controls.Add(this.lbl_subjectFullname);
            this.Controls.Add(this.cB_subjectSchularbeit);
            this.Controls.Add(this.btn_subjectSearch);
            this.Controls.Add(this.tb_subjectSearchDatabase);
            this.Controls.Add(this.dG_subject);
            this.Controls.Add(this.btn_subjectLoad);
            this.Controls.Add(this.btn_subejctDelete);
            this.Controls.Add(this.btn_subejctSave);
            this.Controls.Add(this.btn_subjectBack);
            this.Controls.Add(this.cb_subjectAdd);
            this.Controls.Add(this.tb_SubjectName);
            this.Controls.Add(this.lbl_subjectSchularbeit);
            this.Controls.Add(this.lbl_subjectName);
            this.Name = "Subject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dG_subject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_subjectSearch;
        private TextBox tb_subjectSearchDatabase;
        private DataGridView dG_subject;
        private Button btn_subjectLoad;
        private Button btn_subejctDelete;
        private Button btn_subejctSave;
        private Button btn_subjectBack;
        private CheckBox cb_subjectAdd;
        private TextBox tb_SubjectName;
        private Label lbl_subjectSchularbeit;
        private Label lbl_subjectName;
        private CheckBox cB_subjectSchularbeit;
        private Label lbl_subjectFullname;
        private TextBox tb_SubjectFullname;
    }
}