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
            pictureBoxMeal.BackColor = SystemColors.ActiveBorder;
            pictureBoxMeal.Location = new Point(22, 21);
            pictureBoxMeal.Name = "pictureBoxMeal";
            pictureBoxMeal.Size = new Size(520, 256);
            pictureBoxMeal.TabIndex = 0;
            pictureBoxMeal.TabStop = false;
            pictureBoxMeal.Click += pictureBoxMeal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(22, 315);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 1;
            label1.Text = "Yemek Adı:";
            // 
            // txtMealName
            // 
            txtMealName.Font = new Font("Calibri", 12F);
            txtMealName.Location = new Point(198, 315);
            txtMealName.Name = "txtMealName";
            txtMealName.Size = new Size(100, 27);
            txtMealName.TabIndex = 2;
            // 
            // txtCalorie
            // 
            txtCalorie.Font = new Font("Calibri", 12F);
            txtCalorie.Location = new Point(198, 349);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(100, 27);
            txtCalorie.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(22, 349);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 3;
            label2.Text = "Kalori (1porsiyon):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(22, 382);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 5;
            label3.Text = "Yemek Kategorisi:";
            // 
            // cmbMealCategory
            // 
            cmbMealCategory.FormattingEnabled = true;
            cmbMealCategory.Location = new Point(198, 382);
            cmbMealCategory.Name = "cmbMealCategory";
            cmbMealCategory.Size = new Size(121, 23);
            cmbMealCategory.TabIndex = 6;
            // 
            // btnAddMeal
            // 
            btnAddMeal.Location = new Point(22, 425);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(134, 43);
            btnAddMeal.TabIndex = 7;
            btnAddMeal.Text = "Ekle";
            btnAddMeal.UseVisualStyleBackColor = true;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(22, 496);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 43);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddMealForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 701);
            Controls.Add(btnCancel);
            Controls.Add(btnAddMeal);
            Controls.Add(cmbMealCategory);
            Controls.Add(label3);
            Controls.Add(txtCalorie);
            Controls.Add(label2);
            Controls.Add(txtMealName);
            Controls.Add(label1);
            Controls.Add(pictureBoxMeal);
            Name = "AddMealForm";
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