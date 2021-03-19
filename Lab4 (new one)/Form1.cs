using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;


namespace Lab2
{
    public partial class Form1 : Form
    {

        List<Flat> list = new List<Flat>();
        private TextBox txtBox = new TextBox();

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(txtBox);
            this.Controls.Remove(txtBox);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = String.Format("Кол-во комнат:    {0}", RoomsBar.Value);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //кнопка "Ввод" информацию о квартире EnterButton_Click
            
                ErrorProvider er = new ErrorProvider();
                if (footageBox.Text.Length == 0)
                {
                    er.SetError(footageBox, "Поле не должно быть пустым");
                    return;
                }
                try
                {
                    Convert.ToInt32(footageBox.Text);
                }
                catch
                {
                    er.SetError(footageBox, "Неверное вводимое значение!");
                }
                if (RoomsBar.Value == 0)
                {
                    er.SetError(RoomsBar, "Количество комнат должно быть больше нуля");
                    return;
                }
                if (floorBox.Text.Length == 0)
                {
                    er.SetError(floorBox, "Значение этажа должно быть больше нуля");
                    return;
                }
                try
                {
                    Convert.ToInt32(floorBox.Text);
                }
                catch
                {
                    er.SetError(floorBox, "Неверное вводимое значение!");
                }
                if (materialBox.Text.Length == 0)
                {
                    er.SetError(materialBox, "Поле не должно быть пустым");
                    return;
                }
                if (countryBox.Text.Length == 0)
                {
                    er.SetError(countryBox, "Поле не должно быть пустым");
                    return;
                }
                if (cityBox.Text.Length == 0)
                {
                    er.SetError(cityBox, "Поле не должно быть пустым");
                    return;
                }
                if (streetBox.Text.Length == 0)
                {
                    er.SetError(streetBox, "Поле не должно быть пустым");
                    return;
                }
                if (houseBox.Text.Length == 0)
                {
                    er.SetError(houseBox, "Поле не должно быть пустым");
                    return;
                }
                try
                {
                    Convert.ToInt32(houseBox.Text);
                }
                catch
                {
                    er.SetError(houseBox, "Неверное вводимое значение!");
                }
                if (flatBox.Text.Length == 0)
                {
                    er.SetError(flatBox, "Поле не должно быть пустым");
                    return;
                }
                try
                {
                    Convert.ToInt32(flatBox.Text);
                }
                catch
                {
                    er.SetError(flatBox, "Неверное вводимое значение!");
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////////////

                Address addres = new Address(countryBox.Text, cityBox.Text, streetBox.Text,
                    int.Parse(houseBox.Text), int.Parse(flatBox.Text));

                string optionalRooms = "", addressToStr = " ";

                addressToStr = addres.country + ", " + addres.city + ", " + addres.street + " " + addres.house + "/" + addres.flat;

                string kith = "-", bath = "-", basem = "-", balc = "-";
                if (kitchenBox.Checked)
                {
                    kith = "Кухня";
                    optionalRooms += kith + "; ";
                }
                if (bathroomBox.Checked)
                {
                    bath = "Ванная";
                    optionalRooms += bath + "; ";
                }
                if (basementBox.Checked)
                {
                    basem = "Подвал";
                    optionalRooms += basem + "; ";
                }
                if (balconyBox.Checked)
                {
                    balc = "Балкон";
                    optionalRooms += balc + "; ";
                }

            int createPrice = Convert.ToInt32(footageBox.Text) * Convert.ToInt32(RoomsBar.Value);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            Flat flat = new Flat(Convert.ToInt32(footageBox.Text), Convert.ToInt32(RoomsBar.Value), 
                    dateOfConst.Text, Convert.ToInt32(floorBox.Text), createPrice, kith, bath, basem, 
                    balc, materialBox.Text, addres);

                list.Add(flat);

                var results = new List<ValidationResult>();
                var context = new ValidationContext(flat);
                if (!Validator.TryValidateObject(flat, context, results, true))
                {
                    string errors = "";
                    foreach (var el in results)
                    {
                        errors += el.ErrorMessage + '\n';
                    }

                    MessageBox.Show(errors, "Ошибка");
                    return;
                }

                //listBox1.Items.Add(flat);

                FlatsGridView.Rows.Add(footageBox.Text, RoomsBar.Value, optionalRooms, dateOfConst.Text, materialBox.Text,
                    floorBox.Text, addressToStr, createPrice);
                ClearFields();
            AmountProdLabel.Text = list.Count().ToString();
            LastActionLabel.Text = "Добавлена квартира";
        }

        private void ClearFields()
        {
            footageBox.Text = "";
            RoomsBar.Value = 0;
            floorBox.Text = "";
            materialBox.Text = "";
            kitchenBox.Checked = false;
            bathroomBox.Checked = false;
            basementBox.Checked = false;
            balconyBox.Checked = false;
            countryBox.Text = "";
            cityBox.Text = "";
            streetBox.Text = "";
            houseBox.Text = "";
            flatBox.Text = "";
            label3.Text = String.Format("Кол-во комнат:    {0}", RoomsBar.Value);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog2.FileName = "Serialize_xml.xml";
                saveFileDialog2.ShowDialog();
                using (FileStream fs = new FileStream(saveFileDialog2.FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Flat>));
                    xmlSerializer.Serialize(fs, list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeSerialize_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "Serialize_xml.xml";
            openFileDialog2.ShowDialog();

            List<Flat> _flat;
            try
            {
                using (FileStream fst = new FileStream(openFileDialog2.FileName, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Flat>));
                    _flat = (List<Flat>)xmlSerializer.Deserialize(fst);
                }
                if (_flat.Count != 0)
                    foreach (Flat fl in _flat)
                    {
                        list.Add(fl);
                        listBox1.Items.Add(fl);

                        string optionalRooms = "", addressToStr = "";

                        addressToStr = fl.address.country + ", " + fl.address.city + ", " + fl.address.street + " " + fl.address.house + "/" + fl.address.flat;

                        if (fl.kitchen == "Кухня")
                        {
                            optionalRooms += fl.kitchen + "; ";
                        }
                        if (fl.bathroom == "Ванная")
                        {
                            optionalRooms += fl.bathroom + "; ";
                        }
                        if (fl.basement == "Подвал")
                        {
                            optionalRooms += fl.basement + "; ";
                        }
                        if (fl.balcony == "Балкон")
                        {
                            optionalRooms += fl.balcony + "; ";
                        }

                        int createPrice = fl.footage * fl.numOfRooms;

                        FlatsGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                    fl.floor, addressToStr, createPrice);
                    }

                AmountProdLabel.Text = list.Count().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void WrenchPictureBox_Click(object sender, EventArgs e)
        {
            toolStrip.Show();
            WrenchPictureBox.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CurrentDateLabel.Text = DateTime.Now.ToString();
        }

        private void Ff_Closed(object sender, EventArgs e)
        {
            LastActionLabel.Text = "Найдена определённая квартира";
        }

        private void numOfRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm ff = new FindForm(FindType._NumOfRooms, list);
            ff.Show();
            ff.Closed += Ff_Closed;
        }

        private void yearOfConstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm ff = new FindForm(FindType._Year, list);
            ff.Show();
            ff.Closed += Ff_Closed;
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm ff = new FindForm(FindType._City, list);
            ff.Show();
            ff.Closed += Ff_Closed;
        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void saveMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog2.FileName = "Serialize_xml.xml";
                saveFileDialog2.ShowDialog();
                using (FileStream fs = new FileStream(saveFileDialog2.FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Flat>));
                    xmlSerializer.Serialize(fs, list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog2.FileName = "Serialize_xml.xml";
            openFileDialog2.ShowDialog();

            List<Flat> _flat;
            try
            {
                using (FileStream fst = new FileStream(openFileDialog2.FileName, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Flat>));
                    _flat = (List<Flat>)xmlSerializer.Deserialize(fst);
                }
                if (_flat.Count != 0)
                    foreach (Flat fl in _flat)
                    {
                        list.Add(fl);
                        listBox1.Items.Add(fl);

                        string optionalRooms = "", addressToStr = "";

                        addressToStr = fl.address.country + ", " + fl.address.city + ", " + fl.address.street + " " + fl.address.house + "/" + fl.address.flat;

                        if (fl.kitchen == "Кухня")
                        {
                            optionalRooms += fl.kitchen + "; ";
                        }
                        if (fl.bathroom == "Ванная")
                        {
                            optionalRooms += fl.bathroom + "; ";
                        }
                        if (fl.basement == "Подвал")
                        {
                            optionalRooms += fl.basement + "; ";
                        }
                        if (fl.balcony == "Балкон")
                        {
                            optionalRooms += fl.balcony + "; ";
                        }

                        int createPrice = fl.footage * fl.numOfRooms;

                        FlatsGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                    fl.floor, addressToStr, createPrice);
                    }

                AmountProdLabel.Text = list.Count().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void sortByNumOfRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Для сортировки необходим хотя бы один элемент", "Ошибка");
                return;
            }

            list = list.OrderBy(p => p.numOfRooms).ToList();
            FlatsGridView.Rows.Clear();
            foreach (var fl in list)
            {
                string optionalRooms = "", addressToStr = "";

                addressToStr = fl.address.country + ", " + fl.address.city + ", " + fl.address.street + " " + fl.address.house + "/" + fl.address.flat;

                if (fl.kitchen == "Кухня")
                {
                    optionalRooms += fl.kitchen + "; ";
                }
                if (fl.bathroom == "Ванная")
                {
                    optionalRooms += fl.bathroom + "; ";
                }
                if (fl.basement == "Подвал")
                {
                    optionalRooms += fl.basement + "; ";
                }
                if (fl.balcony == "Балкон")
                {
                    optionalRooms += fl.balcony + "; ";
                }

                int createPrice = fl.footage * fl.numOfRooms;

                FlatsGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                    fl.floor, addressToStr, createPrice);
            }
            LastActionLabel.Text = "Квартиры отсортированы по количеству комнат";
            AmountProdLabel.Text = list.Count().ToString();
        }

        private void sortByFootageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Для сортировки необходим хотя бы один элемент", "Ошибка");
                return;
            }

            list = list.OrderBy(p => p.footage).ToList();
            FlatsGridView.Rows.Clear();
            foreach (var fl in list)
            {
                string optionalRooms = "", addressToStr = "";

                addressToStr = fl.address.country + ", " + fl.address.city + ", " + fl.address.street + " " + fl.address.house + "/" + fl.address.flat;

                if (fl.kitchen == "Кухня")
                {
                    optionalRooms += fl.kitchen + "; ";
                }
                if (fl.bathroom == "Ванная")
                {
                    optionalRooms += fl.bathroom + "; ";
                }
                if (fl.basement == "Подвал")
                {
                    optionalRooms += fl.basement + "; ";
                }
                if (fl.balcony == "Балкон")
                {
                    optionalRooms += fl.balcony + "; ";
                }

                int createPrice = fl.footage * fl.numOfRooms;

                FlatsGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                    fl.floor, addressToStr, createPrice);
            }
            LastActionLabel.Text = "Квартиры отсортированы по метражу";
            AmountProdLabel.Text = list.Count().ToString();
        }

        private void sortByCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Для сортировки необходим хотя бы один элемент", "Ошибка");
                return;
            }

            list = list.OrderBy(p => p.price).ToList();
            FlatsGridView.Rows.Clear();
            foreach (var fl in list)
            {
                string optionalRooms = "", addressToStr = "";

                addressToStr = fl.address.country + ", " + fl.address.city + ", " + fl.address.street + " " + fl.address.house + "/" + fl.address.flat;

                if (fl.kitchen == "Кухня")
                {
                    optionalRooms += fl.kitchen + "; ";
                }
                if (fl.bathroom == "Ванная")
                {
                    optionalRooms += fl.bathroom + "; ";
                }
                if (fl.basement == "Подвал")
                {
                    optionalRooms += fl.basement + "; ";
                }
                if (fl.balcony == "Балкон")
                {
                    optionalRooms += fl.balcony + "; ";
                }

                int createPrice = fl.footage * fl.numOfRooms;

                FlatsGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                    fl.floor, addressToStr, createPrice);
            }
            LastActionLabel.Text = "Квартиры отсортированы по цене";
            AmountProdLabel.Text = list.Count().ToString();
        }

        private void SortToolStripButton_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Для сортировки необходим хотя бы один элемент", "Ошибка");
                return;
            }

            list = list.OrderBy(p => p.footage).ToList();
            FlatsGridView.Rows.Clear();
            foreach (var fl in list)
            {
                string optionalRooms = "", addressToStr = "";

                addressToStr = fl.address.country + ", " + fl.address.city + ", " + fl.address.street + " " + fl.address.house + "/" + fl.address.flat;

                if (fl.kitchen == "Кухня")
                {
                    optionalRooms += fl.kitchen + "; ";
                }
                if (fl.bathroom == "Ванная")
                {
                    optionalRooms += fl.bathroom + "; ";
                }
                if (fl.basement == "Подвал")
                {
                    optionalRooms += fl.basement + "; ";
                }
                if (fl.balcony == "Балкон")
                {
                    optionalRooms += fl.balcony + "; ";
                }

                int createPrice = fl.footage * fl.numOfRooms;

                FlatsGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                    fl.floor, addressToStr, createPrice);
            }
            LastActionLabel.Text = "Квартиры отсортированы по метражу";
            AmountProdLabel.Text = list.Count().ToString();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            var selectedRow = FlatsGridView.SelectedRows;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show("Выберите квартиру для удаления", "Ошибка");
                return;
            }
            for (int i = 0; i < FlatsGridView.Rows.Count; i++)
            {
                if (FlatsGridView.Rows[i].Selected)
                {
                    FlatsGridView.Rows.RemoveAt(i);
                    list.RemoveAt(i);
                    AmountProdLabel.Text = $"{list.Count}";
                    return;
                }
            }
        }

        private void FindToolStripButton_Click(object sender, EventArgs e)
        {
            FindForm ff = new FindForm(FindType._NumOfRooms, list);
            ff.Show();
            ff.Closed += Ff_Closed;
        }

        private void HideToolStripButton_Click(object sender, EventArgs e)
        {
            toolStrip.Hide();
            WrenchPictureBox.Show();
        }

        private void ClearStripToolButton_Click(object sender, EventArgs e)
        {
            list.Clear();
            FlatsGridView.Rows.Clear();
            AmountProdLabel.Text = "0";
        }

        private void UpArrowToolStripButton_Click(object sender, EventArgs e)
        {
            var selectedRow = FlatsGridView.SelectedRows;
            if (selectedRow.Count == 0)
            {
                FlatsGridView.Rows[0].Selected = true;
                return;
            }

            for (int i = 0; i < FlatsGridView.Rows.Count; i++)
            {
                if (FlatsGridView.Rows[i].Selected)
                {
                    if (i == 0)
                    {
                        return;
                    }

                    FlatsGridView.CurrentCell = FlatsGridView[1, i - 1];
                    FlatsGridView.Rows[i - 1].Selected = true;
                    FlatsGridView.Rows[i].Selected = false;
                    return;
                }
            }
        }

        private void DownArrowToolStripButton_Click(object sender, EventArgs e)
        {
            var selectedRow = FlatsGridView.SelectedRows;
            if (selectedRow.Count == 0)
            {
                FlatsGridView.Rows[0].Selected = true;
                return;
            }

            for (int i = 0; i < FlatsGridView.Rows.Count; i++)
            {
                if (FlatsGridView.Rows[i].Selected)
                {
                    if (i == FlatsGridView.Rows.Count - 1)
                    {
                        return;
                    }

                    FlatsGridView.CurrentCell = FlatsGridView[1, i + 1];
                    FlatsGridView.Rows[i + 1].Selected = true;
                    FlatsGridView.Rows[i].Selected = false;
                    return;
                }
            }
        }

        private void SingletonSettings_Click(object sender, EventArgs e)
        {
            SingletonForm form = new SingletonForm();
            form.form = this;
            form.BackgroundColorLabel.Text = Convert.ToString(FormSettingsSingleton.GetInstance().backColor);
            
            form.FontSizeLabel.Text = $@"Размер шрифта: {Convert.ToString(FormSettingsSingleton.GetInstance().fontSize)}";
            form.Show();
        }

        private void BigFlatWithOptions_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            BigFlatBuilder bigFlatBuilder = new BigFlatBuilder();
            director.BuilderBase = bigFlatBuilder;
            director.BuildWithOptions();
            list.Add(bigFlatBuilder.GetFlat());

            string optionalRooms = "", addressToStr = "---";

            if (bigFlatBuilder.GetFlat().kitchen == "Кухня")
            {
                optionalRooms += bigFlatBuilder.GetFlat().kitchen + "; ";
            }
            if (bigFlatBuilder.GetFlat().bathroom == "Ванная")
            {
                optionalRooms += bigFlatBuilder.GetFlat().bathroom + "; ";
            }
            if (bigFlatBuilder.GetFlat().basement == "Подвал")
            {
                optionalRooms += bigFlatBuilder.GetFlat().basement + "; ";
            }
            if (bigFlatBuilder.GetFlat().balcony == "Балкон")
            {
                optionalRooms += bigFlatBuilder.GetFlat().balcony + "; ";
            }

            int createPrice = bigFlatBuilder.GetFlat().footage * bigFlatBuilder.GetFlat().numOfRooms;

            FlatsGridView.Rows.Add(bigFlatBuilder.GetFlat().footage, bigFlatBuilder.GetFlat().numOfRooms, 
                optionalRooms, bigFlatBuilder.GetFlat().yearOfConstruction, bigFlatBuilder.GetFlat().material,
                        bigFlatBuilder.GetFlat().floor, addressToStr, createPrice);
        }

        private void BigFlatWithoutOptions_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            BigFlatBuilder bigFlatBuilder = new BigFlatBuilder();
            director.BuilderBase = bigFlatBuilder;
            director.BuildWithoutOptions();
            list.Add(bigFlatBuilder.GetFlat());

            string optionalRooms = "---", addressToStr = "---";

            int createPrice = bigFlatBuilder.GetFlat().footage * bigFlatBuilder.GetFlat().numOfRooms;

            FlatsGridView.Rows.Add(bigFlatBuilder.GetFlat().footage, bigFlatBuilder.GetFlat().numOfRooms,
                optionalRooms, bigFlatBuilder.GetFlat().yearOfConstruction, bigFlatBuilder.GetFlat().material,
                        bigFlatBuilder.GetFlat().floor, addressToStr, createPrice);
        }

        private void SmallFlatWithOptions_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            SmallFlatBuilder smallFlatBuilder = new SmallFlatBuilder();
            director.BuilderBase = smallFlatBuilder;
            director.BuildWithOptions();
            list.Add(smallFlatBuilder.GetFlat());

            string optionalRooms = "", addressToStr = "---";

            if (smallFlatBuilder.GetFlat().kitchen == "Кухня")
            {
                optionalRooms += smallFlatBuilder.GetFlat().kitchen + "; ";
            }
            if (smallFlatBuilder.GetFlat().bathroom == "Ванная")
            {
                optionalRooms += smallFlatBuilder.GetFlat().bathroom + "; ";
            }
            if (smallFlatBuilder.GetFlat().basement == "Подвал")
            {
                optionalRooms += smallFlatBuilder.GetFlat().basement + "; ";
            }
            if (smallFlatBuilder.GetFlat().balcony == "Балкон")
            {
                optionalRooms += smallFlatBuilder.GetFlat().balcony + "; ";
            }

            int createPrice = smallFlatBuilder.GetFlat().footage * smallFlatBuilder.GetFlat().numOfRooms;

            FlatsGridView.Rows.Add(smallFlatBuilder.GetFlat().footage, smallFlatBuilder.GetFlat().numOfRooms,
                optionalRooms, smallFlatBuilder.GetFlat().yearOfConstruction, smallFlatBuilder.GetFlat().material,
                        smallFlatBuilder.GetFlat().floor, addressToStr, createPrice);
        }

        private void SmallFlatWithoutOptions_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            SmallFlatBuilder smallFlatBuilder = new SmallFlatBuilder();
            director.BuilderBase = smallFlatBuilder;
            director.BuildWithoutOptions();
            list.Add(smallFlatBuilder.GetFlat());

            string optionalRooms = "---", addressToStr = "---";

            int createPrice = smallFlatBuilder.GetFlat().footage * smallFlatBuilder.GetFlat().numOfRooms;

            FlatsGridView.Rows.Add(smallFlatBuilder.GetFlat().footage, smallFlatBuilder.GetFlat().numOfRooms,
                optionalRooms, smallFlatBuilder.GetFlat().yearOfConstruction, smallFlatBuilder.GetFlat().material,
                        smallFlatBuilder.GetFlat().floor, addressToStr, createPrice);
        }

        private void DeepCopyButton_Click(object sender, EventArgs e)
        {
            Flat fl = list[list.Count - 1].DeepCopy();

            string optionalRooms = "", addressToStr = "---";

            if (fl.kitchen == "Кухня")
            {
                optionalRooms += fl.kitchen + "; ";
            }
            if (fl.bathroom == "Ванная")
            {
                optionalRooms += fl.bathroom + "; ";
            }
            if (fl.basement == "Подвал")
            {
                optionalRooms += fl.basement + "; ";
            }
            if (fl.balcony == "Балкон")
            {
                optionalRooms += fl.balcony + "; ";
            }

            int createPrice = fl.footage * fl.numOfRooms;

            FlatsGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, 
                fl.yearOfConstruction, fl.material, fl.floor, addressToStr, createPrice);
        }
    }
}
