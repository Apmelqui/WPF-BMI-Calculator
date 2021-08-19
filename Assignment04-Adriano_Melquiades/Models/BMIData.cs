using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment04_Adriano_Melquiades {
    public class BMIData {
        private static int counter = 1;

        public string BMIDataNumber { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public double BMI { get; set; }
        public string Unit { get; set; }

        public BMIData() {

        }
        public BMIData(string gender, int age, double height, double weight, double bmi, string unit) {
            this.BMIDataNumber = $"BMI-{Guid.NewGuid().ToString()}";
            this.Gender = gender;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            this.BMI = bmi;
            this.Unit = unit;
            counter++;

            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("BMIDataNumber", this.BMIDataNumber);
            dict.Add("Gender", gender);

            Dictionary<string, double> dict2 = new Dictionary<string, double>();

            dict2.Add("Height", height);
            dict2.Add("Weight", weight);
            dict2.Add("BMI", bmi);

            MessageBox.Show($"BMI for {dict["Gender"]}\n" +
                            $"Height: {dict2["Height"]}\n" +
                            $"Weight: {dict2["Weight"]}\n" +
                            $"BMI:  {dict2["BMI"]}\n" +
                            $"Created sucessfully!");
        }

        public override string ToString() {
            return $"BMIDataNumber: {this.BMIDataNumber}\n" +
                   $"Gender: {this.Gender}\n" +
                   $"Age: {this.Age}\n" +
                   $"Height: {this.Height}\n" +
                   $"Weight: {this.Weight}\n" +
                   $"Unit: {this.Unit}";
        }

        //public enum GenderType {
        //    Male,
        //    Female
        //}


    }
}
