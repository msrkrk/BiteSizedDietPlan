namespace BiteSizedDietPlan
{
    partial class EndOfDayReportForm
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
            lstvFoodEntries = new ListView();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            txtTotalCalorie = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstvFoodEntries
            // 
            lstvFoodEntries.BackColor = SystemColors.ControlLight;
            lstvFoodEntries.Location = new Point(29, 117);
            lstvFoodEntries.Margin = new Padding(3, 4, 3, 4);
            lstvFoodEntries.Name = "lstvFoodEntries";
            lstvFoodEntries.Size = new Size(843, 313);
            lstvFoodEntries.TabIndex = 0;
            lstvFoodEntries.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(29, 28);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(256, 27);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 77);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 2;
            label1.Text = "Toplam Kalori:";
            // 
            // txtTotalCalorie
            // 
            txtTotalCalorie.Location = new Point(142, 69);
            txtTotalCalorie.Margin = new Padding(3, 4, 3, 4);
            txtTotalCalorie.Name = "txtTotalCalorie";
            txtTotalCalorie.ReadOnly = true;
            txtTotalCalorie.Size = new Size(143, 27);
            txtTotalCalorie.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(815, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 30);
            btnExit.TabIndex = 4;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // EndOfDayReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(902, 459);
            Controls.Add(btnExit);
            Controls.Add(txtTotalCalorie);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(lstvFoodEntries);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EndOfDayReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EndOfDayReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvFoodEntries;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private TextBox txtTotalCalorie;
        private Button btnExit;
    }
}