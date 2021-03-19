
namespace Lab2
{
    partial class SingletonForm
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
            this.BackGroundColorButton = new System.Windows.Forms.Button();
            this.FontLabel = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.BackgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackGroundColorButton
            // 
            this.BackGroundColorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BackGroundColorButton.Location = new System.Drawing.Point(23, 23);
            this.BackGroundColorButton.Name = "BackGroundColorButton";
            this.BackGroundColorButton.Size = new System.Drawing.Size(102, 38);
            this.BackGroundColorButton.TabIndex = 0;
            this.BackGroundColorButton.Text = "Цвет фона";
            this.BackGroundColorButton.UseVisualStyleBackColor = true;
            this.BackGroundColorButton.Click += new System.EventHandler(this.BackGroundColorButton_Click);
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontLabel.Location = new System.Drawing.Point(30, 87);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(65, 20);
            this.FontLabel.TabIndex = 1;
            this.FontLabel.Text = "Шрифт:";
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontSizeLabel.Location = new System.Drawing.Point(30, 134);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(128, 20);
            this.FontSizeLabel.TabIndex = 2;
            this.FontSizeLabel.Text = "Размер шрифта:";
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Location = new System.Drawing.Point(141, 35);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(0, 17);
            this.BackgroundColorLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(101, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segoe UI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(157, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "16";
            // 
            // SingletonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackgroundColorLabel);
            this.Controls.Add(this.FontSizeLabel);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.BackGroundColorButton);
            this.Name = "SingletonForm";
            this.Text = "Singleton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label FontLabel;
        public System.Windows.Forms.Label FontSizeLabel;
        public System.Windows.Forms.Label BackgroundColorLabel;
        private System.Windows.Forms.ColorDialog BackgroundColorDialog;
        private System.Windows.Forms.Button BackGroundColorButton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}