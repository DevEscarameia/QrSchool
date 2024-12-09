using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class Computadores : Form
    {
        public Computadores()
        {
            InitializeComponent();
        }

        private void Computadores_Load(object sender, EventArgs e)
        {
            Tbl_ListaComputadores.DataSource = Banco.TodosComputadore();

        }

        private void Tbl_ListaComputadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
