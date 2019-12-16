using Data.Context;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.IO;
using System.Drawing.Imaging;


namespace Api.Helpers
{
    public static class QRLabelGenerator
    {
        public static void MakeLabel(string filePath)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("Blablabla", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            using (FileStream fs = File.Create(filePath))
            {
                qrCodeImage.Save(fs, ImageFormat.Png);
            }
        }
    }
}
