using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellCar
{
    public partial class AraciSatForm : Form
    {
        public AraciSatForm()
        {
            InitializeComponent();
        }

        private void AraciSatForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
