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
            // Carregar dados na grid
            Tbl_ListaCartões.DataSource = Banco.TodosCartões();

            // Adicionar coluna de checkbox manualmente
            var chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "Selecionar";
            chkCol.HeaderText = "Selecionar";
            chkCol.FalseValue = false;
            chkCol.TrueValue = true;
            chkCol.ReadOnly = false; // Permitir edição
            Tbl_ListaCartões.Columns.Add(chkCol);

            // Configurar o modo de edição
            Tbl_ListaCartões.EditMode = DataGridViewEditMode.EditOnEnter;
            Tbl_ListaCartões.AllowUserToAddRows = false; // Evitar que linhas vazias sejam adicionadas

            // Certificar que todas as colunas, exceto o checkbox, são somente leitura
            foreach (DataGridViewColumn col in Tbl_ListaCartões.Columns)
            {
                if (col.Name != "Selecionar")
                {
                    col.ReadOnly = true; // As outras colunas não devem ser editáveis
                }
            }

            // Adicionar o evento DataError para evitar erros
            Tbl_ListaCartões.DataError += Tbl_ListaCartões_DataError;
        }

        private void Tbl_ListaCartões_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ignorar erros de conversão
            e.ThrowException = false;
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            // Confirma a exclusão
            DialogResult res = MessageBox.Show("Deseja apagar o(s) utilizador(es) selecionado(s)?", "Apagar", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                // Itera sobre as linhas da tabela de trás para frente
                for (int i = Tbl_ListaCartões.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = Tbl_ListaCartões.Rows[i];

                    // Verifica se a CheckBox está marcada
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Selecionar"]; // Mude "CheckBoxColumn" para o nome da coluna correta
                    if (chk.Value != null && (bool)chk.Value == true)
                    {
                        // Obtém o ID do utilizador (mude o índice da célula de acordo com a sua tabela)
                        string idaluno = row.Cells["ID"].Value.ToString(); // Mude "IdColumn" para o nome correto da coluna ID

                        // Apaga o utilizador do banco de dados
                        Banco.ApagarAluno(idaluno);

                        // Remove a linha da tabela
                        Tbl_ListaCartões.Rows.Remove(row);
                    }
                }
            }
        }

    }
}
