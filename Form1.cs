using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerXCittà
{
    public partial class Form1 : Form
    {
        public DataBase db;
        public Form1()
        {
            InitializeComponent();
            db = new DataBase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rowsCitta = db.GetListaCittà().DefaultView;
            cbx_citta.DisplayMember = "city";
            cbx_citta.DataSource = rowsCitta;
        }

        private void btn_cerca_Click(object sender, EventArgs e)
        {
            var elencoCustomerCitta = cbx_citta.SelectedItem as DataRowView;
            var città = $"{elencoCustomerCitta["city"]}";
            var rows = db.GetListaCustomerXCity(città);
            dgr_customerXcitta.DataSource = rows;
        }
    }
}
