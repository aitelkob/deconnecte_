using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUi
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.chrg_dataset();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeNomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NomArticle na = new NomArticle();
            na.Show();
        }

        private void listeParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientparville cv = new Clientparville();
            cv.Show();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCommand ls = new ListCommand();
            ls.Show();
        }
    }
}
