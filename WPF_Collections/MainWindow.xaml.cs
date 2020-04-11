using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     //   List<string> list = new List<string>();
        ObservableCollection<string> list = new ObservableCollection<string>();
        ObservableCollection<Student> students = new ObservableCollection<Student>();
        public MainWindow()
        {
            InitializeComponent();
            string[] arr = { "Apple", "Berry", "Cherry", "Banana" };
            foreach (var item in arr)
            {
                list.Add(item);
            }
            listBox.ItemsSource = list;

            students.Add(new Student { LastName = "Petrov", Name = "Petro", Age=18 });
            students.Add(new Student { LastName = "Petrenko", Name = "Kostia", Age=20 });
            students.Add(new Student { LastName = "Fisher", Name = "Alex", Age=24 });
            students.Add(new Student { LastName = "Gates", Name = "Bill" });
            listBoxStudents.ItemsSource = students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add("New element");
            list[0] = "New one";
        }
    }
}
