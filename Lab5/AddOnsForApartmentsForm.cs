using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AddOnsForApartmentsForm : Form
    {
        public Form1 form;
        public AddOnsForApartmentsForm()
        {
            InitializeComponent();
        }

        private void AddFlatWithAddOnsButton_Click(object sender, EventArgs e)
        {
            if (RenovationCheckBox.Checked &&
                !FurnitureCheckBox.Checked &&
                !AlarmCheckBox.Checked)
            {
                Flat flat = new Flat();
                flat = new FlatWithRenovation(flat);
                form.list.Add(flat);
                form.FlatsGridView.Rows.Add(flat.footage, flat.numOfRooms, "Кухня; Подвал;",
                    flat.yearOfConstruction, flat.material,
                    flat.floor, "Беларусь, Минск, Советская 14/2", "-", flat.addons);
                this.Close();
            }
            if (!RenovationCheckBox.Checked &&
                FurnitureCheckBox.Checked &&
                !AlarmCheckBox.Checked)
            {
                Flat flat = new Flat();
                flat = new FlatWithFurniture(flat);
                form.list.Add(flat);
                form.FlatsGridView.Rows.Add(flat.footage, flat.numOfRooms, "Кухня; Подвал;",
                    flat.yearOfConstruction, flat.material,
                    flat.floor, "Беларусь, Минск, Советская 14/2", "-", flat.addons);
                this.Close();
            }
            if (!RenovationCheckBox.Checked &&
               !FurnitureCheckBox.Checked &&
               AlarmCheckBox.Checked)
            {
                Flat flat = new Flat();
                flat = new FlatWithAlarm(flat);
                form.list.Add(flat);
                form.FlatsGridView.Rows.Add(flat.footage, flat.numOfRooms, "Кухня; Подвал;",
                    flat.yearOfConstruction, flat.material,
                    flat.floor, "Беларусь, Минск, Советская 14/2", "-", flat.addons);
                this.Close();
            }
            if (RenovationCheckBox.Checked &&
               FurnitureCheckBox.Checked &&
               !AlarmCheckBox.Checked)
            {
                Flat flat = new Flat();
                flat = new FlatWithRenovation(flat);
                flat = new FlatWithFurniture(flat);
                form.list.Add(flat);
                form.FlatsGridView.Rows.Add(flat.footage, flat.numOfRooms, "Кухня; Подвал;",
                    flat.yearOfConstruction, flat.material,
                    flat.floor, "Беларусь, Минск, Советская 14/2", "-", flat.addons);
                this.Close();
            }
            if (RenovationCheckBox.Checked &&
               !FurnitureCheckBox.Checked &&
               AlarmCheckBox.Checked)
            {
                Flat flat = new Flat();
                flat = new FlatWithRenovation(flat);
                flat = new FlatWithAlarm(flat);
                form.list.Add(flat);
                form.FlatsGridView.Rows.Add(flat.footage, flat.numOfRooms, "Кухня; Подвал;",
                    flat.yearOfConstruction, flat.material,
                    flat.floor, "Беларусь, Минск, Советская 14/2", "-", flat.addons);
                this.Close();
            }
            if (!RenovationCheckBox.Checked &&
               FurnitureCheckBox.Checked &&
               AlarmCheckBox.Checked)
            {
                Flat flat = new Flat();
                flat = new FlatWithFurniture(flat);
                flat = new FlatWithAlarm(flat);
                form.list.Add(flat);
                form.FlatsGridView.Rows.Add(flat.footage, flat.numOfRooms, "Кухня; Подвал;",
                    flat.yearOfConstruction, flat.material,
                    flat.floor, "Беларусь, Минск, Советская 14/2", "-", flat.addons);
                this.Close();
            }
            if (RenovationCheckBox.Checked &&
               FurnitureCheckBox.Checked &&
               AlarmCheckBox.Checked)
            {
                Flat flat = new Flat();
                flat = new FlatWithRenovation(flat);
                flat = new FlatWithFurniture(flat);
                flat = new FlatWithAlarm(flat);
                form.list.Add(flat);
                form.FlatsGridView.Rows.Add(flat.footage, flat.numOfRooms, "Кухня; Подвал;",
                    flat.yearOfConstruction, flat.material,
                    flat.floor, "Беларусь, Минск, Советская 14/2", "-", flat.addons);
                this.Close();
            }

        }
    }
}
