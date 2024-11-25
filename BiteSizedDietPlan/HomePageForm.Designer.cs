namespace BiteSizedDietPlan
{
    partial class HomePageForm
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
            tableLayoutPanelBase = new TableLayoutPanel();
            flpMeals = new FlowLayoutPanel();
            tableLayoutPanel2L = new TableLayoutPanel();
            dgvMeals = new DataGridView();
            tableLayoutPanelL3 = new TableLayoutPanel();
            btnAddMeal = new Button();
            btnExit = new Button();
            btnMealTypeReport = new Button();
            btnComparisonReport = new Button();
            btnEndofDayReport = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dateTimePicker = new DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cmbMealType = new ComboBox();
            btnAddFoodEntryMeal = new Button();
            dgvFoodEntry = new DataGridView();
            tableLayoutPanelBase.SuspendLayout();
            tableLayoutPanel2L.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeals).BeginInit();
            tableLayoutPanelL3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodEntry).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelBase
            // 
            tableLayoutPanelBase.BackColor = Color.Transparent;
            tableLayoutPanelBase.ColumnCount = 3;
            tableLayoutPanelBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanelBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelBase.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanelBase.Controls.Add(flpMeals, 1, 0);
            tableLayoutPanelBase.Controls.Add(tableLayoutPanel2L, 0, 0);
            tableLayoutPanelBase.Dock = DockStyle.Fill;
            tableLayoutPanelBase.Location = new Point(0, 0);
            tableLayoutPanelBase.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            tableLayoutPanelBase.RowCount = 1;
            tableLayoutPanelBase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBase.Size = new Size(1532, 759);
            tableLayoutPanelBase.TabIndex = 1;
            // 
            // flpMeals
            // 
            flpMeals.AutoScroll = true;
            flpMeals.Dock = DockStyle.Fill;
            flpMeals.Location = new Point(1218, 1);
            flpMeals.Margin = new Padding(2, 1, 2, 1);
            flpMeals.Name = "flpMeals";
            flpMeals.Size = new Size(300, 757);
            flpMeals.TabIndex = 0;
            // 
            // tableLayoutPanel2L
            // 
            tableLayoutPanel2L.ColumnCount = 1;
            tableLayoutPanel2L.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2L.Controls.Add(dgvMeals, 0, 1);
            tableLayoutPanel2L.Controls.Add(tableLayoutPanelL3, 0, 2);
            tableLayoutPanel2L.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2L.Dock = DockStyle.Fill;
            tableLayoutPanel2L.Location = new Point(2, 1);
            tableLayoutPanel2L.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel2L.Name = "tableLayoutPanel2L";
            tableLayoutPanel2L.RowCount = 3;
            tableLayoutPanel2L.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2L.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2L.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2L.Size = new Size(1212, 757);
            tableLayoutPanel2L.TabIndex = 1;
            // 
            // dgvMeals
            // 
            dgvMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeals.Dock = DockStyle.Fill;
            dgvMeals.Location = new Point(2, 363);
            dgvMeals.Margin = new Padding(2, 1, 2, 1);
            dgvMeals.MultiSelect = false;
            dgvMeals.Name = "dgvMeals";
            dgvMeals.ReadOnly = true;
            dgvMeals.RowHeadersWidth = 82;
            dgvMeals.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeals.Size = new Size(1208, 360);
            dgvMeals.TabIndex = 2;
            dgvMeals.CellClick += dgvMeals_CellClick;
            // 
            // tableLayoutPanelL3
            // 
            tableLayoutPanelL3.ColumnCount = 5;
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanelL3.Controls.Add(btnAddMeal, 4, 0);
            tableLayoutPanelL3.Controls.Add(btnExit, 3, 0);
            tableLayoutPanelL3.Controls.Add(btnMealTypeReport, 2, 0);
            tableLayoutPanelL3.Controls.Add(btnComparisonReport, 1, 0);
            tableLayoutPanelL3.Controls.Add(btnEndofDayReport, 0, 0);
            tableLayoutPanelL3.Dock = DockStyle.Fill;
            tableLayoutPanelL3.Location = new Point(2, 725);
            tableLayoutPanelL3.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanelL3.Name = "tableLayoutPanelL3";
            tableLayoutPanelL3.RowCount = 1;
            tableLayoutPanelL3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelL3.Size = new Size(1208, 31);
            tableLayoutPanelL3.TabIndex = 0;
            // 
            // btnAddMeal
            // 
            btnAddMeal.BackColor = Color.IndianRed;
            btnAddMeal.Dock = DockStyle.Fill;
            btnAddMeal.FlatAppearance.BorderColor = Color.Black;
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnAddMeal.ForeColor = Color.Black;
            btnAddMeal.Location = new Point(1058, 1);
            btnAddMeal.Margin = new Padding(2, 1, 2, 1);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(148, 29);
            btnAddMeal.TabIndex = 5;
            btnAddMeal.Text = "YEMEK EKLE";
            btnAddMeal.UseVisualStyleBackColor = false;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(908, 1);
            btnExit.Margin = new Padding(2, 1, 2, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(146, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "ÇIKIŞ YAP";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMealTypeReport
            // 
            btnMealTypeReport.BackColor = Color.IndianRed;
            btnMealTypeReport.Dock = DockStyle.Fill;
            btnMealTypeReport.FlatAppearance.BorderColor = Color.Black;
            btnMealTypeReport.FlatStyle = FlatStyle.Flat;
            btnMealTypeReport.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnMealTypeReport.ForeColor = Color.Black;
            btnMealTypeReport.Location = new Point(606, 1);
            btnMealTypeReport.Margin = new Padding(2, 1, 2, 1);
            btnMealTypeReport.Name = "btnMealTypeReport";
            btnMealTypeReport.Size = new Size(298, 29);
            btnMealTypeReport.TabIndex = 3;
            btnMealTypeReport.Text = "Yemek Çeşidi Raporunu Görüntüle!";
            btnMealTypeReport.UseVisualStyleBackColor = false;
            btnMealTypeReport.Click += btnMealTypeReport_Click;
            // 
            // btnComparisonReport
            // 
            btnComparisonReport.BackColor = Color.IndianRed;
            btnComparisonReport.Dock = DockStyle.Fill;
            btnComparisonReport.FlatAppearance.BorderColor = Color.Black;
            btnComparisonReport.FlatStyle = FlatStyle.Flat;
            btnComparisonReport.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnComparisonReport.ForeColor = Color.Black;
            btnComparisonReport.Location = new Point(304, 1);
            btnComparisonReport.Margin = new Padding(2, 1, 2, 1);
            btnComparisonReport.Name = "btnComparisonReport";
            btnComparisonReport.Size = new Size(298, 29);
            btnComparisonReport.TabIndex = 2;
            btnComparisonReport.Text = "Kıyas Raporunu Görüntüle!";
            btnComparisonReport.UseVisualStyleBackColor = false;
            btnComparisonReport.Click += btnComparisonReport_Click;
            // 
            // btnEndofDayReport
            // 
            btnEndofDayReport.BackColor = Color.IndianRed;
            btnEndofDayReport.Dock = DockStyle.Fill;
            btnEndofDayReport.FlatAppearance.BorderColor = Color.Black;
            btnEndofDayReport.FlatStyle = FlatStyle.Flat;
            btnEndofDayReport.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnEndofDayReport.ForeColor = Color.Black;
            btnEndofDayReport.Location = new Point(2, 1);
            btnEndofDayReport.Margin = new Padding(2, 1, 2, 1);
            btnEndofDayReport.Name = "btnEndofDayReport";
            btnEndofDayReport.Size = new Size(298, 29);
            btnEndofDayReport.TabIndex = 1;
            btnEndofDayReport.Text = "Gün Sonu Raporunu Görüntüle!";
            btnEndofDayReport.UseVisualStyleBackColor = false;
            btnEndofDayReport.Click += btnEndofDayReport_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvFoodEntry, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 1);
            tableLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1208, 360);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dateTimePicker, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 1);
            tableLayoutPanel2.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.Size = new Size(1204, 24);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Dock = DockStyle.Fill;
            dateTimePicker.Location = new Point(2, 1);
            dateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(598, 23);
            dateTimePicker.TabIndex = 0;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cmbMealType);
            flowLayoutPanel1.Controls.Add(btnAddFoodEntryMeal);
            flowLayoutPanel1.Location = new Point(604, 1);
            flowLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(587, 22);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // cmbMealType
            // 
            cmbMealType.FormattingEnabled = true;
            cmbMealType.Location = new Point(2, 1);
            cmbMealType.Margin = new Padding(2, 1, 2, 1);
            cmbMealType.Name = "cmbMealType";
            cmbMealType.Size = new Size(196, 23);
            cmbMealType.TabIndex = 5;
            cmbMealType.Text = "Lütfen yemek girişi yapmak istediğiniz öğünü seçiniz.";
            // 
            // btnAddFoodEntryMeal
            // 
            btnAddFoodEntryMeal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFoodEntryMeal.ForeColor = Color.IndianRed;
            btnAddFoodEntryMeal.Location = new Point(202, 1);
            btnAddFoodEntryMeal.Margin = new Padding(2, 1, 2, 1);
            btnAddFoodEntryMeal.Name = "btnAddFoodEntryMeal";
            btnAddFoodEntryMeal.Size = new Size(81, 21);
            btnAddFoodEntryMeal.TabIndex = 4;
            btnAddFoodEntryMeal.Text = "Ekle";
            btnAddFoodEntryMeal.UseVisualStyleBackColor = true;
            btnAddFoodEntryMeal.Click += btnAddFoodEntryMeal_Click;
            // 
            // dgvFoodEntry
            // 
            dgvFoodEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodEntry.Dock = DockStyle.Fill;
            dgvFoodEntry.Location = new Point(2, 27);
            dgvFoodEntry.Margin = new Padding(2, 1, 2, 1);
            dgvFoodEntry.MultiSelect = false;
            dgvFoodEntry.Name = "dgvFoodEntry";
            dgvFoodEntry.ReadOnly = true;
            dgvFoodEntry.RowHeadersWidth = 82;
            dgvFoodEntry.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvFoodEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodEntry.Size = new Size(1204, 332);
            dgvFoodEntry.TabIndex = 3;
            dgvFoodEntry.CellClick += dgvFoodEntry_CellClick;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1532, 759);
            Controls.Add(tableLayoutPanelBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePageForm";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanelBase.ResumeLayout(false);
            tableLayoutPanel2L.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMeals).EndInit();
            tableLayoutPanelL3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFoodEntry).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanelBase;
        private FlowLayoutPanel flpMeals;
        private TableLayoutPanel tableLayoutPanel2L;
        private TableLayoutPanel tableLayoutPanelL3;
        private Button btnExit;
        private Button btnMealTypeReport;
        private Button btnComparisonReport;
        private Button btnEndofDayReport;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DateTimePicker dateTimePicker;
        private DataGridView dgvMeals;
        private DataGridView dgvFoodEntry;
        private Button btnAddFoodEntryMeal;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cmbMealType;
        private Button btnAddMeal;
    }
}