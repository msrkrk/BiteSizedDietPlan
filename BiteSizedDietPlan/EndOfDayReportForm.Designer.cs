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
            SuspendLayout();
            // 
            // lstvFoodEntries
            // 
            lstvFoodEntries.Location = new Point(25, 142);
            lstvFoodEntries.Name = "lstvFoodEntries";
            lstvFoodEntries.Size = new Size(674, 248);
            lstvFoodEntries.TabIndex = 0;
            lstvFoodEntries.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(25, 32);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 103);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 2;
            label1.Text = "Toplam Kalori:";
            // 
            // txtTotalCalorie
            // 
            txtTotalCalorie.Location = new Point(135, 100);
            txtTotalCalorie.Name = "txtTotalCalorie";
            txtTotalCalorie.ReadOnly = true;
            txtTotalCalorie.Size = new Size(100, 23);
            txtTotalCalorie.TabIndex = 3;
            // 
            // EndOfDayReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotalCalorie);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(lstvFoodEntries);
            Name = "EndOfDayReport";
            Text = "EndOfDayReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvFoodEntries;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private TextBox txtTotalCalorie;
    }
}