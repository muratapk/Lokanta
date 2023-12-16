using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void masaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masa_Ekle masa = new Masa_Ekle();
            masa.MdiParent = this;
            masa.Show();
        }

        private void masaGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masa_Liste liste = new Masa_Liste();
            liste.MdiParent = this;
            liste.Show();
        }
    }
}
