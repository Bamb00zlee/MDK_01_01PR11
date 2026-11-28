using System.Windows;
using System.Windows.Controls;
using Overload_Патрушева.Classes;

namespace Overload_Патрушева
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentsRepo allstudents = new StudentsRepo();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void New_student_list()
        {
            forFIO.Clear();
            forListStudent.ItemsSource = allstudents.GetNames();
        }

        private void Get_list(object sender, RoutedEventArgs e)
        {
            string separator = forRazdelitel.Text;
            if (FIOSort.IsChecked == true)
            {
                allstudents.PrintNames(separator,true);
            }
            
        }

        private void Add_students(object sender, RoutedEventArgs e)
        {
            allstudents.AddName(forFIO.Text);
            MessageBox.Show($"студент: {forFIO.Text} добавлен");
            New_student_list();
        }

        private void Clear_list(object sender, RoutedEventArgs e)
        {
            // отчистка потому что добавление не напрямую
            forListStudent.ItemsSource = null;
        }
    }
}
