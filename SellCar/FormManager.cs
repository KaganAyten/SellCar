using System;
using System.Collections.Generic;
using System.Text;

namespace SellCar
{
    public class FormManager
    {
        static HosgeldinForm hosgeldinForm = new HosgeldinForm();
        static KayitEkleForm kayitEkleForm = new KayitEkleForm();
        static GirisYapForm girisYapForm = new GirisYapForm();
        static AnasayfaForm anaSayfaForm = new AnasayfaForm();
        static AracEkleForm aracEkleForm = new AracEkleForm();
        static ServiseGonderForm servisGonderForm = new ServiseGonderForm();
        static AraciSatForm aracSatForm = new AraciSatForm();
        private FormManager() { }
        private static FormManager instance;
        public static FormManager GetInstance()
        {
            if (instance == null)
            {
                instance = new FormManager();
            }
            return instance;
        }
        public void AracSatAc()
        {
            aracSatForm.Show();
        }
        public void AracSatKapat()
        {
            aracSatForm.Hide();
        }
        public void ServisGonderAc()
        {
            servisGonderForm.Show();
        }
        public void ServisGonderKapat()
        {
            servisGonderForm.Hide();
        }
        public void HosgeldinAc()
        {
            hosgeldinForm.Show();
        }
        public void HosgeldinKapa()
        {
            hosgeldinForm.Hide();
        }
        public void AnaSayfaAc()
        {
            anaSayfaForm.Show();
        }
        public void AnaSayfaKapa()
        {
            anaSayfaForm.Hide();
        }
        public void GirisYapAc()
        {
            girisYapForm.Show();
        }
        public void GirisYapKapa()
        {
            girisYapForm.Hide();
        }
        public void KayitEkleAc()
        {
            kayitEkleForm.Show();
        }
        public void KayitEkleKapa()
        {
            kayitEkleForm.Hide();
        }
        public void AracEkleAc()
        {
            aracEkleForm.Show();
        }
        public void AracEkleKapat()
        {
            aracEkleForm.Hide();
        }
    }
}
