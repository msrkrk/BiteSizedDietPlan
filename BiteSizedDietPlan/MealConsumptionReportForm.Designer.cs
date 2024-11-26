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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMealConsumptions).BeginInit();
            SuspendLayout();
            // 
            // dgvMealConsumptions
            // 
            dgvMealConsumptions.BackgroundColor = SystemColors.ControlLight;
            dgvMealConsumptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMealConsumptions.Location = new Point(28, 178);
            dgvMealConsumptions.Name = "dgvMealConsumptions";
            dgvMealConsumptions.Size = new Size(708, 294);
            dgvMealConsumptions.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 1;
            label1.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Calibri", 12F);
            dateTimePickerStart.Location = new Point(166, 37);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(236, 27);
            dateTimePickerStart.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Calibri", 12F);
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(166, 84);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(236, 27);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(28, 90);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 3;
            label2.Text = "Bitiş Tarihi:";
            // 
            // btnChoose
            // 
            btnChoose.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChoose.Location = new Point(166, 129);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(82, 28);
            btnChoose.TabIndex = 5;
            btnChoose.Text = "SEÇ";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(670, 12);
            button1.Name = "button1";
            button1.Size = new Size(82, 30);
            button1.TabIndex = 6;
            button1.Text = "ÇIKIŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MealConsumptionReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(764, 497);
            Controls.Add(button1);
            Controls.Add(btnChoose);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(label2);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label1);
            Controls.Add(dgvMealConsumptions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MealConsumptionReportForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button button1;
    }
}