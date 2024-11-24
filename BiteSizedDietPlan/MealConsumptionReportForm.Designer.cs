namespace BiteSizedDietPlan
{
    partial class MealConsumptionReportForm
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
            dgvMealConsumptions = new DataGridView();
            label1 = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label2 = new Label();
            btnChoose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMealConsumptions).BeginInit();
            SuspendLayout();
            // 
            // dgvMealConsumptions
            // 
            dgvMealConsumptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMealConsumptions.Location = new Point(37, 149);
            dgvMealConsumptions.Name = "dgvMealConsumptions";
            dgvMealConsumptions.Size = new Size(632, 277);
            dgvMealConsumptions.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(120, 34);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(120, 81);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Bitiş Tarihi:";
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(120, 120);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(75, 23);
            btnChoose.TabIndex = 5;
            btnChoose.Text = "SEÇ";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // MealConsumptionReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChoose);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(label2);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label1);
            Controls.Add(dgvMealConsumptions);
            Name = "MealConsumptionReportForm";
            Text = "MealConsumptionReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvMealConsumptions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMealConsumptions;
        private Label label1;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label2;
        private Button btnChoose;
    }
}