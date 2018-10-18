using DesktopLaby.Models;
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

namespace DesktopLaby
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Person()
            {
                Name = "Elo",
                SurName = "Ziom",
                BirthDate = DateTime.Now
            });
            PeopleList.ItemsSource = People;

        }

        public ObservableCollection<Person> People {
            get
            {
                return people;
            }
        }

        public void AddPersonButton_Click(object sender, RoutedEventArgs e)
        {
            ValidationMessage.Text = "";

            if (ValidatePersonInput())
            {
                people.Add(new Person()
                {
                    Name = NameBox.Text,
                    SurName = SurnameBox.Text,
                    BirthDate = (DateTime)DatePicker.SelectedDate
                });
            }
            else
            {
                ValidationMessage.Text = "Wrong input";
            }
        }

        public void ClearInputButton_Click(object sender, RoutedEventArgs e)
        {
            DatePicker.SelectedDate = null;
            NameBox.Text = null;
            SurnameBox.Text = null;
        }
        private bool ValidatePersonInput()
        {
            if(DatePicker.SelectedDate != null 
                && NameBox.Text != null
                && SurnameBox.Text != null)
            {
                return true;
            }
            return false;
        }
    }
}
