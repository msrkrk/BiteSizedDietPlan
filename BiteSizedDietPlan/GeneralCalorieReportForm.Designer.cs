﻿namespace BiteSizedDietPlan
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
            ((System.ComponentModel.ISupportInitialize)dgvGeneralCalorieReport).BeginInit();
            SuspendLayout();
            // 
            // dgvGeneralCalorieReport
            // 
            dgvGeneralCalorieReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGeneralCalorieReport.Location = new Point(12, 136);
            dgvGeneralCalorieReport.Name = "dgvGeneralCalorieReport";
            dgvGeneralCalorieReport.Size = new Size(776, 302);
            dgvGeneralCalorieReport.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(110, 25);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(110, 67);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Bitiş Tarihi:";
            // 
            // btnChooseDate
            // 
            btnChooseDate.Location = new Point(110, 107);
            btnChooseDate.Name = "btnChooseDate";
            btnChooseDate.Size = new Size(75, 23);
            btnChooseDate.TabIndex = 5;
            btnChooseDate.Text = "SEÇ";
            btnChooseDate.UseVisualStyleBackColor = true;
            btnChooseDate.Click += btnChooseDate_Click;
            // 
            // GeneralCalorieReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChooseDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dgvGeneralCalorieReport);
            Name = "GeneralCalorieReportForm";
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
    }
}