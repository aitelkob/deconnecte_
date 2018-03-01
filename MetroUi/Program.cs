using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MetroUi
{
    static class Program
    {
        public static string con = @"Data Source=DESKTOP-QCI5Q2S\YOUSSEF;Initial Catalog=vente;Integrated Security=True";
        public static DataSet ds = new DataSet();
        public static SqlDataAdapter dp_client = new SqlDataAdapter(" select * from Client", con);
        public static SqlDataAdapter dp_article = new SqlDataAdapter(" select * from Article ", con);
        public static SqlDataAdapter dp_command = new SqlDataAdapter(" select * from Commande", con);
        public static SqlDataAdapter dp_detail = new SqlDataAdapter("select * from Détail", con);
        public static int cmd;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static void chrg_dataset()
        {   dp_client.Fill(ds, "Client");
            dp_article.Fill(ds, "article");
           
            dp_command.Fill(ds, "Command");
            dp_detail.Fill(ds, "Détail");
            ds.Tables["Client"].PrimaryKey = new DataColumn[] { ds.Tables["Client"].Columns["CodeCi"] };
            ds.Tables["Command"].PrimaryKey = new DataColumn[] { ds.Tables["Command"].Columns["NumCom"] };
            ds.Tables["article"].PrimaryKey = new DataColumn[] { ds.Tables["article"].Columns["CodeArt"] };
            ds.Tables["Détail"].PrimaryKey = new DataColumn[] { ds.Tables["Détail"].Columns["NumCom"] };


            ds.Relations.Add(new DataRelation("R_clt_cmd", ds.Tables["Client"].Columns["CodeCi"],ds.Tables["Command"].Columns["CodeCi"]));
            ds.Relations.Add(new DataRelation("R_cmd_detail", ds.Tables["Command"].Columns["NumCom"], ds.Tables["Détail"].Columns["NumCom"]));

        }
    }
}
