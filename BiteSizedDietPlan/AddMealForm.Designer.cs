namespace BiteSizedDietPlan
{
    partial class AddMealForm
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
            pictureBoxMeal = new PictureBox();
            label1 = new Label();
            txtMealName = new TextBox();
            txtCalorie = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbMealCategory = new ComboBox();
            btnAddMeal = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMeal).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMeal
            // 
            pictureBoxMeal.BackColor = SystemColors.ControlLight;
            pictureBoxMeal.Location = new Point(25, 27);
            pictureBoxMeal.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMeal.Name = "pictureBoxMeal";
            pictureBoxMeal.Size = new Size(383, 300);
            pictureBoxMeal.TabIndex = 0;
            pictureBoxMeal.TabStop = false;
            pictureBoxMeal.Click += pictureBoxMeal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(25, 351);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 1;
            label1.Text = "Yemek Adı:";
            // 
            // txtMealName
            // 
            txtMealName.Font = new Font("Calibri", 12F);
            txtMealName.Location = new Point(175, 348);
            txtMealName.Margin = new Padding(3, 4, 3, 4);
            txtMealName.Name = "txtMealName";
            txtMealName.Size = new Size(233, 27);
            txtMealName.TabIndex = 2;
            // 
            // txtCalorie
            // 
            txtCalorie.Font = new Font("Calibri", 12F);
            txtCalorie.Location = new Point(175, 394);
            txtCalorie.Margin = new Padding(3, 4, 3, 4);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(233, 27);
            txtCalorie.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 394);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 3;
            label2.Text = "Kalori (1porsiyon):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 441);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 5;
            label3.Text = "Yemek Kategorisi:";
            // 
            // cmbMealCategory
            // 
            cmbMealCategory.FormattingEnabled = true;
            cmbMealCategory.Location = new Point(175, 441);
            cmbMealCategory.Margin = new Padding(3, 4, 3, 4);
            cmbMealCategory.Name = "cmbMealCategory";
            cmbMealCategory.Size = new Size(233, 27);
            cmbMealCategory.TabIndex = 6;
            // 
            // btnAddMeal
            // 
            btnAddMeal.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnAddMeal.Location = new Point(25, 494);
            btnAddMeal.Margin = new Padding(3, 4, 3, 4);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(182, 35);
            btnAddMeal.TabIndex = 7;
            btnAddMeal.Text = "EKLE";
            btnAddMeal.UseVisualStyleBackColor = true;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnCancel.Location = new Point(226, 494);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(182, 35);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "ÇIKIŞ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddMealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(434, 557);
            Controls.Add(btnCancel);
            Controls.Add(btnAddMeal);
            Controls.Add(cmbMealCategory);
            Controls.Add(label3);
            Controls.Add(txtCalorie);
            Controls.Add(label2);
            Controls.Add(txtMealName);
            Controls.Add(label1);
            Controls.Add(pictureBoxMeal);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddMealForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMealForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMeal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMeal;
        private Label label1;
        private TextBox txtMealName;
        private TextBox txtCalorie;
        private Label label2;
        private Label label3;
        private ComboBox cmbMealCategory;
        private Button btnAddMeal;
        private Button btnCancel;
    }
}