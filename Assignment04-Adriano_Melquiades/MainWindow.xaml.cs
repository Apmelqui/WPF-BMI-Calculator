using Assignment04_Adriano_Melquiades.Services;
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

            Initialize();

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


            //TODO: Make combobox work
            //string unit = comboBox.SelectedItem.ToString();
            //MessageBox.Show(unit);


            if ((ComboBoxItem)comboBox.SelectedItem == null) {
                MessageBox.Show("Please select the gender and run it again");
                return;
            }

            var selection = (ComboBoxItem)comboBox.SelectedItem;



            string selectedOption = selection.Content.ToString();
            //MessageBox.Show(selectedOption);

            //Metric
            if (selectedOption == "Metric - (meters - Kg)") {
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
            else if (selectedOption == "Imperial (inches - pounds") {
                if ((bool)radioMale.IsChecked) {
                    BMI = 66 + 6.2 * weight + 12.7 * height - 6.76 * age;
                } else if ((bool)radioFemale.IsChecked) {
                    BMI = 655 + 4.35 * weight + 4.7 * height - 4.7 * age;
                } else {
                    MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //txtResult.Text = Convert.ToString(BMI);
            }


            txtResult.Text = BMI.ToString("#.##");

            

            var data = new BMIData(gender, age, height, weight, BMI, selectedOption);


            try {
                BMIServices.Create(data);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            txtFilesToOpen.ItemsSource = new List<BMIData>();

            txtFilesToOpen.ItemsSource = BMIServices.GetAll();
        }

        private void Reset() {
            txtAge.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            txtResult.Clear();
            radioMale.IsChecked = false;
            radioFemale.IsChecked = false;
            ResultAge.Clear();
            ResultHeight.Clear();
            ResultWeight.Clear();

            //txtFilesToOpen.Items.Clear();


            //txtFilesToOpen.itemsControl.ItemsSource();

            //txtFilesToOpen.ItemsSource = new List<BMIData>();
            txtFilesToOpen.ItemsSource = BMIServices.GetAll();


            //radioMetric.IsChecked = false;
            //radioImperial.IsChecked = false;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e) {
            this.Reset();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }


        private void Initialize() {
            txtFilesToOpen.ItemsSource = BMIServices.GetAll();


        }

        private void txtFilesToOpen_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //MessageBox.Show(txtFilesToOpen.SelectedItem.ToString());

            if (txtFilesToOpen.SelectedItem != null) {
                var selectedItem = (BMIData)txtFilesToOpen.SelectedItem;

                ResultAge.Text = selectedItem.Age.ToString();
                ResultHeight.Text = selectedItem.Height.ToString();
                ResultWeight.Text = selectedItem.Weight.ToString();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e) {

            if (txtFilesToOpen.SelectedItem == null) {
                MessageBox.Show("Please select and BMI datato continue");
                return;
            }



            BMIData selectedItem = (BMIData)txtFilesToOpen.SelectedItem;

            int age;
            if (!Int32.TryParse(ResultAge.Text, out age)) {
                MessageBox.Show("Please, input the correct age.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double height;
            if (!Double.TryParse(ResultHeight.Text, out height)) {
                MessageBox.Show("Please, input the correct weight.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double weight;
            if (!Double.TryParse(ResultWeight.Text, out weight)) {
                MessageBox.Show("Please, input the correct height.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }


            selectedItem.Age = age;
            selectedItem.Height = height;
            selectedItem.Weight = weight;
            

            //Metric
            if (selectedItem.Unit == "Metric - (meters - Kg)") {
                if (selectedItem.Gender == "male") {
                    selectedItem.BMI = 66.5 + 13.75 * weight + 5.003 * height * 100 - 6.755 * age;
                } else if (selectedItem.Gender == "female") {
                    selectedItem.BMI = 655 + 9.563 * weight + 1.85 * height - 4.676 * age;
                } else {
                    MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //txtResult.Text = Convert.ToString(BMI);
            }
            //Imperial
            else if (selectedItem.Unit == "Imperial (inches - pounds") {
                if (selectedItem.Gender == "male") {
                    selectedItem.BMI = 66 + 6.2 * weight + 12.7 * height - 6.76 * age;
                } else if (selectedItem.Gender == "female") {
                    selectedItem.BMI = 655 + 4.35 * weight + 4.7 * height - 4.7 * age;
                } else {
                    MessageBox.Show("Error. Wrong gender input", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                //txtResult.Text = Convert.ToString(BMI);
            }


            BMIServices.Update(selectedItem);
            MessageBox.Show(selectedItem.BMIDataNumber);
            Reset();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e) {
            BMIData selectedData = (BMIData)txtFilesToOpen.SelectedItem;

            BMIServices.Delete(selectedData);
            MessageBox.Show("The file has been deleted");
            Reset();

        }

        private void btnNormal_Click(object sender, RoutedEventArgs e) {
            var count = BMIServices.Under1500();
            MessageBox.Show($"There is {count.ToString()} BMI less than 1500.");
        }

        private void MaxiBMI_Click(object sender, RoutedEventArgs e) {
            var max = BMIServices.Max();
            MessageBox.Show($"The maximum BMI is {max}");
        }

        private void MinBMI_Click(object sender, RoutedEventArgs e) {
            var min = BMIServices.Min();
            MessageBox.Show($"The minimum BMI is {min}");
        }

        private void average_Click(object sender, RoutedEventArgs e) {
            var avg = BMIServices.Avg();
            MessageBox.Show($"The minimum BMI is {avg}");
        }
    }

}



