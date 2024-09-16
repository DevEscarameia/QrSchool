using QRCoder;
using System.Drawing;
using System.Windows.Forms;

namespace app
{
    public class CriarQRCode
    {
        private PictureBox pictureBox;

        // Adicione um construtor para passar a PictureBox
        public CriarQRCode(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void GerarQRCode(string textData, string outputFilePath)
        {
            // Incluir o caminho da imagem no texto do QRCode
            string textDataWithImage = $"{textData}";

            // Criar um objeto QRCodeGenerator
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // Criar um QRCodeData com os dados do texto
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textDataWithImage, QRCodeGenerator.ECCLevel.Q);

            // Criar um QRCode usando o QRCodeData
            QRCode qrCode = new QRCode(qrCodeData);

            // Criar uma imagem do QRCode
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Exibir a imagem na PictureBox
            pictureBox.Image = qrCodeImage;

            // Salvar a imagem resultante
            qrCodeImage.Save(outputFilePath);
        }
    }
}
