using SellCar.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellCar
{
    public class ListButton
    {
        private string arabaResimURL;
        public string ArabaResimUrl { get { return arabaResimURL; } set { arabaResimURL = value; } }
        private string arabaAdi;
        public string ArabaAdi { get { return arabaAdi; } set { arabaAdi = value; } }
        private string arabaFiyat;
        public string ArabaFiyat { get { return arabaFiyat; } set { arabaFiyat = value; } }


        Button buton = new Button();
        public void InitButton()
        {
            arabaResimURL = "C:/Users/ka6an/Desktop/car.png";
            arabaAdi = "Porsche 911 Turbo";
        }
    }
}
