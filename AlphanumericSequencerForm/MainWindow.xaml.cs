using AlphanumericSequencerCore;
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

namespace AlphanumericSequencerForm
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var initialValue = txtOriginValue.Text;
            var iterationsValue = Convert.ToInt32(txtAmountOfValues.Text);
            lstAlphanumericsValues.Items.Clear();
            lstAlphanumericsValues.Items.Add(initialValue);
            for (int i = iterationsValue - 2; i >= 0; i--)
            {
                var value = AlphanumericIncrement.Increment(initialValue, AlphanumericIncrement.Mode.AlphaNumeric);
                lstAlphanumericsValues.Items.Add(value);
                initialValue = value;
            }
        }

        private void txtOriginValue_GotFocus(object sender, RoutedEventArgs e)
        {
            txtOriginValue.SelectAll();
        }

        private void txtAmountOfValues_GotFocus(object sender, RoutedEventArgs e)
        {
            txtAmountOfValues.SelectAll();
        }
    }
}
