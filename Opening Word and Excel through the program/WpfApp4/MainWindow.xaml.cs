using System;
using System.Collections.Generic;
using System.Linq;
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
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_word(object sender, RoutedEventArgs e)
        {
            Word.Application word_app = new Word.Application();

            word_app.Visible = true;

            object missing = Type.Missing;
            Word.Document word_doc = word_app.Documents.Add(Visible: true);

            object obekt1 = 0;
            object obekt2 = 0;

            Word.Range range = word_doc.Range(ref obekt1, ref obekt2);

            range.InsertBefore("Известные поэты России");
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;
            range.InsertParagraphAfter();
            range.InsertParagraphAfter();
            range.SetRange(range.End, range.End);
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;
            range.Tables.Add(word_doc.Paragraphs[2].Range, 10, 2, ref missing, ref missing);

            Word.Table table = word_doc.Tables[1];
            table.Range.Font.Size = 12;
            table.Range.Font.Name = "Times New Roman";
            table.Columns.DistributeWidth();

            table.Cell(1, 1).Range.Text = "А. С. ПУШКИН (годы жизни поэта 1799 — 1837)";
            table.Cell(1, 2).Range.Text = "«Руслан и Людмила», «Кавказский пленник», Бахчисарайский фонтан»";

            table.Cell(2, 1).Range.Text = "М. Ю. ЛЕРМОНТОВ (годы жизни поэта 1814 — 1841)";
            table.Cell(2, 2).Range.Text = " «Дума», <<Парус>>, <<Русалка>>";

            table.Cell(3, 1).Range.Text = "Н. А. НЕКРАСОВ (Годы жизни поэта 1821 - 1878)";
            table.Cell(3, 2).Range.Text = "<<Русские женщины>> (1871 - 1872) и <<Кому на Руси жить хорошо>> (1866 - 1867)";

            table.Cell(4, 1).Range.Text = "К. Д. БАЛЬМОНТ (Годы жизни поэта 1867 —1942)";
            table.Cell(4, 2).Range.Text = "Под северным небом (1894)";

            table.Cell(5, 1).Range.Text = "Б. Л. ПАСТЕРНАК (Годы жизни поэта 1890 — 1960)";
            table.Cell(5, 2).Range.Text = "«Доктор Живаго»";

            table.Cell(6, 1).Range.Text = "А. А. БЛОК (годы жизни 1880 — 1921)";
            table.Cell(6, 2).Range.Text = "«Двенадцать»";

            table.Cell(7, 1).Range.Text = "И. А. БУНИН (Годы жизни поэта 1870 — 1953)";
            table.Cell(7, 2).Range.Text = "«Избранные стихи»";

            table.Cell(8, 1).Range.Text = "А. А. АХМАТОВА (годы жизни поэта 1889 — 1966)";
            table.Cell(8, 2).Range.Text = "«Вечер»";

            table.Cell(9, 1).Range.Text = "С. А. ЕСЕНИН (Годы жизни поэта 1895 — 1925)";
            table.Cell(9, 2).Range.Text = "«Исповедь хулигана», «Черный человек» ";

            table.Cell(10, 1).Range.Text = "В. В. МАЯКОВСКИЙ (Годы жизни поэта 1893 — 1930)";
            table.Cell(10, 2).Range.Text = "«Про это», «Владимир Ильич Ленин», поэма «Хорошо!»";
            table.Borders.Enable = 1;

        }

        private void Button_excel(object sender, RoutedEventArgs e)
        {
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            //Отобразить Excel
            ex.Visible = true;
            //Количество листов в рабочей книге
            ex.SheetsInNewWorkbook = 2;
            //Добавить рабочую книгу
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            //Отключить отображение окон с сообщениями
            ex.DisplayAlerts = false;
            //Получаем первый лист документа (счет начинается с 1)
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            //Название листа (вкладки снизу)
            sheet.Name = "Числа";
            //Пример заполнения ячеек
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j < 9; j++)
                    sheet.Cells[i, j] = String.Format("Boom {0} {1}", i, j);
            }
            //Захватываем диапазон ячеек
            Excel.Range range1 = sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[9, 9]);
            //Шрифт для диапазона
            range1.Cells.Font.Name = "Tahoma";
            //Размер шрифта для диапазона
            range1.Cells.Font.Size = 10;
            //Захватываем другой диапазон ячеек
            Excel.Range range2 = sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[9, 2]);
            range2.Cells.Font.Name = "Times New Roman";
            
        }
    }
}

