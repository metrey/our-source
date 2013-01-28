using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace PriintKhmerUnicode
{
    static class Program
    {
        static PrintDocument printDoc = new PrintDocument();
        static Font font = new Font("Kh System", 16);
        static string text = "你好";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            BindPrintPageEvent();
            Preview();
        }

        private static void BindPrintPageEvent()
        {
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        private static void Preview()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = printDoc;
            dialog.ShowDialog();
        }

        static void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(text, font, Brushes.Black, 100.0F, 100.0F);
        }
    }
}
