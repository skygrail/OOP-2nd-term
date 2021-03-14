
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.footageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.floorBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kitchenBox = new System.Windows.Forms.CheckBox();
            this.bathroomBox = new System.Windows.Forms.CheckBox();
            this.basementBox = new System.Windows.Forms.CheckBox();
            this.balconyBox = new System.Windows.Forms.CheckBox();
            this.materialBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.FlatsGridView = new System.Windows.Forms.DataGridView();
            this.RoomsBar = new System.Windows.Forms.TrackBar();
            this.dateOfConst = new System.Windows.Forms.DateTimePicker();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeSerialize = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.houseBox = new System.Windows.Forms.TextBox();
            this.flatBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.footage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.options = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfConstruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FlatsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Метраж";
            // 
            // footageBox
            // 
            this.footageBox.Location = new System.Drawing.Point(81, 57);
            this.footageBox.Name = "footageBox";
            this.footageBox.Size = new System.Drawing.Size(100, 22);
            this.footageBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во комнат: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Год строительства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Этаж";
            // 
            // floorBox
            // 
            this.floorBox.Location = new System.Drawing.Point(94, 239);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(34, 22);
            this.floorBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Материал";
            // 
            // kitchenBox
            // 
            this.kitchenBox.AutoSize = true;
            this.kitchenBox.Location = new System.Drawing.Point(19, 324);
            this.kitchenBox.Name = "kitchenBox";
            this.kitchenBox.Size = new System.Drawing.Size(68, 21);
            this.kitchenBox.TabIndex = 11;
            this.kitchenBox.Text = "Кухня";
            this.kitchenBox.UseVisualStyleBackColor = true;
            // 
            // bathroomBox
            // 
            this.bathroomBox.AutoSize = true;
            this.bathroomBox.Location = new System.Drawing.Point(141, 324);
            this.bathroomBox.Name = "bathroomBox";
            this.bathroomBox.Size = new System.Drawing.Size(79, 21);
            this.bathroomBox.TabIndex = 12;
            this.bathroomBox.Text = "Ванная";
            this.bathroomBox.UseVisualStyleBackColor = true;
            // 
            // basementBox
            // 
            this.basementBox.AutoSize = true;
            this.basementBox.Location = new System.Drawing.Point(19, 356);
            this.basementBox.Name = "basementBox";
            this.basementBox.Size = new System.Drawing.Size(79, 21);
            this.basementBox.TabIndex = 13;
            this.basementBox.Text = "Подвал";
            this.basementBox.UseVisualStyleBackColor = true;
            // 
            // balconyBox
            // 
            this.balconyBox.AutoSize = true;
            this.balconyBox.Location = new System.Drawing.Point(141, 358);
            this.balconyBox.Name = "balconyBox";
            this.balconyBox.Size = new System.Drawing.Size(78, 21);
            this.balconyBox.TabIndex = 14;
            this.balconyBox.Text = "Балкон";
            this.balconyBox.UseVisualStyleBackColor = true;
            // 
            // materialBox
            // 
            this.materialBox.Location = new System.Drawing.Point(95, 269);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(100, 22);
            this.materialBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Опции";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(12, 564);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(227, 29);
            this.EnterButton.TabIndex = 18;
            this.EnterButton.Text = "Ввод";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // FlatsGridView
            // 
            this.FlatsGridView.AllowUserToAddRows = false;
            this.FlatsGridView.AllowUserToDeleteRows = false;
            this.FlatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlatsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.footage,
            this.numOfRooms,
            this.options,
            this.yearOfConstruction,
            this.material,
            this.floor,
            this.address});
            this.FlatsGridView.Location = new System.Drawing.Point(292, 12);
            this.FlatsGridView.Name = "FlatsGridView";
            this.FlatsGridView.ReadOnly = true;
            this.FlatsGridView.RowHeadersWidth = 51;
            this.FlatsGridView.RowTemplate.Height = 24;
            this.FlatsGridView.Size = new System.Drawing.Size(983, 261);
            this.FlatsGridView.TabIndex = 20;
            // 
            // RoomsBar
            // 
            this.RoomsBar.Location = new System.Drawing.Point(12, 119);
            this.RoomsBar.Maximum = 5;
            this.RoomsBar.Name = "RoomsBar";
            this.RoomsBar.Size = new System.Drawing.Size(227, 56);
            this.RoomsBar.TabIndex = 21;
            this.RoomsBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // dateOfConst
            // 
            this.dateOfConst.Location = new System.Drawing.Point(12, 202);
            this.dateOfConst.Name = "dateOfConst";
            this.dateOfConst.Size = new System.Drawing.Size(227, 22);
            this.dateOfConst.TabIndex = 22;
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(618, 550);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(129, 43);
            this.buttonSerialize.TabIndex = 29;
            this.buttonSerialize.Text = "Сохранить";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonDeSerialize
            // 
            this.buttonDeSerialize.Location = new System.Drawing.Point(792, 550);
            this.buttonDeSerialize.Name = "buttonDeSerialize";
            this.buttonDeSerialize.Size = new System.Drawing.Size(129, 43);
            this.buttonDeSerialize.TabIndex = 30;
            this.buttonDeSerialize.Text = "Загрузить из файла";
            this.buttonDeSerialize.UseVisualStyleBackColor = true;
            this.buttonDeSerialize.Click += new System.EventHandler(this.buttonDeSerialize_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(953, 550);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(129, 43);
            this.buttonClear.TabIndex = 31;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Страна";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Город";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Улица";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Дом";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 525);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Квартира";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(89, 415);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(100, 22);
            this.countryBox.TabIndex = 38;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(89, 450);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 22);
            this.cityBox.TabIndex = 39;
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(89, 484);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(100, 22);
            this.streetBox.TabIndex = 40;
            // 
            // houseBox
            // 
            this.houseBox.Location = new System.Drawing.Point(66, 523);
            this.houseBox.Name = "houseBox";
            this.houseBox.Size = new System.Drawing.Size(30, 22);
            this.houseBox.TabIndex = 41;
            // 
            // flatBox
            // 
            this.flatBox.Location = new System.Drawing.Point(209, 523);
            this.flatBox.Name = "flatBox";
            this.flatBox.Size = new System.Drawing.Size(30, 22);
            this.flatBox.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Информация о квартире";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(292, 299);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(983, 228);
            this.listBox1.TabIndex = 44;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // footage
            // 
            this.footage.HeaderText = "Метраж";
            this.footage.MinimumWidth = 6;
            this.footage.Name = "footage";
            this.footage.ReadOnly = true;
            this.footage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.footage.Width = 125;
            // 
            // numOfRooms
            // 
            this.numOfRooms.HeaderText = "Кол-во комнат";
            this.numOfRooms.MinimumWidth = 6;
            this.numOfRooms.Name = "numOfRooms";
            this.numOfRooms.ReadOnly = true;
            this.numOfRooms.Width = 90;
            // 
            // options
            // 
            this.options.HeaderText = "Опции (комнаты)";
            this.options.MinimumWidth = 6;
            this.options.Name = "options";
            this.options.ReadOnly = true;
            this.options.Width = 150;
            // 
            // yearOfConstruction
            // 
            this.yearOfConstruction.HeaderText = "Год постройки";
            this.yearOfConstruction.MinimumWidth = 6;
            this.yearOfConstruction.Name = "yearOfConstruction";
            this.yearOfConstruction.ReadOnly = true;
            this.yearOfConstruction.Width = 150;
            // 
            // material
            // 
            this.material.HeaderText = "Тип материала";
            this.material.MinimumWidth = 6;
            this.material.Name = "material";
            this.material.ReadOnly = true;
            this.material.Width = 125;
            // 
            // floor
            // 
            this.floor.HeaderText = "Этаж";
            this.floor.MinimumWidth = 6;
            this.floor.Name = "floor";
            this.floor.ReadOnly = true;
            this.floor.Width = 85;
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 190;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.flatBox);
            this.Controls.Add(this.houseBox);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDeSerialize);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.dateOfConst);
            this.Controls.Add(this.RoomsBar);
            this.Controls.Add(this.FlatsGridView);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.balconyBox);
            this.Controls.Add(this.basementBox);
            this.Controls.Add(this.bathroomBox);
            this.Controls.Add(this.kitchenBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.floorBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.footageBox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Квартиры";
            ((System.ComponentModel.ISupportInitialize)(this.FlatsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox footageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox floorBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox kitchenBox;
        private System.Windows.Forms.CheckBox bathroomBox;
        private System.Windows.Forms.CheckBox basementBox;
        private System.Windows.Forms.CheckBox balconyBox;
        private System.Windows.Forms.TextBox materialBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.DataGridView FlatsGridView;
        private System.Windows.Forms.TrackBar RoomsBar;
        private System.Windows.Forms.DateTimePicker dateOfConst;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonDeSerialize;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox houseBox;
        private System.Windows.Forms.TextBox flatBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.DataGridViewTextBoxColumn footage;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn options;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfConstruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}

