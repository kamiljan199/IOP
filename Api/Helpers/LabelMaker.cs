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
    public class LabelMaker
    {

        public void MakeLabel(string filePath, string message)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(message, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            using (FileStream fs = File.Create(filePath))
            {
                qrCodeImage.Save(fs, ImageFormat.Png);
            }
        }
    }
}
