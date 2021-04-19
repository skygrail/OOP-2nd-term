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
    public partial class SingletonForm : Form
    {
        public Form1 form;
        public SingletonForm()
        {
            InitializeComponent();
        }

        private void BackGroundColorButton_Click(object sender, EventArgs e)
        {
            BackgroundColorDialog.ShowDialog();
            form.BackColor = BackgroundColorDialog.Color;
            FormSettingsSingleton.GetInstance().backColor = BackgroundColorDialog.Color;
            BackgroundColorLabel.Text = Convert.ToString(FormSettingsSingleton.GetInstance().backColor);
        }
    }
}
