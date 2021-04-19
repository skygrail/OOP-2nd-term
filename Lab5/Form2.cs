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
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Lab2
{

    public enum FindType
    {
        _NumOfRooms, _Year, _City
    }
    public partial class FindForm : Form
    {
        private List<Flat> flats;
        private List<Flat> foundFlats = new List<Flat>();
        private FindType ft;

        public FindForm()
        {
            InitializeComponent();
        }

        public FindForm(FindType type, List<Flat> products)
        {
            InitializeComponent();
            ft = type;
            this.flats = products;
            switch (ft)
            {
                case FindType._NumOfRooms:
                    this.Text = "Поиск по кол-ву комнат";
                    break;
                case FindType._Year:
                    this.Text = "Поиск по году постройки";
                    break;
                case FindType._City:
                    this.Text = "Поиск по городу";
                    break;
            }
        }

        private void FindSaveMenu_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "Serialize_found_save.xml";
                saveFileDialog1.ShowDialog();
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Flat>));
                    xmlSerializer.Serialize(fs, foundFlats);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            ErrorProvider ep = new ErrorProvider();
            if (FindTypeComboBox.Text == "")
            {
                ep.SetError(FindTypeComboBox, "Выберите тип поиска");
                return;
            }

            if (EnterTextBox.Text == "")
            {
                ep.SetError(EnterTextBox, "Введите выражение");
                return;
            }

            switch (ft) //Определяем тип поиска
            {
                case (FindType._NumOfRooms):
                    {
                        switch (FindTypeComboBox.Text) // Определяем тип выражения
                        {
                            case ("Полное соответствие"):
                                {

                                    foundFlats = flats.FindAll(p => p.numOfRooms ==  Convert.ToInt32(EnterTextBox.Text));
                                    if (foundFlats.Count == 0)
                                    {
                                        MessageBox.Show("Совпадений не найдено", "Ошибка");
                                        return;
                                    }

                                    if (FlatsFoundGridView.RowCount != 0)
                                    {
                                        FlatsFoundGridView.Rows.Clear();
                                    }

                                    foreach (var fl in foundFlats)
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

                                        FlatsFoundGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                                        fl.floor, addressToStr, createPrice);
                                    }

                                    break;
                                }
                            case ("Регулярное выражение"):
                                {
                                    Regex regex = new Regex($@"{EnterTextBox.Text}");
                                    try
                                    {
                                        foreach (var el in flats)
                                        {
                                            if (regex.IsMatch(Convert.ToString(el.numOfRooms)))
                                            {
                                                foundFlats.Add(el);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Неверное регулярное выражение", "Ошибка");
                                    }

                                    if (FlatsFoundGridView.RowCount != 0)
                                    {
                                        FlatsFoundGridView.Rows.Clear();
                                    }
                                    
                                        foreach (var fl in foundFlats)
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

                                            FlatsFoundGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                                            fl.floor, addressToStr, createPrice);
                                        }
                                    

                                    break;
                                }

                        }

                        break;
                    }
                case (FindType._Year):
                    {
                        switch (FindTypeComboBox.Text) // Определяем тип выражения
                        {
                            case ("Полное соответствие"):
                                {

                                    foundFlats = flats.FindAll(p => p.yearOfConstruction == EnterTextBox.Text);
                                    if (foundFlats.Count == 0)
                                    {
                                        MessageBox.Show("Совпадений не найдено", "Ошибка");
                                        return;
                                    }

                                    if (FlatsFoundGridView.RowCount != 0)
                                    {
                                        FlatsFoundGridView.Rows.Clear();
                                    }

                                    foreach (var fl in foundFlats)
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

                                        FlatsFoundGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                                        fl.floor, addressToStr, createPrice);
                                    }

                                    break;
                                }
                            case ("Регулярное выражение"):
                                {
                                    Regex regex = new Regex($@"{EnterTextBox.Text}");
                                    foreach (var el in flats)
                                    {
                                        if (regex.IsMatch(el.yearOfConstruction))
                                        {
                                            foundFlats.Add(el);
                                        }
                                    }
                                    if (FlatsFoundGridView.RowCount != 0)
                                    {
                                        FlatsFoundGridView.Rows.Clear();
                                    }
                                    
                                        foreach (var fl in foundFlats)
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

                                            FlatsFoundGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                                            fl.floor, addressToStr, createPrice);
                                        }
                                    

                                    break;
                                }

                        }
                        break;
                    }
                case (FindType._City):
                    {
                        switch (FindTypeComboBox.Text) // Определяем тип выражения
                        {
                            case ("Полное соответствие"):
                                {
                                    foundFlats = flats.FindAll(p => p.address.city == EnterTextBox.Text);
                                    if (foundFlats.Count == 0)
                                    {
                                        MessageBox.Show("Совпадений не найдено", "Ошибка");
                                        return;
                                    }

                                    if (FlatsFoundGridView.RowCount != 0)
                                    {
                                        FlatsFoundGridView.Rows.Clear();
                                    }

                                    foreach (var fl in foundFlats)
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

                                        FlatsFoundGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                                        fl.floor, addressToStr, createPrice);
                                    }

                                    break;
                                }
                            case ("Регулярное выражение"):
                                {
                                    Regex regex = new Regex($@"{EnterTextBox.Text}");
                                    foreach (var el in flats)
                                    {
                                        if (regex.IsMatch(el.address.city))
                                        {
                                            foundFlats.Add(el);
                                        }
                                    }
                                    if (FlatsFoundGridView.RowCount != 0)
                                    {
                                        FlatsFoundGridView.Rows.Clear();
                                    }
                                   
                                        foreach (var fl in foundFlats)
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

                                            FlatsFoundGridView.Rows.Add(fl.footage, fl.numOfRooms, optionalRooms, fl.yearOfConstruction, fl.material,
                                            fl.floor, addressToStr, createPrice);
                                        }
                                    

                                    break;
                                }
                        }
                        break;
                    }
            }

        }
    }
    
}
