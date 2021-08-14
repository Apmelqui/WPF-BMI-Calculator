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
            BtnCalculate.MouseEnter += BtnMouseEnter;
            BtnCalculate.MouseLeave += BtnMouseLeave;

        }
        //Event handler for Calculate button
        private void CalculateBMI(object sender, EventArgs e) {

            if (string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtHeight.Text) 
                || string.IsNullOrWhiteSpace(txtWeight.Text)) {
                MessageBox.Show("Please, input all the required info.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            
            string gender = txtGender.Text;

            int age;
            if (!Int32.TryParse(txtAge.Text, out age)) {
                MessageBox.Show("Please, input the correct age.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            //TODO: mesma coisa acima
            double height = Convert.ToDouble(txtHeight.Text);
            double weight =Convert.ToDouble(txtWeight.Text);


            Create();
        }

        private void BtnMouseEnter(object sender, EventArgs e) {
            BtnCalculate.FontSize += 5;
        }


        private void BtnMouseLeave(object sender, EventArgs e) {
            BtnCalculate.FontSize -= 5;
        }



        private void BtnToTest_Click(object sender, RoutedEventArgs e) {
            labelTest.Content = "changed";
            labelTest.Foreground = Brushes.Green;
            labelTest.FontSize += 1;
        }

  
        private void Create() {
            //TODO
        }

        private void Read() {

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            
        }
    }

}
