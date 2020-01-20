using Data.Context;
using QRCoder;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Model.Models;

namespace Api.Helpers
{
    public static class QRLabelGenerator
    {
        private static string QRMessage;
        private static Parcel referencedParcel;

        private static BaseFont bfTimes = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1257, false);
        private static Font headerFont = new Font(bfTimes, 14, Font.BOLD);
        private static Font textFont = new Font(bfTimes, 12, Font.NORMAL);
        public static void MakeLabel(string filePath, Parcel parcelToSend)
        {
            referencedParcel = parcelToSend ?? throw new System.NullReferenceException();
            QRMessage = parcelToSend.Id.ToString();
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            if (fs != null)
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                PdfPTable table = new PdfPTable(new float[] { 250f, 250f});
                GenerateTable(table);
                doc.Add(table);
                doc.Close();
            }
            fs.Close();
        }

        private static void SetDefaultCellAttributes(PdfPCell cell)
        {
            cell.Padding = 6.0f;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_CENTER;
        }

        private static void GenerateTable(PdfPTable tab)
        {
            AddQRCodeToTable( Image.GetInstance(GenerateQRCodeImage(), BaseColor.WHITE), tab );
            
            PdfPCell receiver = new PdfPCell(new Phrase("ODBIORCA", headerFont));
            SetDefaultCellAttributes(receiver);
            tab.AddCell(receiver);

            PdfPCell receiverAddress = new PdfPCell(new Phrase("\n\n" + PersonalDataToString(referencedParcel.ReceiverData), textFont));
            SetDefaultCellAttributes(receiverAddress);
            BorderNShape(receiverAddress);
            tab.AddCell(receiverAddress);

            PdfPCell parcelNumber = new PdfPCell(new Phrase("Nr przesyłki: " + referencedParcel.Id, textFont));
            SetDefaultCellAttributes(parcelNumber);
            BorderUShape(parcelNumber);
            tab.AddCell(parcelNumber);

            PdfPCell isReturned = new PdfPCell();
            if(referencedParcel.ReferenceId != 0)
            {
                isReturned = new PdfPCell(new Phrase("[x] Zwrot", textFont));
            }
            else
            {
                isReturned = new PdfPCell(new Phrase("[ ] Zwrot", textFont));
            }
            SetDefaultCellAttributes(isReturned);
            BorderUShape(isReturned);
            tab.AddCell(isReturned);

            PdfPCell gauge = new PdfPCell(new Phrase("Typ paczki: " + referencedParcel.ParcelType, textFont));
            SetDefaultCellAttributes(gauge);
            BorderNShape(gauge);
            tab.AddCell(gauge);

            PdfPCell sender = new PdfPCell(new Phrase("NADAWCA", headerFont));
            SetDefaultCellAttributes(sender);
            tab.AddCell(sender);

            PdfPCell size = new PdfPCell(new Phrase(SizeToString() + referencedParcel.ParcelWeight.ToString("F1") + " kg\n", textFont));
            SetDefaultCellAttributes(size);
            BorderUShape(size);
            tab.AddCell(size);

            PdfPCell senderAddress = new PdfPCell(new Phrase(PersonalDataToString(referencedParcel.SenderData), textFont));
            SetDefaultCellAttributes(senderAddress);
            tab.AddCell(senderAddress);
        }

        private static void BorderNShape(PdfPCell cell)
        {
            cell.Border = Rectangle.NO_BORDER;
            cell.Border = Rectangle.LEFT_BORDER + Rectangle.RIGHT_BORDER + Rectangle.TOP_BORDER;
        }

        private static void BorderUShape(PdfPCell cell)
        {
            cell.Border = Rectangle.NO_BORDER;
            cell.Border = Rectangle.BOTTOM_BORDER + Rectangle.LEFT_BORDER + Rectangle.RIGHT_BORDER;
        }

        private static System.Drawing.Image GenerateQRCodeImage()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRMessage, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }

        private static void AddQRCodeToTable(Image img, PdfPTable tab)
        {
            img.ScaleToFit(150f, 150f);
            PdfPCell sticker = new PdfPCell(img);
            SetDefaultCellAttributes(sticker);
            sticker.Rowspan = 2;
            sticker.Border = Rectangle.NO_BORDER;
            sticker.Border = Rectangle.LEFT_BORDER + Rectangle.RIGHT_BORDER + Rectangle.TOP_BORDER;
            tab.AddCell(sticker);
        }


        private static string PersonalDataToString(PersonalData data)
        {
            string temp = data.FirstName + " " + data.LastName + "\n";
            temp += AddressToString(data.PersonalAddress);
            temp += "\nNr telefonu: " + data.PhoneNumber + "\n";
            return temp;
        }

        private static string AddressToString(Address address)
        {
            string temp = "ul. " + address.Street + " " + address.HomeNumber;
            if (address.ApartmentNumber != 0)
            {
                temp += "/" + address.ApartmentNumber + "\n";
            }
            else
            {
                temp += "\n";
            }
            temp += address.PostCode + " " + address.City + "\n";
            return temp;
        }

        private static string SizeToString()
        {
            string temp = "Rozmiar: ";
            temp += referencedParcel.ParcelWidth.ToString("F1") + " x ";
            temp += referencedParcel.ParcelHeight.ToString("F1") + " x ";
            temp += referencedParcel.ParcelLength.ToString("F1") + " cm\n";
            return temp;
        }
    }
}
