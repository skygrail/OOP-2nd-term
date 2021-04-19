
namespace Lab2
{
    partial class AddOnsForApartmentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RenovationCheckBox = new System.Windows.Forms.CheckBox();
            this.FurnitureCheckBox = new System.Windows.Forms.CheckBox();
            this.AlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дополнения для квартиры";
            // 
            // RenovationCheckBox
            // 
            this.RenovationCheckBox.AutoSize = true;
            this.RenovationCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RenovationCheckBox.Location = new System.Drawing.Point(42, 47);
            this.RenovationCheckBox.Name = "RenovationCheckBox";
            this.RenovationCheckBox.Size = new System.Drawing.Size(82, 24);
            this.RenovationCheckBox.TabIndex = 1;
            this.RenovationCheckBox.Text = "Ремонт";
            this.RenovationCheckBox.UseVisualStyleBackColor = true;
            // 
            // FurnitureCheckBox
            // 
            this.FurnitureCheckBox.AutoSize = true;
            this.FurnitureCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FurnitureCheckBox.Location = new System.Drawing.Point(42, 77);
            this.FurnitureCheckBox.Name = "FurnitureCheckBox";
            this.FurnitureCheckBox.Size = new System.Drawing.Size(86, 24);
            this.FurnitureCheckBox.TabIndex = 2;
            this.FurnitureCheckBox.Text = "Мебель";
            this.FurnitureCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlarmCheckBox
            // 
            this.AlarmCheckBox.AutoSize = true;
            this.AlarmCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AlarmCheckBox.Location = new System.Drawing.Point(42, 107);
            this.AlarmCheckBox.Name = "AlarmCheckBox";
            this.AlarmCheckBox.Size = new System.Drawing.Size(130, 24);
            this.AlarmCheckBox.TabIndex = 3;
            this.AlarmCheckBox.Text = "Сигнализация";
            this.AlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(121, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddFlatWithAddOnsButton_Click);
            // 
            // AddOnsForApartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlarmCheckBox);
            this.Controls.Add(this.FurnitureCheckBox);
            this.Controls.Add(this.RenovationCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "AddOnsForApartmentsForm";
            this.Text = "AddOnsForApartments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RenovationCheckBox;
        private System.Windows.Forms.CheckBox FurnitureCheckBox;
        private System.Windows.Forms.CheckBox AlarmCheckBox;
        private System.Windows.Forms.Button button1;
    }
}