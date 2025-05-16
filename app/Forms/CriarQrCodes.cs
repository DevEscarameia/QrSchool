using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ZXing;
using PdfiumViewer;


namespace app.Forms
{
    public partial class CriarQrCodes: Form
    {
        public CriarQrCodes()
        {
            InitializeComponent();

        }

  

        private void CriarQrCodes_Load(object sender, EventArgs e)
        {
            // Desabilitar a seleção de linha
            Tbl_ListaComputadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // ou None para evitar a seleção de linhas
            Tbl_ListaComputadores.DataSource = Banco.TodosComputadoresSelecionar();
            // Adicionar a coluna booleana de seleção antes de carregar os dados
            if (!Tbl_ListaComputadores.Columns.Contains("Selecionar"))
            {
                DataGridViewCheckBoxColumn selecionarColuna = new DataGridViewCheckBoxColumn();
                selecionarColuna.Name = "Selecionar";
                selecionarColuna.HeaderText = "Selecionar";
                selecionarColuna.Width = 50;
                Tbl_ListaComputadores.Columns.Add(selecionarColuna);
            }

            // Carregar dados na grid


            // Permitir que a coluna de checkbox seja editável
            foreach (DataGridViewColumn coluna in Tbl_ListaComputadores.Columns)
            {
                if (coluna.Name == "Selecionar")
                {
                    coluna.ReadOnly = false; // Permitir edição apenas na coluna de checkbox
                }
                else
                {
                    coluna.ReadOnly = true; // Deixar as outras colunas somente leitura
                }
            }

        }

        private void Tbl_ListaComputadores_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (Tbl_ListaComputadores.CurrentCell is DataGridViewCheckBoxCell)
            {
                Tbl_ListaComputadores.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void Tbl_ListaComputadores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Garantir que a mudança ocorreu na coluna de checkbox
            if (e.ColumnIndex == Tbl_ListaComputadores.Columns["Selecionar"].Index && e.RowIndex >= 0)
            {
                bool isChecked = Convert.ToBoolean(Tbl_ListaComputadores.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                Console.WriteLine($"Linha {e.RowIndex}: Checkbox = {isChecked}");
            }
        }

        private void Tbl_ListaComputadores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btn_CriarQrcodes_Click(object sender, EventArgs e)
        {
            try
            {
                List<Bitmap> qrImages = new List<Bitmap>(); // Lista para armazenar as imagens dos QR Codes

                foreach (DataGridViewRow row in Tbl_ListaComputadores.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Selecionar"] as DataGridViewCheckBoxCell;

                    // Verifica se a checkbox está marcada
                    if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string textData = row.Cells[1].Value.ToString();
                            qrImages.Add(GerarQRCode(textData));
                        }
                    }
                }

                if (qrImages.Count > 0)
                {
                    string pdfPath = Path.Combine(Application.StartupPath, "QRCodes.pdf");
                    CriarPDF(qrImages, pdfPath);
                    MostrarNoPDFium(pdfPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar QR Codes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Função para gerar QR Code e retornar como Bitmap
        private Bitmap GerarQRCode(string textData)
        {
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 150,
                    Width = 150,
                    Margin = 2
                }
            };

            return writer.Write(textData);
        }
        // Função para criar um PDF com os QR Codes
        // Função para criar um PDF com os QR Codes
        // Função para criar um PDF com os QR Codes
        private void CriarPDF(List<Bitmap> qrCodes, string pdfPath)
        {
            try
            {
                // Fecha o documento no pdfViewer1 antes de criar um novo PDF
                if (pdfViewer1.Document != null)
                {
                    pdfViewer1.Document.Dispose();
                    pdfViewer1.Document = null;
                }

                // Garante que o ficheiro não está bloqueado antes de recriá-lo
                if (File.Exists(pdfPath))
                {
                    File.Delete(pdfPath);
                }

                using (FileStream stream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, stream);
                    document.Open();

                    int colunasPorLinha = 4; // Definir o número de QR Codes por linha
                    float tamanhoQRCode = 100f; // Define o tamanho do QR Code
                    PdfPTable tabela = new PdfPTable(colunasPorLinha);
                    tabela.WidthPercentage = 100; // Usa a largura total da página
                    tabela.DefaultCell.Border = PdfPCell.NO_BORDER; // Remove bordas

                    int contador = 0;

                    foreach (DataGridViewRow row in Tbl_ListaComputadores.Rows)
                    {
                        // Verificar se a checkbox está marcada
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells["Selecionar"] as DataGridViewCheckBoxCell;
                        if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                        {
                            // Gerar o QR Code
                            string textData = row.Cells[1].Value.ToString();
                            Bitmap qrCode = GerarQRCode(textData);

                            // Criar a célula interna para o QR Code e o texto abaixo
                            PdfPTable celulaInterna = new PdfPTable(1); // Uma célula interna com uma coluna

                            // Adicionar o QR Code na célula interna
                            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(qrCode, System.Drawing.Imaging.ImageFormat.Png);
                            image.ScaleAbsolute(tamanhoQRCode, tamanhoQRCode);
                            PdfPCell imageCell = new PdfPCell(image)
                            {
                                Border = PdfPCell.NO_BORDER,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE
                            };
                            celulaInterna.AddCell(imageCell);

                            // Adicionar o texto abaixo do QR Code na célula interna
                            PdfPCell textCell = new PdfPCell(new Paragraph(textData))
                            {
                                Border = PdfPCell.NO_BORDER,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_TOP,
                                PaddingTop = 5f,
                                FixedHeight = 20f
                            };
                            celulaInterna.AddCell(textCell);

                            // Adicionar a célula interna à célula principal da tabela
                            PdfPCell cell = new PdfPCell(celulaInterna)
                            {
                                Border = PdfPCell.NO_BORDER,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE
                            };
                            tabela.AddCell(cell);

                            contador++;

                            // Se a linha estiver completa e ainda houver mais QR Codes, força uma nova linha
                            if (contador % colunasPorLinha == 0)
                            {
                                document.Add(tabela);
                                tabela = new PdfPTable(colunasPorLinha); // Cria uma nova tabela para evitar problemas
                                tabela.WidthPercentage = 100;
                                tabela.DefaultCell.Border = PdfPCell.NO_BORDER;
                            }
                        }
                    }

                    // Adiciona os QR Codes restantes, mesmo que a linha não esteja completa
                    if (contador % colunasPorLinha != 0)
                    {
                        int faltando = colunasPorLinha - (contador % colunasPorLinha);
                        for (int i = 0; i < faltando; i++)
                        {
                            tabela.AddCell(new PdfPCell(new Paragraph("")) { Border = PdfPCell.NO_BORDER });
                        }
                        document.Add(tabela);
                    }

                    document.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        // Função para exibir o PDF no PDFium
        private void MostrarNoPDFium(string pdfPath)
        {
            try
            {
                if (pdfViewer1.Document != null)
                {
                    pdfViewer1.Document.Dispose(); // Fecha o documento anterior para evitar conflitos
                }

                pdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfPath); // Carrega o novo PDF
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pdfViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CriarQrCodes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pdfViewer1.Document != null)
            {
                pdfViewer1.Document.Dispose();
                pdfViewer1.Document = null;
            }
        }

        private void btn_todas_Click(object sender, EventArgs e)
        {
            bool existePeloMenosUmaDesmarcada = false;

            // Verifica se há pelo menos uma checkbox desmarcada
            foreach (DataGridViewRow row in Tbl_ListaComputadores.Rows)
            {
                if (row.Cells["Selecionar"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    if (!(checkBoxCell.Value is bool marcada) || !marcada)
                    {
                        existePeloMenosUmaDesmarcada = true;
                        break;
                    }
                }
            }

            // Define o novo estado (true se havia pelo menos uma desmarcada, false caso contrário)
            bool novoEstado = existePeloMenosUmaDesmarcada;

            // Aplica o novo estado a todas as linhas
            foreach (DataGridViewRow row in Tbl_ListaComputadores.Rows)
            {
                if (row.Cells["Selecionar"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    checkBoxCell.Value = novoEstado;
                }
            }
        }
    }
}

