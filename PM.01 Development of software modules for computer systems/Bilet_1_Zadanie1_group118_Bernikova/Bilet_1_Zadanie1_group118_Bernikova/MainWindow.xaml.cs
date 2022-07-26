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
using System.Threading;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;


namespace Bilet_1_Zadanie1_group118_Bernikova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string CppFunctionDLL = @"..\..\..\Debug\Dll1.dll";
        [DllImport(CppFunctionDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Knowledge(int Rates, int amount);
        [DllImport(CppFunctionDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Count(int rate);

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {             
                //Генирация студентов
                window_result.Text = "";
                List<Student> students = new List<Student>();
                string stroka = Create_Rate();
                Student student1 = new Student("Берникова", stroka);
                students.Add(student1);
                stroka = Create_Rate();
                Student student2 = new Student("Александрова", stroka);
                students.Add(student2);
                Student student3 = new Student("Дармаева", stroka);
                students.Add(student3);
                stroka = Create_Rate();
                Student student4 = new Student("Троицкая", stroka);
                students.Add(student4);
                stroka = Create_Rate();
                Student student5 = new Student("Неумоина", stroka);
                students.Add(student5);
                int count = 0;
                double sr_rate = 0;
                foreach (Student student in students)
                {
                    student.Output(window_result);
                    window_result.Text += "\n";
                    int[] temp = new int[student.Get_Rate().Count];
                    for (int i = 0; i < student.Get_Rate().Count; i++)
                    {
                        count += Count(student.Get_Rate()[i]);
                    }
                    sr_rate += student.sr_ocen();
                }
                window_result.Text += "Качество знаний: " + Knowledge(count, students.Count) + "%\n";
                window_result.Text += "Средняя оценка всех студентов: " + sr_rate / students.Count;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка заполения или вывода студентов", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Случайная генерация оценок
        string Create_Rate()
        {
            string stroka = "";
            try
            {
                Thread.Sleep(20);
                Random random = new Random((int)DateTime.Now.Ticks);
                int[] temp = new int[random.Next(1, 11)];//от 2 до 11 невключительно (от 1 до 10)
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = random.Next(2, 6);        //от 2 до 6 невключительно (от 2 до 5)
                    if (i < temp.Length - 1)
                        stroka += temp[i] + ",";
                    else
                        stroka += temp[i];
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка создания оценки", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return stroka;
        }
        //Сохранение данных в файл
        private void Save_click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Text file (*.txt)|*.txt";
                if (dialog.ShowDialog() == true)
                {
                    File.WriteAllText(dialog.FileName, window_result.Text);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл", "Внимание", MessageBoxButton.OK);
            }
        }
    }
    //Класс студент
    public class Student
    {
        //Приватные переменные
        private string _Last_name;
        private List<int> _Rate = new List<int>();

        public List<int> Get_Rate() => _Rate;
        //Конструкторы класса вида(название_класса(фамилия)
        public Student(string Lastname)
        {
            try
            {
                _Last_name = Lastname;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка ввода фамилии", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Конструкторы класса вида(название_класса(фамилия, оценки))
        public Student(string lastname, string Rate)
        {
            try
            {
                _Last_name = lastname;
                string[] temp = Rate.Split(',');
                for (int i = 0; i < temp.Length; i++)
                {
                    _Rate.Add(Convert.ToInt32(temp[i]));
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка ввода фамилии или оценок", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Вывод данных на экран
        public void Output(TextBox textBox)
        {
            try
            {
                textBox.Text += _Last_name + " ";
                for (int i = 0; i < _Rate.Count; i++)
                {
                    if (i < _Rate.Count - 1)
                        textBox.Text += _Rate[i] + ", ";
                    else
                        textBox.Text += _Rate[i];
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка вывода результата", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Нахождение средней оценки всех студентов
        public double sr_ocen()
        {
            int summ = 0;
            foreach (int _Rate in _Rate)
            {
                summ += _Rate;
            }
            int result = 0;
            if (_Rate.Count > 0)
            {
                result = summ / _Rate.Count;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}
