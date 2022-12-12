namespace Stundenplaner_Mader_Hauser
{
    partial class Klasse
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
            this.tb_classRoom = new System.Windows.Forms.TextBox();
            this.lbl_classRoom = new System.Windows.Forms.Label();
            this.btn_classSearch = new System.Windows.Forms.Button();
            this.tb_classSearchDatabase = new System.Windows.Forms.TextBox();
            this.dG_class = new System.Windows.Forms.DataGridView();
            this.btn_classLoad = new System.Windows.Forms.Button();
            this.btn_classDelete = new System.Windows.Forms.Button();
            this.btn_classSave = new System.Windows.Forms.Button();
            this.btn_classBack = new System.Windows.Forms.Button();
            this.cb_classAdd = new System.Windows.Forms.CheckBox();
            this.tb_className = new System.Windows.Forms.TextBox();
            this.lbl_className = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dG_class)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_classRoom
            // 
            this.tb_classRoom.Location = new System.Drawing.Point(120, 88);
            this.tb_classRoom.Name = "tb_classRoom";
            this.tb_classRoom.Size = new System.Drawing.Size(187, 23);
            this.tb_classRoom.TabIndex = 77;
            // 
            // lbl_classRoom
            // 
            this.lbl_classRoom.AutoSize = true;
            this.lbl_classRoom.Location = new System.Drawing.Point(9, 91);
            this.lbl_classRoom.Name = "lbl_classRoom";
            this.lbl_classRoom.Size = new System.Drawing.Size(41, 15);
            this.lbl_classRoom.TabIndex = 76;
            this.lbl_classRoom.Text = "Raum:";
            // 
            // btn_classSearch
            // 
            this.btn_classSearch.Location = new System.Drawing.Point(218, 127);
            this.btn_classSearch.Name = "btn_classSearch";
            this.btn_classSearch.Size = new System.Drawing.Size(89, 28);
            this.btn_classSearch.TabIndex = 74;
            this.btn_classSearch.Text = "Suchen";
            this.btn_classSearch.UseVisualStyleBackColor = true;
            // 
            // tb_classSearchDatabase
            // 
            this.tb_classSearchDatabase.Location = new System.Drawing.Point(9, 131);
            this.tb_classSearchDatabase.Name = "tb_classSearchDatabase";
            this.tb_classSearchDatabase.Size = new System.Drawing.Size(203, 23);
            this.tb_classSearchDatabase.TabIndex = 73;
            this.tb_classSearchDatabase.TextChanged += new System.EventHandler(this.tb_classSearchDatabase_TextChanged);
            // 
            // dG_class
            // 
            this.dG_class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_class.Location = new System.Drawing.Point(9, 161);
            this.dG_class.Name = "dG_class";
            this.dG_class.ReadOnly = true;
            this.dG_class.RowTemplate.Height = 25;
            this.dG_class.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dG_class.Size = new System.Drawing.Size(298, 229);
            this.dG_class.TabIndex = 72;
            // 
            // btn_classLoad
            // 
            this.btn_classLoad.Location = new System.Drawing.Point(86, 396);
            this.btn_classLoad.Name = "btn_classLoad";
            this.btn_classLoad.Size = new System.Drawing.Size(68, 28);
            this.btn_classLoad.TabIndex = 71;
            this.btn_classLoad.Text = "Laden";
            this.btn_classLoad.UseVisualStyleBackColor = true;
            this.btn_classLoad.Click += new System.EventHandler(this.btn_classLoad_Click);
            // 
            // btn_classDelete
            // 
            this.btn_classDelete.Location = new System.Drawing.Point(160, 396);
            this.btn_classDelete.Name = "btn_classDelete";
            this.btn_classDelete.Size = new System.Drawing.Size(68, 28);
            this.btn_classDelete.TabIndex = 70;
            this.btn_classDelete.Text = "Löschen";
            this.btn_classDelete.UseVisualStyleBackColor = true;
            this.btn_classDelete.Click += new System.EventHandler(this.btn_classDelete_Click);
            // 
            // btn_classSave
            // 
            this.btn_classSave.Location = new System.Drawing.Point(234, 396);
            this.btn_classSave.Name = "btn_classSave";
            this.btn_classSave.Size = new System.Drawing.Size(68, 28);
            this.btn_classSave.TabIndex = 69;
            this.btn_classSave.Text = "Speichern";
            this.btn_classSave.UseVisualStyleBackColor = true;
            this.btn_classSave.Click += new System.EventHandler(this.btn_classSave_Click);
            // 
            // btn_classBack
            // 
            this.btn_classBack.Location = new System.Drawing.Point(12, 396);
            this.btn_classBack.Name = "btn_classBack";
            this.btn_classBack.Size = new System.Drawing.Size(68, 28);
            this.btn_classBack.TabIndex = 68;
            this.btn_classBack.Text = "Zurück";
            this.btn_classBack.UseVisualStyleBackColor = true;
            this.btn_classBack.Click += new System.EventHandler(this.btn_classBack_Click);
            // 
            // cb_classAdd
            // 
            this.cb_classAdd.AutoSize = true;
            this.cb_classAdd.Location = new System.Drawing.Point(12, 12);
            this.cb_classAdd.Name = "cb_classAdd";
            this.cb_classAdd.Size = new System.Drawing.Size(121, 19);
            this.cb_classAdd.TabIndex = 67;
            this.cb_classAdd.Text = "Klasse hinzufügen";
            this.cb_classAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cb_classAdd.UseVisualStyleBackColor = true;
            this.cb_classAdd.CheckedChanged += new System.EventHandler(this.cb_classAdd_CheckedChanged);
            // 
            // tb_className
            // 
            this.tb_className.Location = new System.Drawing.Point(120, 48);
            this.tb_className.Name = "tb_className";
            this.tb_className.Size = new System.Drawing.Size(187, 23);
            this.tb_className.TabIndex = 66;
            // 
            // lbl_className
            // 
            this.lbl_className.AutoSize = true;
            this.lbl_className.Location = new System.Drawing.Point(9, 51);
            this.lbl_className.Name = "lbl_className";
            this.lbl_className.Size = new System.Drawing.Size(42, 15);
            this.lbl_className.TabIndex = 64;
            this.lbl_className.Text = "Name:";
            // 
            // Klasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 433);
            this.Controls.Add(this.tb_classRoom);
            this.Controls.Add(this.lbl_classRoom);
            this.Controls.Add(this.btn_classSearch);
            this.Controls.Add(this.tb_classSearchDatabase);
            this.Controls.Add(this.dG_class);
            this.Controls.Add(this.btn_classLoad);
            this.Controls.Add(this.btn_classDelete);
            this.Controls.Add(this.btn_classSave);
            this.Controls.Add(this.btn_classBack);
            this.Controls.Add(this.cb_classAdd);
            this.Controls.Add(this.tb_className);
            this.Controls.Add(this.lbl_className);
            this.Name = "Klasse";
            this.Text = "Klasse";
            this.Load += new System.EventHandler(this.Klasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dG_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_classRoom;
        private Label lbl_classRoom;
        private Button btn_classSearch;
        private TextBox tb_classSearchDatabase;
        private DataGridView dG_class;
        private Button btn_classLoad;
        private Button btn_classDelete;
        private Button btn_classSave;
        private Button btn_classBack;
        private CheckBox cb_classAdd;
        private TextBox tb_className;
        private Label lbl_className;
    }
}