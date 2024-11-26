namespace BiteSizedDietPlan
{
    partial class GeneralCalorieReportForm
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
            dgvGeneralCalorieReport = new DataGridView();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnChooseDate = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGeneralCalorieReport).BeginInit();
            SuspendLayout();
            // 
            // dgvGeneralCalorieReport
            // 
            dgvGeneralCalorieReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGeneralCalorieReport.BackgroundColor = SystemColors.ControlLight;
            dgvGeneralCalorieReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGeneralCalorieReport.Location = new Point(24, 172);
            dgvGeneralCalorieReport.Name = "dgvGeneralCalorieReport";
            dgvGeneralCalorieReport.Size = new Size(776, 311);
            dgvGeneralCalorieReport.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Calibri", 12F);
            dateTimePickerStart.Location = new Point(164, 25);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(255, 27);
            dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Calibri", 12F);
            dateTimePickerEnd.Location = new Point(164, 72);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(255, 27);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 3;
            label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 4;
            label2.Text = "Bitiş Tarihi:";
            // 
            // btnChooseDate
            // 
            btnChooseDate.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnChooseDate.Location = new Point(164, 118);
            btnChooseDate.Name = "btnChooseDate";
            btnChooseDate.Size = new Size(83, 32);
            btnChooseDate.TabIndex = 5;
            btnChooseDate.Text = "SEÇ";
            btnChooseDate.UseVisualStyleBackColor = true;
            btnChooseDate.Click += btnChooseDate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnExit.Location = new Point(738, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 28);
            btnExit.TabIndex = 6;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // GeneralCalorieReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(826, 505);
            Controls.Add(btnExit);
            Controls.Add(btnChooseDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dgvGeneralCalorieReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GeneralCalorieReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeneralCalorieReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvGeneralCalorieReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGeneralCalorieReport;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label1;
        private Label label2;
        private Button btnChooseDate;
        private Button btnExit;
    }
}