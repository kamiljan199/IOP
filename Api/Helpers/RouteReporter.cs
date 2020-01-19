using System;
using iTextSharp.text;
using Model.Models;
using System.Diagnostics;
using System.IO;

namespace Api.Helpers
{
    public class RouteReporter
    {
        private Route route;

        public RouteReporter(Route route)
        {
            this.route = route;
        }

        public void GeneratePDF()
        {
            string path = String.Format(@"{0}\routereport.pdf", Environment.CurrentDirectory);

            try
            {
                var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                pdfDoc.Open();

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };

                pdfDoc.Add(spacer);

                var headerTable = new iTextSharp.text.pdf.PdfPTable(new[] { .75f, 2f })
                {
                    HorizontalAlignment = 1,
                    WidthPercentage = 75,
                    DefaultCell = {MinimumHeight = 22f}
                };

                headerTable.AddCell("Data");
                headerTable.AddCell(route.CreationDateTime.ToString());
                headerTable.AddCell("Nazwisko");
                headerTable.AddCell(route.Employee.Name + " " + route.Employee.Surname.ToString());
                headerTable.AddCell("Pojazd");
                headerTable.AddCell(route.Vehicle.Model.ToString() +" "+ route.Vehicle.Registration.ToString());

                pdfDoc.Add(headerTable);
                pdfDoc.Add(spacer);

                var columnCount = 2;
                var columnWidths = new[] { 0.75f, 3f };

                var table = new iTextSharp.text.pdf.PdfPTable(columnWidths)
                {
                    HorizontalAlignment = 1,
                    WidthPercentage = 80,
                    DefaultCell = {MinimumHeight = 22f},
                };

                var cell = new iTextSharp.text.pdf.PdfPCell(new Phrase("Podsumowanie"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 15f,
                };

                table.AddCell(cell);

                foreach (var point in route.RoutePoints )
                {
                    Address addr = point.Parcel.ReceiverData.PersonalAddress;
                    string addressText = string.Format("{0} {1}/{2}, {3}, {4}", addr.Street, addr.HomeNumber, addr.ApartmentNumber, addr.PostCode, addr.City);
                    table.AddCell(point.ParcelId.ToString());
                    table.AddCell(addressText);
                }

                pdfDoc.Add(table);

                pdfDoc.Close();
                
            }
            catch(iTextSharp.text.DocumentException dex)
            {

            }

            new Process
            {
                StartInfo = new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                }
            }.Start();
        }
    }
}
