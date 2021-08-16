﻿using Assignment04_Adriano_Melquiades.Services;
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


        private void BtnMouseEnter(object sender, EventArgs e) {
            BtnCalculate.FontSize += 5;
        }

        private void BtnMouseLeave(object sender, EventArgs e) {
            BtnCalculate.FontSize -= 5;
        }


        private void BtnCalculate_Click(object sender, RoutedEventArgs e) {
            //Input verifications



            //TODO: metric and gender verifications
            


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
            string gender = "";
            
            //Metric
            if ((bool)radioMetric.IsChecked) {

                if ((bool)radioMale.IsChecked) {
                    gender = "male";
                    BMI = 66.5 + 13.75 * weight + 5.003 * height * 100 - 6.755 * age;
                } else if ((bool)radioFemale.IsChecked) {
                    gender = "female";
                    BMI = 655 + 9.563 * weight + 1.85 * height - 4.676 * age;
                } else {
                    MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //txtResult.Text = Convert.ToString(BMI);
            }


            //Imperial
            if ((bool)radioImperial.IsChecked) {

                if ((bool)radioMale.IsChecked) {
                    BMI = 66.5 + 13.75 * weight + 5.003 * height * 100 - 6.755 * age;
                } else if ((bool)radioFemale.IsChecked) {
                    BMI = 655 + 9.563 * weight + 1.85 * height * 100 - 4.676 * age;
                } else {
                    MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //txtResult.Text = Convert.ToString(BMI);
            }

            
            txtResult.Text = BMI.ToString("#.##");


            var data = new BMIData(gender, age, height, weight, BMI);


            try {
                BMIServices.Create(data);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        private void BtnReset_Click(object sender, RoutedEventArgs e) {
            txtAge.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            txtResult.Clear();
            radioMale.IsChecked = false;
            radioFemale.IsChecked = false;

            radioMetric.IsChecked = false;
            radioImperial.IsChecked = false;


            //radioMetric.Checked = false;
            //radioImperial.Checked = false;

            //radioMale.Checked = false;
            //radioFemale.Checked = false;


        }

        private void BtnExit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }







    }

}
