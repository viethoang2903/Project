namespace Project
{
    partial class frmStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbID = new Label();
            lbName = new Label();
            lbAddress = new Label();
            lbGPA = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
            tbAddress = new TextBox();
            tbGPA = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            tbSearch = new TextBox();
            btnSearch = new Button();
            dgvListStudent = new DataGridView();
            dgvSearch = new DataGridView();
            gbSearch = new GroupBox();
            label1 = new Label();
            btnLoad = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(12, 75);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 0;
            lbID.Text = "ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(12, 119);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(12, 156);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(62, 20);
            lbAddress.TabIndex = 2;
            lbAddress.Text = "Address";
            // 
            // lbGPA
            // 
            lbGPA.AutoSize = true;
            lbGPA.Location = new Point(12, 197);
            lbGPA.Name = "lbGPA";
            lbGPA.Size = new Size(36, 20);
            lbGPA.TabIndex = 3;
            lbGPA.Text = "GPA";
            // 
            // tbID
            // 
            tbID.Location = new Point(99, 68);
            tbID.Name = "tbID";
            tbID.Size = new Size(200, 27);
            tbID.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(99, 112);
            tbName.Name = "tbName";
            tbName.Size = new Size(200, 27);
            tbName.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(99, 149);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(200, 27);
            tbAddress.TabIndex = 6;
            // 
            // tbGPA
            // 
            tbGPA.Location = new Point(99, 190);
            tbGPA.Name = "tbGPA";
            tbGPA.Size = new Size(200, 27);
            tbGPA.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(126, 231);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(242, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(536, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save To File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(162, 39);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(125, 27);
            tbSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(19, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvListStudent
            // 
            dgvListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudent.Location = new Point(342, 12);
            dgvListStudent.Name = "dgvListStudent";
            dgvListStudent.RowHeadersWidth = 51;
            dgvListStudent.RowTemplate.Height = 29;
            dgvListStudent.Size = new Size(446, 205);
            dgvListStudent.TabIndex = 15;
            // 
            // dgvSearch
            // 
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Location = new Point(400, 277);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.RowHeadersWidth = 51;
            dgvSearch.RowTemplate.Height = 29;
            dgvSearch.Size = new Size(388, 168);
            dgvSearch.TabIndex = 16;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(tbSearch);
            gbSearch.Location = new Point(12, 266);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(382, 179);
            gbSearch.TabIndex = 17;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, -4);
            label1.Name = "label1";
            label1.Size = new Size(328, 31);
            label1.TabIndex = 18;
            label1.Text = "Student Management System";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(380, 231);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(679, 237);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Controls.Add(gbSearch);
            Controls.Add(dgvSearch);
            Controls.Add(dgvListStudent);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(tbGPA);
            Controls.Add(tbAddress);
            Controls.Add(tbName);
            Controls.Add(tbID);
            Controls.Add(lbGPA);
            Controls.Add(lbAddress);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Name = "frmStudent";
            Text = "List Of Students";
            Load += frmStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private Label lbName;
        private Label lbAddress;
        private Label lbGPA;
        private TextBox tbID;
        private TextBox tbName;
        private TextBox tbAddress;
        private TextBox tbGPA;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private TextBox tbSearch;
        private Button btnSearch;
        private DataGridView dgvListStudent;
        private DataGridView dgvSearch;
        private GroupBox gbSearch;
        private Label label1;
        private Button btnLoad;
        private Button btnRefresh;
    }
}
