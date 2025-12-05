using System;
using System.IO;
using QRCoder;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Foydalanish:");
            Console.WriteLine("  dotnet run -- \"Matn yoki URL\" output.png");
            Console.WriteLine("  dotnet run -- -f text.txt output.png");
            return;
        }

        string data = "";
        string outputFile = "qr.png";

        if (args[0] == "-f")
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Foydalanish: dotnet run -- -f text.txt out.png");
                return;
            }

            string filePath = args[1];

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Fayl topilmadi: " + filePath);
                return;
            }

            data = File.ReadAllText(filePath).Trim();
            outputFile = args[2];
        }
        else
        {
            data = args[0];
            if (args.Length >= 2)
                outputFile = args[1];
        }

        GenerateQR(data, outputFile);
    }

    static void GenerateQR(string text, string filePath)
    {
        QRCodeGenerator qrGen = new QRCodeGenerator();
        QRCodeData qrData = qrGen.CreateQrCode(text, QRCodeGenerator.ECCLevel.M);
        PngByteQRCode qrCode = new PngByteQRCode(qrData);

        byte[] png = qrCode.GetGraphic(10);

        File.WriteAllBytes(filePath, png);
        Console.WriteLine("Saqlangan: " + filePath);
    }
}
