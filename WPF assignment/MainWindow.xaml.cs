using System.Windows;

namespace WpfDataBindingExample
{
    public partial class MainWindow : Window
    {
        public Person MyPerson { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MyPerson = new Person();
            MyPerson.Name = "Fatiq"; // Initial name
            DataContext = this;
        }
    }
}
