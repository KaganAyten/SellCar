using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellCar
{
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
        }
        FormManager formManager = FormManager.GetInstance();
        private void GirisYapForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            girisYapButton.TabStop = false;
            girisYapButton.FlatStyle = FlatStyle.Flat;
            girisYapButton.FlatAppearance.BorderSize = 0;

            kapatButton.TabStop = false;
            kapatButton.FlatStyle = FlatStyle.Flat;
            kapatButton.FlatAppearance.BorderSize = 0;
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            formManager.AnaSayfaAc();
            formManager.HosgeldinKapa();
            this.Hide();
        }
    }
}
