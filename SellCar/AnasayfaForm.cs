using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellCar
{
    public partial class AnasayfaForm : Form
    {
        ListButton deneme = new ListButton();

        FormManager formManager = FormManager.GetInstance();
        public AnasayfaForm()
        {
            InitializeComponent();
        }

        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            arabalarPanel.AutoScroll = true;

            satButton.TabStop = false;
            satButton.FlatStyle = FlatStyle.Flat;
            satButton.FlatAppearance.BorderSize = 0;

            servisButton.TabStop = false;
            servisButton.FlatStyle = FlatStyle.Flat;
            servisButton.FlatAppearance.BorderSize = 0;

            satilanlarButon.TabStop = false;
            satilanlarButon.FlatStyle = FlatStyle.Flat;
            satilanlarButon.FlatAppearance.BorderSize = 0;

            servistekilerButon.TabStop = false;
            servistekilerButon.FlatStyle = FlatStyle.Flat;
            servistekilerButon.FlatAppearance.BorderSize = 0;

            aracEkleButton.TabStop = false;
            aracEkleButton.FlatStyle = FlatStyle.Flat;
            aracEkleButton.FlatAppearance.BorderSize = 0;

            geriButton.TabStop = false;
            geriButton.FlatStyle = FlatStyle.Flat;
            geriButton.FlatAppearance.BorderSize = 0;



            deneme.InitButton();
            for(int i = 0; i < 10; i++)
            {
                
                Button b = new Button();
                b.TabStop = false;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font("Bebas Neue Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                b.Text= deneme.ArabaAdi+i;
                b.TextAlign = ContentAlignment.BottomCenter;
                b.Image = ((System.Drawing.Image)(Image.FromFile(deneme.ArabaResimUrl)));
                b.ImageAlign = ContentAlignment.TopCenter;
                b.Size = new Size(310, 120);
                arabalarPanel.Controls.Add(b);
                b.Click += new EventHandler(this.aracButton_Click);
            }
            //button1.Text = deneme.ArabaAdi;
            //button1.Image = ((System.Drawing.Image)(Image.FromFile(deneme.ArabaResimUrl)));

        }

        void aracButton_Click(object sender, EventArgs e)
        {
            Button b =  (Button) sender;

            MessageBox.Show(b.Text);
        }

        private void satButton_Click(object sender, EventArgs e)
        {
            formManager.AracSatAc();
        }

        private void aracEkleButton_Click(object sender, EventArgs e)
        {
            formManager.AracEkleAc();
        }

        private void servisButton_Click(object sender, EventArgs e)
        {
            formManager.ServisGonderAc();
        }

        private void arabalarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
