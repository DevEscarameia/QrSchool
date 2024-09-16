 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class ListaCartões : Form
    {
        public ListaCartões()
        {
            InitializeComponent();
        }
      
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ListaCartões_Load(object sender, EventArgs e)
        {
            Tbl_ListaCartões.DataSource = Banco.TodosCartões();
            var col = new DataGridViewCheckBoxColumn();
            col.Name = "Coluna";
            col.HeaderText = "Selecionar";
            col.FalseValue = "0";
            col.TrueValue = "1";

            //Make the default checked
            col.CellTemplate.Value = false;
            col.CellTemplate.Style.NullValue = false;

            Tbl_ListaCartões.Columns.Add(col);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
