using Data.Context;
using QRCoder;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Model.Models;

namespace Api.Helpers
{
    public class QRLabelGenerator
    {
        private string QRMessage;
        private Parcel referencedParcel;

        private static string fontPath = @"Api\\Helpers\\Pdf\\calibri.ttf";
        private static Font headerFont = FontFactory.GetFont(fontPath, BaseFont.CP1257, true, 10, Font.BOLD);
        private static Font textFont = FontFactory.GetFont(fontPath, BaseFont.CP1257, true, 10, Font.NORMAL);
        public void MakeLabel(string filePath, string message, Parcel parcelToSend)
        {
            QRMessage = message;
            referencedParcel = parcelToSend;
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            if (fs != null)
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                PdfPTable table = new PdfPTable(new float[] { 100f, 100f});
                generateTable(table);
                doc.Add(table);
                doc.Close();
            }
            fs.Close();
        }

        private void SetCellAttributes(PdfPCell cell)
        {
            //cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            //cell.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
            //cell.BorderColor = BaseColor.LIGHT_GRAY;
            //cell.BorderWidthBottom = 1.0f;
            cell.Padding = 6.0f;
        }

        private void generateTable(PdfPTable tab)
        {
            Image img = Image.GetInstance(generateQRCodeImage(), new BaseColor(0, 0, 0, 0));
            img.ScaleToFit(100f, 100f);
            PdfPCell sticker = new PdfPCell(img);
            SetCellAttributes(sticker);
            sticker.Rowspan = 2;
            sticker.HorizontalAlignment = Element.ALIGN_CENTER;
            tab.AddCell(sticker);

            
            PdfPCell receiver = new PdfPCell(new Phrase("ODBIORCA", headerFont));
            receiver.HorizontalAlignment = Element.ALIGN_CENTER;
            SetCellAttributes(receiver);
            tab.AddCell(receiver);

            PdfPCell receiverAddress = new PdfPCell(new Phrase("Rucham ci starą lol", textFont));
            SetCellAttributes(receiverAddress);
            tab.AddCell(receiverAddress);
        }

        private System.Drawing.Image generateQRCodeImage()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRMessage, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
    }
}
