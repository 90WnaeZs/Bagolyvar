using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezeteknev_Keresztnev_Gepszam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Kolcsonzes_Click(object sender, EventArgs e)
        {
            Kölcsönző k = new Kölcsönző();
            k.Show();
        }

        private void btn_Visszavitel_Click(object sender, EventArgs e)
        {
            Visszavétel v = new Visszavétel();
            v.Show();
        }
    }
}
