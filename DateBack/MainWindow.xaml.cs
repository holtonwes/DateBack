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

namespace DateBack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = (DateTime) StartingDatePicker.SelectedDate;
            int.TryParse(DaysAddSubtractTextBox.Text, out int daystoAddandSubtract);
            var addDays = AddDays(selectedDate, daystoAddandSubtract);
            var subtractDays = SubtractDays(selectedDate, daystoAddandSubtract);

            string message = $"You selected: {selectedDate}.\nIn {daystoAddandSubtract} day(s), it will be: {addDays}.\nIt was {subtractDays} {daystoAddandSubtract} day(s) ago.";

            ResultsLabel.Content = message;
        }

        public DateTime AddDays(DateTime startDate, int daysToAdd)
        {
            DateTime newDate = startDate.AddDays(daysToAdd);
            return newDate;
        }

        public DateTime SubtractDays(DateTime startDate, int daysToSubtract)
        {
            DateTime newDate = startDate.AddDays(daysToSubtract * -1);
            return newDate;
        }
    }
}
