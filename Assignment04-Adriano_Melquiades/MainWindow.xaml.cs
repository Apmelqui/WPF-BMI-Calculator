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
using static Assignment04_Adriano_Melquiades.BMIData;

namespace Assignment04_Adriano_Melquiades {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            //BtnCalculate.Click += CalculateBMI;
            BtnCalculate.MouseEnter += BtnMouseEnter;
            BtnCalculate.MouseLeave += BtnMouseLeave;

        }
        //Event handler for Calculate button
        //private BMIData CalculateBMI(object sender, EventArgs e) {

        //    //Input verifications
        //    if (string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtHeight.Text) 
        //        || string.IsNullOrWhiteSpace(txtWeight.Text)) {
        //        MessageBox.Show("Please, input all the required info.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        //        //return;
        //    }
                        
        //    string gender = txtGender.Text;            

        //    int age;
        //    if (!Int32.TryParse(txtAge.Text, out age)) {
        //        MessageBox.Show("Please, input the correct age.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }

        //    double height;
        //    if (!Double.TryParse(txtHeight.Text, out height)) {
        //        MessageBox.Show("Please, input the correct weight.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }

        //    double weight;
        //    if (!Double.TryParse(txtWeight.Text, out weight)) {
        //        MessageBox.Show("Please, input the correct height.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }

        //    //Calculating the BMI
        //    double BMI;
        //    string unit = "";

        //    if (unit == "metric") {
        //        if (gender == "male") {
        //            BMI = 66 + 6.2 * weight + 12.7 * height - 6.76 * age;
        //        }
        //        if (gender == "female") {
        //            BMI = 655 + 4.35 * weight + 4.7 * height - 4.7 * age;
        //        } else {
        //            MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        //        }
        //    }

        //    if (unit == "imperial") {
        //        //TODO
        //    }

        //    var data = new BMIData(DateTime.Now, gender, age, height, weight);

        //    return data;
            


        //    //Create();
        //}

        private void BtnMouseEnter(object sender, EventArgs e) {
            BtnCalculate.FontSize += 5;
        }

        private void BtnMouseLeave(object sender, EventArgs e) {
            BtnCalculate.FontSize -= 5;
        }

        
        private void BtnCalculate_Click(object sender, RoutedEventArgs e) {
            //Input verifications
                if (string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtHeight.Text)
                    || string.IsNullOrWhiteSpace(txtWeight.Text)) {
                MessageBox.Show("Please, input all the required info.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int age;
            if (!Int32.TryParse(txtAge.Text, out age)) {
                MessageBox.Show("Please, input the correct age.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double height;
            if (!Double.TryParse(txtHeight.Text, out height)) {
                MessageBox.Show("Please, input the correct weight.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double weight;
            if (!Double.TryParse(txtWeight.Text, out weight)) {
                MessageBox.Show("Please, input the correct height.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
            //Calculating the BMI
            double BMI = 0;

            //Imperial
            if ((bool)radioImperial.IsChecked) {

                if ((bool)radioMale.IsChecked) {
                    BMI = 66.5 + 13.75 * weight + 5.003 * height * 100 - 6.755 * age;
                } else if ((bool)radioFemale.IsChecked) {
                    BMI = 655 + 9.563 * weight + 1.85 * height * 100 - 4.676 * age;
                } else {
                    MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                txtResult.Text = Convert.ToString(BMI);
            }



            //Imperial
            if ((bool)radioMetric.IsChecked) {

                if ((bool)radioMale.IsChecked) {
                    BMI = 66.5 + 13.75 * weight + 5.003 * height * 100 - 6.755 * age;
                } else if ((bool)radioFemale.IsChecked) {
                    BMI = 655 + 9.563 * weight + 1.85 * height - 4.676 * age;
                } else {
                    MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                txtResult.Text = Convert.ToString(BMI);
            }









            //if (unit == "metric") {
            //    if (gender == "male") {
            //        BMI = 66 + 6.2 * weight + 12.7 * height - 6.76 * age;
            //    }
            //    if (gender == "female") {
            //        BMI = 655 + 4.35 * weight + 4.7 * height - 4.7 * age;
            //    } else {
            //        MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            //    }
            //}

            txtResult.Text = Convert.ToString(BMI);

            //if (unit == "imperial") {
            //    //TODO
            //}

            

        }


        private void BtnReset_Click(object sender, RoutedEventArgs e) {
            txtAge.Clear();
            txtHeight.Clear();
            txtWeight.Clear();

            



        }

        private void BtnExit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

    }

}
