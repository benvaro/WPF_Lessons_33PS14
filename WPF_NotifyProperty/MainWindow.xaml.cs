using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WPF_NotifyProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student st = new Student() { Name = "Ivan", LastName = "Ivanov" };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = st;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Student).Name = "Petro";
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private string name;

        public string Name{
            get { return name; }
            set { name = value;
                NotifyPropertyChanged("Name");
            }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
           //     NotifyPropertyChanged(nameof(LastName));
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));   
        }
    }

}
