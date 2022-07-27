using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using Path = System.IO.Path;
using Word = Microsoft.Office.Interop.Word;

namespace up_pr11
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            RichTextBox_Text.Document.Blocks.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "RichText Files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd);
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                        doc.Load(fs, DataFormats.Rtf);
                    else if (Path.GetExtension(ofd.FileName).ToLower() == ".txt")
                        doc.Load(fs, DataFormats.Text);
                    else
                        doc.Load(fs, DataFormats.Xaml);
                }
            }
        }

        private void MenuItem_Save_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
            if (sfd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd);
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    if (Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                        doc.Save(fs, DataFormats.Rtf);
                    else if (Path.GetExtension(sfd.FileName).ToLower() == ".txt")
                        doc.Save(fs, DataFormats.Text);
                    else
                        doc.Save(fs, DataFormats.Xaml);
                }
            }
        }

        private void MenuItem_Open_Win1251_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Текстовые файлы (*.txt) | *.txt";
            openFileDialog1.ShowDialog();
            var text = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
            RichTextBox_Text.AppendText(text.ReadToEnd());
            text.Close();
        }

        private void MenuItem_Open_RTF_Click(object sender, RoutedEventArgs e)
        {
            RichTextBox_Text.Document.Blocks.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "RichText Files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd);
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                        doc.Load(fs, DataFormats.Rtf);
                }
            }
        }

        private void MenuItem_Open_Binaron_Format_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Файлы USP|*.usp|Text files(*.txt)|*.txt|All files(*.*)|*.*";
            var text = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
            text.Close();
            var textBin = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
            string textBin2 = textBin.ReadToEnd();
            StringBuilder sb = new StringBuilder();

            foreach (char c in textBin2.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            RichTextBox_Text.AppendText(sb.ToString());
        }

        private void MenuItem_Open_Binary_File_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Файлы USP|*.usp|Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            var textBin = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
            RichTextBox_Text.AppendText(textBin.ReadToEnd());
        }

        private void MenuItem_Save_RTF_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Файлы RTF (*.RTF) |  *.RTF";
            if (sfd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd);
                using (FileStream fs = File.Create(sfd.FileName))
                {

                    doc.Save(fs, DataFormats.Rtf);
                }
            }
        }

        private void MenuItem_Save_Win1251_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = sfd.Filter = "Текстовые файлы (*.txt) | *.txt";
            if (sfd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd);
                string str = doc.Text;

                File.WriteAllText(sfd.FileName, str, Encoding.GetEncoding(1251));
            }
        }

        private void MenuItem_Save_Binaron_Format_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "USP|*usp|Text files(*.txt)|*.txt|All files(*.*)|*.*";
            var texts = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd).Text;
            StringBuilder sb = new StringBuilder();

            foreach (char c in texts)
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            saveFileDialog1.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());
        }

        private void MenuItem_Save_Binary_File_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "USP|*usp|Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (sfd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd);

                string str = doc.Text;
                File.WriteAllText(sfd.FileName, str, Encoding.GetEncoding(1251));
            }
        }

        private void MenuItem_Print_Out_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();

            if ((pd.ShowDialog() == true))
            {
                pd.PrintVisual(RichTextBox_Text as Visual, "Print Visual");

                pd.PrintDocument((((IDocumentPaginatorSource)RichTextBox_Text.Document).DocumentPaginator), "Print Document");
            }
        }

        private void MenuItem_Open_UTF8_Click(object sender, RoutedEventArgs e)
        {
            RichTextBox_Text.Document.Blocks.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ofd.Filter = "Unicode Text (*.txt)|*.txt |All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd);

                var text = new System.IO.StreamReader(ofd.FileName, Encoding.GetEncoding(1200));
                doc.Text = text.ReadToEnd();
            }
        }

        private void MenuItem_Save_UTF8_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = sfd.Filter = "Unicode Text (*.txt)|*.txt |All files (*.*)|*.*";
            if (sfd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTextBox_Text.Document.ContentStart, RichTextBox_Text.Document.ContentEnd);
                string str = doc.Text;

                File.WriteAllText(sfd.FileName, str, Encoding.UTF8);
            }
        }
    }
}


