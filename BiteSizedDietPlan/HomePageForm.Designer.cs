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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnEndofDayReport = new Button();
            btnComparisonReport = new Button();
            btnMealTypeReport = new Button();
            btnExit = new Button();
            btnAddMeal = new Button();
            btnUpdateMeal = new Button();
            btnDeleteMeal = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtShowDailyTotalCalories = new TextBox();
            cmbChooseDailyCaloryValue = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanelBase = new TableLayoutPanel();
            flpMeals = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanelBase.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel1.Location = new Point(34, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1273, 795);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(btnExit, 3, 0);
            tableLayoutPanel5.Controls.Add(btnMealTypeReport, 2, 0);
            tableLayoutPanel5.Controls.Add(btnComparisonReport, 1, 0);
            tableLayoutPanel5.Controls.Add(btnEndofDayReport, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 717);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1267, 75);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // btnEndofDayReport
            // 
            btnEndofDayReport.BackColor = Color.Transparent;
            btnEndofDayReport.Dock = DockStyle.Fill;
            btnEndofDayReport.FlatAppearance.BorderColor = Color.IndianRed;
            btnEndofDayReport.FlatAppearance.BorderSize = 10;
            btnEndofDayReport.FlatStyle = FlatStyle.Flat;
            btnEndofDayReport.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEndofDayReport.ForeColor = Color.Black;
            btnEndofDayReport.Location = new Point(3, 3);
            btnEndofDayReport.Name = "btnEndofDayReport";
            btnEndofDayReport.Size = new Size(310, 69);
            btnEndofDayReport.TabIndex = 0;
            btnEndofDayReport.Text = "Gün Sonu Raporunu Görüntüle!";
            btnEndofDayReport.UseVisualStyleBackColor = false;
            // 
            // btnComparisonReport
            // 
            btnComparisonReport.BackColor = Color.Transparent;
            btnComparisonReport.Dock = DockStyle.Fill;
            btnComparisonReport.FlatAppearance.BorderColor = Color.IndianRed;
            btnComparisonReport.FlatAppearance.BorderSize = 10;
            btnComparisonReport.FlatStyle = FlatStyle.Flat;
            btnComparisonReport.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComparisonReport.ForeColor = Color.Black;
            btnComparisonReport.Location = new Point(319, 3);
            btnComparisonReport.Name = "btnComparisonReport";
            btnComparisonReport.Size = new Size(310, 69);
            btnComparisonReport.TabIndex = 1;
            btnComparisonReport.Text = "Kıyas Raporunu Görüntüle!";
            btnComparisonReport.UseVisualStyleBackColor = false;
            // 
            // btnMealTypeReport
            // 
            btnMealTypeReport.BackColor = Color.Transparent;
            btnMealTypeReport.Dock = DockStyle.Fill;
            btnMealTypeReport.FlatAppearance.BorderColor = Color.IndianRed;
            btnMealTypeReport.FlatAppearance.BorderSize = 10;
            btnMealTypeReport.FlatStyle = FlatStyle.Flat;
            btnMealTypeReport.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMealTypeReport.ForeColor = Color.Black;
            btnMealTypeReport.Location = new Point(635, 3);
            btnMealTypeReport.Name = "btnMealTypeReport";
            btnMealTypeReport.Size = new Size(310, 69);
            btnMealTypeReport.TabIndex = 2;
            btnMealTypeReport.Text = "Yemek Çeşidi Raporunu Görüntüle!";
            btnMealTypeReport.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatAppearance.BorderColor = Color.IndianRed;
            btnExit.FlatAppearance.BorderSize = 10;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(951, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(313, 69);
            btnExit.TabIndex = 3;
            btnExit.Text = "ÇIKIŞ YAP";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnAddMeal
            // 
            btnAddMeal.BackColor = Color.Transparent;
            btnAddMeal.Dock = DockStyle.Fill;
            btnAddMeal.FlatAppearance.BorderColor = Color.IndianRed;
            btnAddMeal.FlatAppearance.BorderSize = 10;
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMeal.ForeColor = Color.Black;
            btnAddMeal.Location = new Point(3, 3);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(416, 67);
            btnAddMeal.TabIndex = 1;
            btnAddMeal.Text = "ÖĞÜN EKLE";
            btnAddMeal.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMeal
            // 
            btnUpdateMeal.BackColor = Color.Transparent;
            btnUpdateMeal.Dock = DockStyle.Fill;
            btnUpdateMeal.FlatAppearance.BorderColor = Color.IndianRed;
            btnUpdateMeal.FlatAppearance.BorderSize = 10;
            btnUpdateMeal.FlatStyle = FlatStyle.Flat;
            btnUpdateMeal.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateMeal.ForeColor = Color.Black;
            btnUpdateMeal.Location = new Point(425, 3);
            btnUpdateMeal.Name = "btnUpdateMeal";
            btnUpdateMeal.Size = new Size(416, 67);
            btnUpdateMeal.TabIndex = 2;
            btnUpdateMeal.Text = "ÖĞÜN GÜNCELLE";
            btnUpdateMeal.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMeal
            // 
            btnDeleteMeal.BackColor = Color.Transparent;
            btnDeleteMeal.Dock = DockStyle.Fill;
            btnDeleteMeal.FlatAppearance.BorderColor = Color.IndianRed;
            btnDeleteMeal.FlatAppearance.BorderSize = 10;
            btnDeleteMeal.FlatStyle = FlatStyle.Flat;
            btnDeleteMeal.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteMeal.ForeColor = Color.Black;
            btnDeleteMeal.Location = new Point(847, 3);
            btnDeleteMeal.Name = "btnDeleteMeal";
            btnDeleteMeal.Size = new Size(417, 67);
            btnDeleteMeal.TabIndex = 3;
            btnDeleteMeal.Text = "ÖĞÜN SİL";
            btnDeleteMeal.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(btnDeleteMeal, 2, 0);
            tableLayoutPanel4.Controls.Add(btnUpdateMeal, 1, 0);
            tableLayoutPanel4.Controls.Add(btnAddMeal, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 638);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1267, 73);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // txtShowDailyTotalCalories
            // 
            txtShowDailyTotalCalories.Location = new Point(636, 3);
            txtShowDailyTotalCalories.Name = "txtShowDailyTotalCalories";
            txtShowDailyTotalCalories.Size = new Size(507, 39);
            txtShowDailyTotalCalories.TabIndex = 1;
            // 
            // cmbChooseDailyCaloryValue
            // 
            cmbChooseDailyCaloryValue.FormattingEnabled = true;
            cmbChooseDailyCaloryValue.Location = new Point(3, 3);
            cmbChooseDailyCaloryValue.Name = "cmbChooseDailyCaloryValue";
            cmbChooseDailyCaloryValue.Size = new Size(627, 40);
            cmbChooseDailyCaloryValue.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(cmbChooseDailyCaloryValue, 0, 0);
            tableLayoutPanel3.Controls.Add(txtShowDailyTotalCalories, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 559);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1267, 73);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1267, 550);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanelBase
            // 
            tableLayoutPanelBase.BackColor = Color.Transparent;
            tableLayoutPanelBase.ColumnCount = 2;
            tableLayoutPanelBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanelBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelBase.Controls.Add(flpMeals, 1, 0);
            tableLayoutPanelBase.Dock = DockStyle.Fill;
            tableLayoutPanelBase.Location = new Point(0, 0);
            tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            tableLayoutPanelBase.RowCount = 1;
            tableLayoutPanelBase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBase.Size = new Size(3191, 1819);
            tableLayoutPanelBase.TabIndex = 1;
            // 
            // flpMeals
            // 
            flpMeals.Dock = DockStyle.Fill;
            flpMeals.Location = new Point(2555, 3);
            flpMeals.Name = "flpMeals";
            flpMeals.Size = new Size(633, 1813);
            flpMeals.TabIndex = 0;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.soluk2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(3191, 1819);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanelBase);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePageForm";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanelBase.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnExit;
        private Button btnMealTypeReport;
        private Button btnComparisonReport;
        private Button btnEndofDayReport;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cmbChooseDailyCaloryValue;
        private TextBox txtShowDailyTotalCalories;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnDeleteMeal;
        private Button btnUpdateMeal;
        private Button btnAddMeal;
        private TableLayoutPanel tableLayoutPanelBase;
        private FlowLayoutPanel flpMeals;
    }
}