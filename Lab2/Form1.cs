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
            try
            {
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

                addressToStr = addres.country + ", " + addres.city + ", " + addres.street + " " + addres.house + "/" + addres.flat;

                Flat flat = new Flat(Convert.ToInt32(footageBox.Text), Convert.ToInt32(RoomsBar.Value), 
                    dateOfConst.Text, Convert.ToInt32(floorBox.Text), kith, bath, basem, 
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
                    floorBox.Text, addressToStr);
                ClearFields();
            }
            catch (Exception)
            {

            }

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
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
