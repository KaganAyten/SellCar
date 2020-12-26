using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellCar
{
    public partial class HosgeldinForm : Form
    {
        FormManager formManager = FormManager.GetInstance();
        public HosgeldinForm()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            girisYapButton.TabStop = false;
            girisYapButton.FlatStyle = FlatStyle.Flat;
            girisYapButton.FlatAppearance.BorderSize = 0;

            kullaniciKayitButton.TabStop = false;
            kullaniciKayitButton.FlatStyle = FlatStyle.Flat;
            kullaniciKayitButton.FlatAppearance.BorderSize = 0;

            kapatButton.TabStop = false;
            kapatButton.FlatStyle = FlatStyle.Flat;
            kapatButton.FlatAppearance.BorderSize = 0;


        }

        private void girisYapButton_MouseHover(object sender, EventArgs e)
        {
            girisYapButton.ForeColor = Color.FromArgb(242, 173, 0);
            girisYapButton.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void girisYapButton_MouseLeave(object sender, EventArgs e)
        {
            girisYapButton.ForeColor = Color.FromArgb(250, 196, 43);
            girisYapButton.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void kullaniciKayit_MouseHover(object sender, EventArgs e)
        {
            kullaniciKayitButton.ForeColor = Color.FromArgb(242, 173, 0);
            kullaniciKayitButton.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void kullaniciKayit_MouseLeave(object sender, EventArgs e)
        {
            kullaniciKayitButton.ForeColor = Color.FromArgb(250, 196, 43);
            kullaniciKayitButton.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            formManager.GirisYapAc();
        }

        private void kullaniciKayitButton_Click(object sender, EventArgs e)
        {
            formManager.KayitEkleAc();
        }
    }
}
