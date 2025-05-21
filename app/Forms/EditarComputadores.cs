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
    public partial class EditarComputadores : Form
    {
        private Form1 mainForm;
        public EditarComputadores(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;


        }
        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
        }
        private void Computadores_Load(object sender, EventArgs e)
        {
            Tbl_ListaComputadores.DataSource = Banco.TodosComputadores();

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainForm.PanelPrincipal.Controls.Add(childForm); // Usando a propriedade pública
            mainForm.PanelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Tbl_ListaComputadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_novoPc_Click(object sender, EventArgs e)
        {
            openChildForm(new NovoComputadores(mainForm));
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (Tbl_ListaComputadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um computador para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int linha = Tbl_ListaComputadores.SelectedRows[0].Index;

            // Criar objeto Computador com os novos valores
            Computador c = new Computador();
            c.ID_Portateis = Convert.ToInt32(txt_Id.Text);
            c.T_DESCRIÇÃO = txt_descrição.Text;

            // Criar lista para armazenar os softwares selecionados
            List<string> softwaresSelecionados = new List<string>();

            // Adicionar os softwares marcados na CheckedListBox
            foreach (var item in checkedListBox_Softwares.CheckedItems)
            {
                softwaresSelecionados.Add(item.ToString());
            }

            // Adicionar o que foi escrito na TextBox de "Outros" (se não estiver vazia)
            if (!string.IsNullOrWhiteSpace(txt_Outros.Text))
            {
                softwaresSelecionados.Add(txt_Outros.Text.Trim());
            }

            // Converter a lista de softwares para uma string separada por vírgulas
            c.T_SOFTWARES = string.Join(", ", softwaresSelecionados);
            c.B_ESTADO = checkBox_Estado.Checked;
            try
            {
                // Chamar o método para atualizar no banco de dados
                Banco.AtualizarComputadores(c);

                // Exibir notificação de sucesso
                mostrarNotificaçao("SUCESSO", "Computador atualizado com sucesso!");

                // Atualiza a grid e mantém a linha selecionada
                Tbl_ListaComputadores.DataSource = Banco.TodosComputadores();
                Tbl_ListaComputadores.CurrentCell = Tbl_ListaComputadores[0, linha];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar o computador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Apagar Computador?", "Apagar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ApagarComputador(txt_Id.Text);
                Tbl_ListaComputadores.Rows.Remove(Tbl_ListaComputadores.CurrentRow);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tbl_ListaComputadores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = Banco.TodosComputadores();
                DataRow[] rows = dt.Select("ID = '" + vid + "'");

                if (rows.Length > 0)
                {
                    txt_Id.Text = rows[0].Field<Int64>("ID").ToString();
                    txt_descrição.Text = rows[0].Field<string>("Descrição").ToString();
                    checkBox_Estado.Checked = rows[0].Field<bool>("Estado");                    // Obtém a string dos softwares da base de dados
                    string softwaresDB = rows[0].Field<string>("Softwares") ?? string.Empty;

                    // Separa os softwares armazenados (supondo que estejam separados por vírgulas)
                    string[] softwaresSelecionados = softwaresDB.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    // Limpa a CheckListBox antes de preencher
                    foreach (int i in Enumerable.Range(0, checkedListBox_Softwares.Items.Count))
                    {
                        checkedListBox_Softwares.SetItemChecked(i, false);
                    }

                    txt_Outros.Text = ""; // Limpa a TextBox

                    // Usar StringBuilder para construir a lista de outros softwares
                    StringBuilder outrosSoftwares = new StringBuilder();

                    // Itera sobre os softwares guardados na BD
                    foreach (string software in softwaresSelecionados)
                    {
                        string softwareTrim = software.Trim();
                        int index = checkedListBox_Softwares.Items.IndexOf(softwareTrim);

                        if (index >= 0)
                        {
                            // Se existir na lista, marcar como selecionado
                            checkedListBox_Softwares.SetItemChecked(index, true);
                        }
                        else
                        {
                            // Se não existir, adiciona à StringBuilder
                            if (outrosSoftwares.Length == 0)
                                outrosSoftwares.Append(softwareTrim);
                            else
                                outrosSoftwares.Append(", " + softwareTrim);
                        }
                    }

                    // Atualiza a TextBox com os outros softwares
                    txt_Outros.Text = outrosSoftwares.ToString();
                }
            }
        }

        private void checkedListBox_Softwares_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() => checkedListBox_Softwares.ClearSelected()));
        }

        private void Tbl_ListaComputadores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
