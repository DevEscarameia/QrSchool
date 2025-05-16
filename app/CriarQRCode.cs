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

        public void GerarQRCode(string textData)
        {
            // Cria um objeto QRCodeGenerator
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // Cria um QRCodeData com os dados do texto
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textData, QRCodeGenerator.ECCLevel.Q);

            // Cria um QRCode usando o QRCodeData
            QRCode qrCode = new QRCode(qrCodeData);

            // Cria uma imagem do QRCode
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Mostra a imagem na PictureBox
            pictureBox.Image = qrCodeImage;
        }
    }

}
