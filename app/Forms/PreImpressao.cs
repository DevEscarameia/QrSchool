using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PdfiumViewer;

namespace app.Forms
{
    public partial class PreImpressao : Form
    {
        private Form1 mainForm;
        private MemoryStream pdfStream;
        private PdfViewer pdfViewer;

        // O construtor agora aceita um array de bytes contendo o PDF
        public PreImpressao(Form1 form1, byte[] pdfBytes)
        {
            InitializeComponent();
            mainForm = form1;

            // Criar o MemoryStream a partir dos bytes do PDF
            pdfStream = new MemoryStream(pdfBytes);

            // Criar e configurar o PdfViewer
            pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill, // Ajusta ao painel
                Document = PdfDocument.Load(pdfStream) // Carrega o documento
            };

            // Adicionar o PdfViewer ao painel
            panelPdfium.Controls.Add(pdfViewer);
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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            openChildForm(new ListaCartões(mainForm));
        }
    }
}
