using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorMenu_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            { 
                BackColor= dlg.Color;
            }
        }

        private void FontMenu_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Fontexm.Font = dlg.Font;
                Fontexm.ForeColor = dlg.Color;
            }
        }

        private void PrintMenu_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            dlg.Document = printDoc;
            dlg.AllowSelection = true;
            dlg.AllowSomePages = true;
            if (dlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(XtextBox.Text);
                int slag = Int32.Parse(slagtxt.Text);
                int pow = 2;
                int del = 1;
                double result = 0;
                for (int i = 0; i < slag; i++)
                {
                    if (i % 2 == 0 || i != 1)
                        result += Math.Pow(x, pow) / (del * (del + 2));
                    else
                        result -= Math.Sin(Math.Pow(x, pow)) / (del * (del + 2));
                    pow += 2;
                    del += 2;
                }
                res.Text = Math.Round(result, 4).ToString();
            } catch { MessageBox.Show("Введите все данные"); }
        }
    }
}
