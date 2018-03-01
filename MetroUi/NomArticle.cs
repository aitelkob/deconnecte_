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
    public partial class NomArticle : MetroFramework.Forms.MetroForm
    {
        public NomArticle()
        {
            InitializeComponent();
        }

        private void NomArticle_Load(object sender, EventArgs e)
        {
            Program.dp_client.Fill(Program.ds.Tables["Client"]);
            listBox1.DisplayMember = "nom";
            listBox1.DataSource = Program.ds.Tables["Client"];
        }
    }
}
