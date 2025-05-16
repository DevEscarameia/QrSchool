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
    public partial class NovoComputadores : Form
    {
        private Form1 mainForm;

        public NovoComputadores(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;

        }
        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
        }
        private void EditarComputadores_Load(object sender, EventArgs e)
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
        private void btn_EditarPc_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarComputadores(mainForm));
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            // Verificar se a descrição está vazia
            if (string.IsNullOrWhiteSpace(txt_descrição.Text))
            {
                MessageBox.Show("Preencha a descrição do computador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            string softwaresFinal = string.Join(", ", softwaresSelecionados);

            // Criar objeto Computador
            Computador novoComputador = new Computador()
            {
                T_DESCRIÇÃO = txt_descrição.Text.Trim(),
                T_SOFTWARES = softwaresFinal,
                B_ESTADO = true
            };

            // Adicionar no banco de dados
            Banco.NovoComputador(novoComputador);

            mostrarNotificaçao("SUCESSO", "Computador adicionado com sucesso!");

            // Atualizar a DataGridView
            Tbl_ListaComputadores.DataSource = Banco.TodosComputadores();
            Tbl_ListaComputadores.Refresh();

            // Limpar os campos
            txt_descrição.Text = string.Empty;
            txt_Outros.Text = string.Empty;
            for (int i = 0; i < checkedListBox_Softwares.Items.Count; i++)
            {
                checkedListBox_Softwares.SetItemChecked(i, false);
            }

            txt_descrição.Focus(); // Coloca o cursor na TextBox


        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            // Limpar os campos de texto
            txt_descrição.Text = string.Empty;
            txt_Outros.Text = string.Empty;

            // Desmarcar todos os itens da CheckedListBox
            for (int i = 0; i < checkedListBox_Softwares.Items.Count; i++)
            {
                checkedListBox_Softwares.SetItemChecked(i, false);
            }

            // Focar no primeiro campo para facilitar a entrada de novos dados
            txt_descrição.Focus();
        }

        private void checkedListBox_Softwares_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() => checkedListBox_Softwares.ClearSelected()));
        }

        private void txt_Outros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
