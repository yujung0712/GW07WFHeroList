namespace GW07WFHeroList {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblFilter = new Label();
            cmbFilter = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            listHero = new ListBox();
            lblCount = new Label();
            grpAdd = new GroupBox();
            lblName = new Label();
            txtName = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblDifficulty = new Label();
            numDifficulty = new NumericUpDown();
            lblFavorite = new Label();
            numFavorite = new NumericUpDown();
            btnAdd = new Button();
            btnDelete = new Button();
            grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDifficulty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFavorite).BeginInit();
            SuspendLayout();
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(16, 19);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(44, 23);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "역할";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.AddRange(new object[] { "전체", "돌격", "공격", "지원" });
            cmbFilter.Location = new Point(58, 15);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(110, 31);
            cmbFilter.TabIndex = 0;
            cmbFilter.SelectedIndexChanged += OnFilterChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(190, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(44, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "검색";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(232, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "영웅 이름";
            txtSearch.Size = new Size(272, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += OnFilterChanged;
            // 
            // listHero
            // 
            listHero.BorderStyle = BorderStyle.FixedSingle;
            listHero.Font = new Font("맑은 고딕", 12F);
            listHero.FormattingEnabled = true;
            listHero.Location = new Point(16, 55);
            listHero.Name = "listHero";
            listHero.Size = new Size(488, 310);
            listHero.TabIndex = 2;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(16, 382);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(59, 23);
            lblCount.TabIndex = 3;
            lblCount.Text = "총 0명";
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(lblName);
            grpAdd.Controls.Add(txtName);
            grpAdd.Controls.Add(lblRole);
            grpAdd.Controls.Add(cmbRole);
            grpAdd.Controls.Add(lblDifficulty);
            grpAdd.Controls.Add(numDifficulty);
            grpAdd.Controls.Add(lblFavorite);
            grpAdd.Controls.Add(numFavorite);
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Location = new Point(16, 412);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(488, 130);
            grpAdd.TabIndex = 3;
            grpAdd.TabStop = false;
            grpAdd.Text = "영웅 추가";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(44, 23);
            lblName.TabIndex = 0;
            lblName.Text = "이름";
            // 
            // txtName
            // 
            txtName.Location = new Point(72, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 30);
            txtName.TabIndex = 0;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(262, 36);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(44, 23);
            lblRole.TabIndex = 1;
            lblRole.Text = "역할";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "돌격", "공격", "지원" });
            cmbRole.Location = new Point(310, 32);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(160, 31);
            cmbRole.TabIndex = 1;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(10, 83);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(61, 23);
            lblDifficulty.TabIndex = 2;
            lblDifficulty.Text = "난이도";
            // 
            // numDifficulty
            // 
            numDifficulty.Location = new Point(72, 79);
            numDifficulty.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numDifficulty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDifficulty.Name = "numDifficulty";
            numDifficulty.Size = new Size(55, 30);
            numDifficulty.TabIndex = 2;
            numDifficulty.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblFavorite
            // 
            lblFavorite.AutoSize = true;
            lblFavorite.Location = new Point(133, 83);
            lblFavorite.Name = "lblFavorite";
            lblFavorite.Size = new Size(61, 23);
            lblFavorite.TabIndex = 3;
            lblFavorite.Text = "선호도";
            // 
            // numFavorite
            // 
            numFavorite.Location = new Point(194, 79);
            numFavorite.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numFavorite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFavorite.Name = "numFavorite";
            numFavorite.Size = new Size(55, 30);
            numFavorite.TabIndex = 3;
            numFavorite.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(249, 158, 26);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(270, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += OnAdd;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(225, 225, 225);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(60, 60, 60);
            btnDelete.Location = new Point(16, 556);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(488, 38);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "선택한 영웅 삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += OnDelete;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 610);
            Controls.Add(lblFilter);
            Controls.Add(cmbFilter);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(listHero);
            Controls.Add(lblCount);
            Controls.Add(grpAdd);
            Controls.Add(btnDelete);
            Font = new Font("맑은 고딕", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "오버워치 영웅 목록";
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDifficulty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFavorite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFilter;
        private ComboBox cmbFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private ListBox listHero;
        private Label lblCount;
        private GroupBox grpAdd;
        private Label lblName;
        private TextBox txtName;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblDifficulty;
        private NumericUpDown numDifficulty;
        private Label lblFavorite;
        private NumericUpDown numFavorite;
        private Button btnAdd;
        private Button btnDelete;
    }
}