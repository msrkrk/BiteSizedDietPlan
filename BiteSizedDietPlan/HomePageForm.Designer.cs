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
            tableLayoutPanelBase.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBase.Controls.Add(flpMeals, 1, 0);
            tableLayoutPanelBase.Controls.Add(tableLayoutPanel2L, 0, 0);
            tableLayoutPanelBase.Dock = DockStyle.Fill;
            tableLayoutPanelBase.Location = new Point(0, 0);
            tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            tableLayoutPanelBase.RowCount = 1;
            tableLayoutPanelBase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBase.Size = new Size(3054, 1819);
            tableLayoutPanelBase.TabIndex = 1;
            // 
            // flpMeals
            // 
            flpMeals.AutoScroll = true;
            flpMeals.Dock = DockStyle.Fill;
            flpMeals.Location = new Point(2430, 3);
            flpMeals.Name = "flpMeals";
            flpMeals.Size = new Size(600, 1813);
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
            tableLayoutPanel2L.Location = new Point(3, 3);
            tableLayoutPanel2L.Name = "tableLayoutPanel2L";
            tableLayoutPanel2L.RowCount = 3;
            tableLayoutPanel2L.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2L.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2L.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2L.Size = new Size(2421, 1813);
            tableLayoutPanel2L.TabIndex = 1;
            // 
            // dgvMeals
            // 
            dgvMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeals.Dock = DockStyle.Fill;
            dgvMeals.Location = new Point(3, 874);
            dgvMeals.Name = "dgvMeals";
            dgvMeals.RowHeadersWidth = 82;
            dgvMeals.Size = new Size(2415, 865);
            dgvMeals.TabIndex = 2;
            dgvMeals.CellClick += dgvMeals_CellClick;
            // 
            // tableLayoutPanelL3
            // 
            tableLayoutPanelL3.ColumnCount = 4;
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelL3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanelL3.Controls.Add(btnExit, 3, 0);
            tableLayoutPanelL3.Controls.Add(btnMealTypeReport, 2, 0);
            tableLayoutPanelL3.Controls.Add(btnComparisonReport, 1, 0);
            tableLayoutPanelL3.Controls.Add(btnEndofDayReport, 0, 0);
            tableLayoutPanelL3.Dock = DockStyle.Fill;
            tableLayoutPanelL3.Location = new Point(3, 1745);
            tableLayoutPanelL3.Name = "tableLayoutPanelL3";
            tableLayoutPanelL3.RowCount = 1;
            tableLayoutPanelL3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelL3.Size = new Size(2415, 65);
            tableLayoutPanelL3.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(2217, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(195, 59);
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
            btnMealTypeReport.Location = new Point(1479, 3);
            btnMealTypeReport.Name = "btnMealTypeReport";
            btnMealTypeReport.Size = new Size(732, 59);
            btnMealTypeReport.TabIndex = 3;
            btnMealTypeReport.Text = "Yemek Çeşidi Raporunu Görüntüle!";
            btnMealTypeReport.UseVisualStyleBackColor = false;
            // 
            // btnComparisonReport
            // 
            btnComparisonReport.BackColor = Color.IndianRed;
            btnComparisonReport.Dock = DockStyle.Fill;
            btnComparisonReport.FlatAppearance.BorderColor = Color.Black;
            btnComparisonReport.FlatStyle = FlatStyle.Flat;
            btnComparisonReport.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnComparisonReport.ForeColor = Color.Black;
            btnComparisonReport.Location = new Point(741, 3);
            btnComparisonReport.Name = "btnComparisonReport";
            btnComparisonReport.Size = new Size(732, 59);
            btnComparisonReport.TabIndex = 2;
            btnComparisonReport.Text = "Kıyas Raporunu Görüntüle!";
            btnComparisonReport.UseVisualStyleBackColor = false;
            // 
            // btnEndofDayReport
            // 
            btnEndofDayReport.BackColor = Color.IndianRed;
            btnEndofDayReport.Dock = DockStyle.Fill;
            btnEndofDayReport.FlatAppearance.BorderColor = Color.Black;
            btnEndofDayReport.FlatStyle = FlatStyle.Flat;
            btnEndofDayReport.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnEndofDayReport.ForeColor = Color.Black;
            btnEndofDayReport.Location = new Point(3, 3);
            btnEndofDayReport.Name = "btnEndofDayReport";
            btnEndofDayReport.Size = new Size(732, 59);
            btnEndofDayReport.TabIndex = 1;
            btnEndofDayReport.Text = "Gün Sonu Raporunu Görüntüle!";
            btnEndofDayReport.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvFoodEntry, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(2415, 865);
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
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.Size = new Size(2409, 50);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Dock = DockStyle.Fill;
            dateTimePicker.Location = new Point(3, 3);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(1198, 39);
            dateTimePicker.TabIndex = 0;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cmbMealType);
            flowLayoutPanel1.Controls.Add(btnAddFoodEntryMeal);
            flowLayoutPanel1.Location = new Point(1207, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1091, 47);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // cmbMealType
            // 
            cmbMealType.FormattingEnabled = true;
            cmbMealType.Location = new Point(3, 3);
            cmbMealType.Name = "cmbMealType";
            cmbMealType.Size = new Size(360, 40);
            cmbMealType.TabIndex = 5;
            cmbMealType.Text = "Lütfen yemek girişi yapmak istediğiniz öğünü seçiniz.";
            // 
            // btnAddFoodEntryMeal
            // 
            btnAddFoodEntryMeal.Location = new Point(369, 3);
            btnAddFoodEntryMeal.Name = "btnAddFoodEntryMeal";
            btnAddFoodEntryMeal.Size = new Size(150, 44);
            btnAddFoodEntryMeal.TabIndex = 4;
            btnAddFoodEntryMeal.Text = "Ekle";
            btnAddFoodEntryMeal.UseVisualStyleBackColor = true;
            btnAddFoodEntryMeal.Click += btnAddFoodEntryMeal_Click;
            // 
            // dgvFoodEntry
            // 
            dgvFoodEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodEntry.Dock = DockStyle.Fill;
            dgvFoodEntry.Location = new Point(3, 59);
            dgvFoodEntry.Name = "dgvFoodEntry";
            dgvFoodEntry.RowHeadersWidth = 82;
            dgvFoodEntry.Size = new Size(2409, 803);
            dgvFoodEntry.TabIndex = 3;
            dgvFoodEntry.CellClick += dgvFoodEntry_CellClick;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(3054, 1819);
            Controls.Add(tableLayoutPanelBase);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
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
    }
}