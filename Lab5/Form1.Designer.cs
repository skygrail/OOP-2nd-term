
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.footageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.FlatsGridView = new System.Windows.Forms.DataGridView();
            this.RoomsBar = new System.Windows.Forms.TrackBar();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeSerialize = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.floorBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kitchenBox = new System.Windows.Forms.CheckBox();
            this.bathroomBox = new System.Windows.Forms.CheckBox();
            this.basementBox = new System.Windows.Forms.CheckBox();
            this.balconyBox = new System.Windows.Forms.CheckBox();
            this.materialBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOfConst = new System.Windows.Forms.DateTimePicker();
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоКомнатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годПостройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.городToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByNumOfRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByFootageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.большаяКвартираСОпционнымиКомнатамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.большаяКвартираБезОпционныхКомнатамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маленькаяКвартираБезОпционныхКомнатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SingletonSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.prototypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.HideToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearStripToolButton = new System.Windows.Forms.ToolStripButton();
            this.FindToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SortToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UpArrowToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DownArrowToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.WrenchPictureBox = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.CurrentDateLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LastActionLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.AmountProdLabel = new System.Windows.Forms.Label();
            this.footage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.options = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfConstruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddOns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стандартнаяКвартираСДополнениямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.FlatsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBar)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WrenchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Метраж";
            // 
            // footageBox
            // 
            this.footageBox.Location = new System.Drawing.Point(81, 83);
            this.footageBox.Name = "footageBox";
            this.footageBox.Size = new System.Drawing.Size(100, 22);
            this.footageBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во комнат: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Год строительства";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(12, 621);
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
            this.address,
            this.Price,
            this.AddOns});
            this.FlatsGridView.Location = new System.Drawing.Point(292, 38);
            this.FlatsGridView.Name = "FlatsGridView";
            this.FlatsGridView.ReadOnly = true;
            this.FlatsGridView.RowHeadersWidth = 51;
            this.FlatsGridView.RowTemplate.Height = 24;
            this.FlatsGridView.Size = new System.Drawing.Size(1098, 261);
            this.FlatsGridView.TabIndex = 20;
            // 
            // RoomsBar
            // 
            this.RoomsBar.Location = new System.Drawing.Point(12, 145);
            this.RoomsBar.Maximum = 5;
            this.RoomsBar.Name = "RoomsBar";
            this.RoomsBar.Size = new System.Drawing.Size(227, 56);
            this.RoomsBar.TabIndex = 21;
            this.RoomsBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(741, 568);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(129, 43);
            this.buttonSerialize.TabIndex = 29;
            this.buttonSerialize.Text = "Сохранить";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonDeSerialize
            // 
            this.buttonDeSerialize.Location = new System.Drawing.Point(930, 568);
            this.buttonDeSerialize.Name = "buttonDeSerialize";
            this.buttonDeSerialize.Size = new System.Drawing.Size(129, 43);
            this.buttonDeSerialize.TabIndex = 30;
            this.buttonDeSerialize.Text = "Загрузить из файла";
            this.buttonDeSerialize.UseVisualStyleBackColor = true;
            this.buttonDeSerialize.Click += new System.EventHandler(this.buttonDeSerialize_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1109, 568);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(129, 43);
            this.buttonClear.TabIndex = 31;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Информация о квартире";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(292, 317);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1098, 228);
            this.listBox1.TabIndex = 44;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Этаж";
            // 
            // floorBox
            // 
            this.floorBox.Location = new System.Drawing.Point(94, 282);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(34, 22);
            this.floorBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Материал";
            // 
            // kitchenBox
            // 
            this.kitchenBox.AutoSize = true;
            this.kitchenBox.Location = new System.Drawing.Point(19, 367);
            this.kitchenBox.Name = "kitchenBox";
            this.kitchenBox.Size = new System.Drawing.Size(68, 21);
            this.kitchenBox.TabIndex = 11;
            this.kitchenBox.Text = "Кухня";
            this.kitchenBox.UseVisualStyleBackColor = true;
            // 
            // bathroomBox
            // 
            this.bathroomBox.AutoSize = true;
            this.bathroomBox.Location = new System.Drawing.Point(141, 367);
            this.bathroomBox.Name = "bathroomBox";
            this.bathroomBox.Size = new System.Drawing.Size(79, 21);
            this.bathroomBox.TabIndex = 12;
            this.bathroomBox.Text = "Ванная";
            this.bathroomBox.UseVisualStyleBackColor = true;
            // 
            // basementBox
            // 
            this.basementBox.AutoSize = true;
            this.basementBox.Location = new System.Drawing.Point(19, 399);
            this.basementBox.Name = "basementBox";
            this.basementBox.Size = new System.Drawing.Size(79, 21);
            this.basementBox.TabIndex = 13;
            this.basementBox.Text = "Подвал";
            this.basementBox.UseVisualStyleBackColor = true;
            // 
            // balconyBox
            // 
            this.balconyBox.AutoSize = true;
            this.balconyBox.Location = new System.Drawing.Point(141, 401);
            this.balconyBox.Name = "balconyBox";
            this.balconyBox.Size = new System.Drawing.Size(78, 21);
            this.balconyBox.TabIndex = 14;
            this.balconyBox.Text = "Балкон";
            this.balconyBox.UseVisualStyleBackColor = true;
            // 
            // materialBox
            // 
            this.materialBox.Location = new System.Drawing.Point(95, 312);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(100, 22);
            this.materialBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Опции";
            // 
            // dateOfConst
            // 
            this.dateOfConst.Location = new System.Drawing.Point(12, 245);
            this.dateOfConst.Name = "dateOfConst";
            this.dateOfConst.Size = new System.Drawing.Size(227, 22);
            this.dateOfConst.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Страна";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Город";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Улица";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 583);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Дом";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 582);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Квартира";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(89, 472);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(100, 22);
            this.countryBox.TabIndex = 38;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(89, 507);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 22);
            this.cityBox.TabIndex = 39;
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(89, 541);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(100, 22);
            this.streetBox.TabIndex = 40;
            // 
            // houseBox
            // 
            this.houseBox.Location = new System.Drawing.Point(66, 580);
            this.houseBox.Name = "houseBox";
            this.houseBox.Size = new System.Drawing.Size(30, 22);
            this.houseBox.TabIndex = 41;
            // 
            // flatBox
            // 
            this.flatBox.Location = new System.Drawing.Point(209, 580);
            this.flatBox.Name = "flatBox";
            this.flatBox.Size = new System.Drawing.Size(30, 22);
            this.flatBox.TabIndex = 42;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.строительToolStripMenuItem,
            this.SingletonSettings,
            this.prototypeToolStripMenuItem,
            this.стандартнаяКвартираСДополнениямиToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1446, 30);
            this.menuStrip2.TabIndex = 45;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openMenuToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.saveMenuToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колвоКомнатToolStripMenuItem,
            this.годПостройкиToolStripMenuItem,
            this.городToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // колвоКомнатToolStripMenuItem
            // 
            this.колвоКомнатToolStripMenuItem.Name = "колвоКомнатToolStripMenuItem";
            this.колвоКомнатToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.колвоКомнатToolStripMenuItem.Text = "Кол-во комнат";
            this.колвоКомнатToolStripMenuItem.Click += new System.EventHandler(this.numOfRoomsToolStripMenuItem_Click);
            // 
            // годПостройкиToolStripMenuItem
            // 
            this.годПостройкиToolStripMenuItem.Name = "годПостройкиToolStripMenuItem";
            this.годПостройкиToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.годПостройкиToolStripMenuItem.Text = "Год постройки";
            this.годПостройкиToolStripMenuItem.Click += new System.EventHandler(this.yearOfConstToolStripMenuItem_Click);
            // 
            // городToolStripMenuItem
            // 
            this.городToolStripMenuItem.Name = "городToolStripMenuItem";
            this.городToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.городToolStripMenuItem.Text = "Город";
            this.городToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByNumOfRoomsToolStripMenuItem,
            this.sortByFootageToolStripMenuItem,
            this.sortByCostToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // sortByNumOfRoomsToolStripMenuItem
            // 
            this.sortByNumOfRoomsToolStripMenuItem.Name = "sortByNumOfRoomsToolStripMenuItem";
            this.sortByNumOfRoomsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.sortByNumOfRoomsToolStripMenuItem.Text = "По кол-ву комнат";
            this.sortByNumOfRoomsToolStripMenuItem.Click += new System.EventHandler(this.sortByNumOfRoomsToolStripMenuItem_Click);
            // 
            // sortByFootageToolStripMenuItem
            // 
            this.sortByFootageToolStripMenuItem.Name = "sortByFootageToolStripMenuItem";
            this.sortByFootageToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.sortByFootageToolStripMenuItem.Text = "По площади";
            this.sortByFootageToolStripMenuItem.Click += new System.EventHandler(this.sortByFootageToolStripMenuItem_Click);
            // 
            // sortByCostToolStripMenuItem
            // 
            this.sortByCostToolStripMenuItem.Name = "sortByCostToolStripMenuItem";
            this.sortByCostToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.sortByCostToolStripMenuItem.Text = "По цене";
            this.sortByCostToolStripMenuItem.Click += new System.EventHandler(this.sortByCostToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammToolStripMenuItem_Click);
            // 
            // строительToolStripMenuItem
            // 
            this.строительToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.большаяКвартираСОпционнымиКомнатамиToolStripMenuItem,
            this.большаяКвартираБезОпционныхКомнатамиToolStripMenuItem,
            this.маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem,
            this.маленькаяКвартираБезОпционныхКомнатToolStripMenuItem});
            this.строительToolStripMenuItem.Name = "строительToolStripMenuItem";
            this.строительToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.строительToolStripMenuItem.Text = "Строитель";
            // 
            // большаяКвартираСОпционнымиКомнатамиToolStripMenuItem
            // 
            this.большаяКвартираСОпционнымиКомнатамиToolStripMenuItem.Name = "большаяКвартираСОпционнымиКомнатамиToolStripMenuItem";
            this.большаяКвартираСОпционнымиКомнатамиToolStripMenuItem.Size = new System.Drawing.Size(442, 26);
            this.большаяКвартираСОпционнымиКомнатамиToolStripMenuItem.Text = "Большая квартира с опционными комнатами";
            this.большаяКвартираСОпционнымиКомнатамиToolStripMenuItem.Click += new System.EventHandler(this.BigFlatWithOptions_Click);
            // 
            // большаяКвартираБезОпционныхКомнатамиToolStripMenuItem
            // 
            this.большаяКвартираБезОпционныхКомнатамиToolStripMenuItem.Name = "большаяКвартираБезОпционныхКомнатамиToolStripMenuItem";
            this.большаяКвартираБезОпционныхКомнатамиToolStripMenuItem.Size = new System.Drawing.Size(442, 26);
            this.большаяКвартираБезОпционныхКомнатамиToolStripMenuItem.Text = "Большая квартира без опционных комнат";
            this.большаяКвартираБезОпционныхКомнатамиToolStripMenuItem.Click += new System.EventHandler(this.BigFlatWithoutOptions_Click);
            // 
            // маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem
            // 
            this.маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem.Name = "маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem";
            this.маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem.Size = new System.Drawing.Size(442, 26);
            this.маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem.Text = "Маленькая квартира с опционными комнатами";
            this.маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem.Click += new System.EventHandler(this.SmallFlatWithOptions_Click);
            // 
            // маленькаяКвартираБезОпционныхКомнатToolStripMenuItem
            // 
            this.маленькаяКвартираБезОпционныхКомнатToolStripMenuItem.Name = "маленькаяКвартираБезОпционныхКомнатToolStripMenuItem";
            this.маленькаяКвартираБезОпционныхКомнатToolStripMenuItem.Size = new System.Drawing.Size(442, 26);
            this.маленькаяКвартираБезОпционныхКомнатToolStripMenuItem.Text = "Маленькая квартира без опционных комнат";
            this.маленькаяКвартираБезОпционныхКомнатToolStripMenuItem.Click += new System.EventHandler(this.SmallFlatWithoutOptions_Click);
            // 
            // SingletonSettings
            // 
            this.SingletonSettings.Name = "SingletonSettings";
            this.SingletonSettings.Size = new System.Drawing.Size(89, 26);
            this.SingletonSettings.Text = "Singleton";
            this.SingletonSettings.Click += new System.EventHandler(this.SingletonSettings_Click);
            // 
            // prototypeToolStripMenuItem
            // 
            this.prototypeToolStripMenuItem.Name = "prototypeToolStripMenuItem";
            this.prototypeToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.prototypeToolStripMenuItem.Text = "Prototype";
            this.prototypeToolStripMenuItem.Click += new System.EventHandler(this.DeepCopyButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HideToolStripButton,
            this.toolStripSeparator1,
            this.ClearStripToolButton,
            this.FindToolStripButton,
            this.SortToolStripButton,
            this.UpArrowToolStripButton,
            this.DownArrowToolStripButton,
            this.DeleteToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(1406, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(40, 656);
            this.toolStrip.TabIndex = 46;
            this.toolStrip.Text = "toolStrip";
            this.toolStrip.Visible = false;
            // 
            // HideToolStripButton
            // 
            this.HideToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HideToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HideToolStripButton.Image")));
            this.HideToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HideToolStripButton.Name = "HideToolStripButton";
            this.HideToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.HideToolStripButton.Text = "toolStripDropDownButton1";
            this.HideToolStripButton.ToolTipText = "Скрыть";
            this.HideToolStripButton.Click += new System.EventHandler(this.HideToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(32, 6);
            // 
            // ClearStripToolButton
            // 
            this.ClearStripToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearStripToolButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearStripToolButton.Image")));
            this.ClearStripToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearStripToolButton.Name = "ClearStripToolButton";
            this.ClearStripToolButton.Size = new System.Drawing.Size(32, 24);
            this.ClearStripToolButton.Text = "ClearStripToolButton";
            this.ClearStripToolButton.ToolTipText = "Очистить";
            this.ClearStripToolButton.Click += new System.EventHandler(this.ClearStripToolButton_Click);
            // 
            // FindToolStripButton
            // 
            this.FindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FindToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FindToolStripButton.Image")));
            this.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindToolStripButton.Name = "FindToolStripButton";
            this.FindToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.FindToolStripButton.Text = "FindToolStripButton";
            this.FindToolStripButton.ToolTipText = "Поиск по кол-ву комнат";
            this.FindToolStripButton.Click += new System.EventHandler(this.FindToolStripButton_Click);
            // 
            // SortToolStripButton
            // 
            this.SortToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SortToolStripButton.Image")));
            this.SortToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortToolStripButton.Name = "SortToolStripButton";
            this.SortToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.SortToolStripButton.Text = "SortToolStripButton";
            this.SortToolStripButton.ToolTipText = "Сортировка по метражу";
            this.SortToolStripButton.Click += new System.EventHandler(this.SortToolStripButton_Click);
            // 
            // UpArrowToolStripButton
            // 
            this.UpArrowToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpArrowToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UpArrowToolStripButton.Image")));
            this.UpArrowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpArrowToolStripButton.Name = "UpArrowToolStripButton";
            this.UpArrowToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.UpArrowToolStripButton.Text = "UpArrowToolStripButton";
            this.UpArrowToolStripButton.ToolTipText = "Выбрать верхний элемент";
            this.UpArrowToolStripButton.Click += new System.EventHandler(this.UpArrowToolStripButton_Click);
            // 
            // DownArrowToolStripButton
            // 
            this.DownArrowToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DownArrowToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DownArrowToolStripButton.Image")));
            this.DownArrowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownArrowToolStripButton.Name = "DownArrowToolStripButton";
            this.DownArrowToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.DownArrowToolStripButton.Text = "DownArrowToolStripButton";
            this.DownArrowToolStripButton.ToolTipText = "Выбрать нижний элемент";
            this.DownArrowToolStripButton.Click += new System.EventHandler(this.DownArrowToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.DeleteToolStripButton.Text = "DeleteToolStripButton";
            this.DeleteToolStripButton.ToolTipText = "Удалить выбранный элемент";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // WrenchPictureBox
            // 
            this.WrenchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WrenchPictureBox.Image")));
            this.WrenchPictureBox.InitialImage = null;
            this.WrenchPictureBox.Location = new System.Drawing.Point(1409, 29);
            this.WrenchPictureBox.Name = "WrenchPictureBox";
            this.WrenchPictureBox.Size = new System.Drawing.Size(32, 32);
            this.WrenchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WrenchPictureBox.TabIndex = 47;
            this.WrenchPictureBox.TabStop = false;
            this.WrenchPictureBox.Click += new System.EventHandler(this.WrenchPictureBox_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 571);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "Дата и время:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CurrentDateLabel
            // 
            this.CurrentDateLabel.AutoSize = true;
            this.CurrentDateLabel.Location = new System.Drawing.Point(401, 573);
            this.CurrentDateLabel.Name = "CurrentDateLabel";
            this.CurrentDateLabel.Size = new System.Drawing.Size(0, 17);
            this.CurrentDateLabel.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 653);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 17);
            this.label15.TabIndex = 50;
            this.label15.Text = "Последнее действие:";
            // 
            // LastActionLabel
            // 
            this.LastActionLabel.AutoSize = true;
            this.LastActionLabel.Location = new System.Drawing.Point(449, 656);
            this.LastActionLabel.Name = "LastActionLabel";
            this.LastActionLabel.Size = new System.Drawing.Size(13, 17);
            this.LastActionLabel.TabIndex = 51;
            this.LastActionLabel.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(292, 612);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 17);
            this.label16.TabIndex = 52;
            this.label16.Text = "Количество квартир:";
            // 
            // AmountProdLabel
            // 
            this.AmountProdLabel.AutoSize = true;
            this.AmountProdLabel.Location = new System.Drawing.Point(446, 612);
            this.AmountProdLabel.Name = "AmountProdLabel";
            this.AmountProdLabel.Size = new System.Drawing.Size(12, 17);
            this.AmountProdLabel.TabIndex = 53;
            this.AmountProdLabel.Text = " ";
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
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // AddOns
            // 
            this.AddOns.HeaderText = "Дополнения (Декоратор)";
            this.AddOns.MinimumWidth = 6;
            this.AddOns.Name = "AddOns";
            this.AddOns.ReadOnly = true;
            this.AddOns.Width = 125;
            // 
            // стандартнаяКвартираСДополнениямиToolStripMenuItem
            // 
            this.стандартнаяКвартираСДополнениямиToolStripMenuItem.Name = "стандартнаяКвартираСДополнениямиToolStripMenuItem";
            this.стандартнаяКвартираСДополнениямиToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.стандартнаяКвартираСДополнениямиToolStripMenuItem.Text = "Стандартная квартира с дополнениями";
            this.стандартнаяКвартираСДополнениямиToolStripMenuItem.Click += new System.EventHandler(this.AddOnsForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 684);
            this.Controls.Add(this.AmountProdLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.LastActionLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CurrentDateLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.WrenchPictureBox);
            this.Controls.Add(this.toolStrip);
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
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Квартиры";
            ((System.ComponentModel.ISupportInitialize)(this.FlatsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBar)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WrenchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox footageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EnterButton;
        public System.Windows.Forms.DataGridView FlatsGridView;
        private System.Windows.Forms.TrackBar RoomsBar;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonDeSerialize;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox floorBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox kitchenBox;
        private System.Windows.Forms.CheckBox bathroomBox;
        private System.Windows.Forms.CheckBox basementBox;
        private System.Windows.Forms.CheckBox balconyBox;
        private System.Windows.Forms.TextBox materialBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateOfConst;
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
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоКомнатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годПостройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem городToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByNumOfRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByFootageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton HideToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ClearStripToolButton;
        private System.Windows.Forms.ToolStripButton FindToolStripButton;
        private System.Windows.Forms.ToolStripButton SortToolStripButton;
        private System.Windows.Forms.ToolStripButton UpArrowToolStripButton;
        private System.Windows.Forms.ToolStripButton DownArrowToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.PictureBox WrenchPictureBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label CurrentDateLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LastActionLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label AmountProdLabel;
        private System.Windows.Forms.ToolStripMenuItem строительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SingletonSettings;
        private System.Windows.Forms.ToolStripMenuItem большаяКвартираСОпционнымиКомнатамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem большаяКвартираБезОпционныхКомнатамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маленькаяКвартираСОпционнымиКомнатамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маленькаяКвартираБезОпционныхКомнатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prototypeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn footage;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn options;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfConstruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddOns;
        private System.Windows.Forms.ToolStripMenuItem стандартнаяКвартираСДополнениямиToolStripMenuItem;
    }
}

