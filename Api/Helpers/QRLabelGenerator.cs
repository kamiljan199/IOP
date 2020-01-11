using Data.Context;
using QRCoder;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Api.Helpers
{
    public class QRLabelGenerator
    {

        public void MakeLabel(string filePath, string message)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(message, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            System.Drawing.Image qrCodeBitmap = qrCode.GetGraphic(20);


            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            if (fs != null)
            {
                iTextSharp.text.Rectangle rec = new iTextSharp.text.Rectangle(PageSize.A4);
                Document doc = new Document(rec);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                doc.Add(new Paragraph("Hello world!"));
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(qrCodeBitmap, new BaseColor(0,0,0,0));
                img.ScaleToFit(250f, 250f);

                doc.Add(img);
                
                
                doc.Close();
            }
            fs.Close();
        }
    }
}
