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

namespace Assignment04_Adriano_Melquiades {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            BtnCalculate.Click += CalculateBMI;
            BtnCalculate.Content = "something elese";

        }
        //Event handler for Calculate button
        private void CalculateBMI(object sender, EventArgs e) {
            string gender = txtGender.Text;
            string age = txtAge.Text;
            string height = txtHeight.Text;
            string weight = txtWeight.Text;


            if (string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(height) || string.IsNullOrWhiteSpace(weight)) {
                MessageBox.Show("Please, input all the required info.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }








        }










    }

}
