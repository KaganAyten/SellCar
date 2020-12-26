using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellCar
{
    public partial class KayitEkleForm : Form
    {
        public KayitEkleForm()
        {
            InitializeComponent();
        }

        private void KayitEkleForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            kullaniciKayitButton.TabStop = false;
            kullaniciKayitButton.FlatStyle = FlatStyle.Flat;
            kullaniciKayitButton.FlatAppearance.BorderSize = 0;

            kapatButton.TabStop = false;
            kapatButton.FlatStyle = FlatStyle.Flat;
            kapatButton.FlatAppearance.BorderSize = 0;
        }

    }
}
