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

        public BMIData() {

        }
        public BMIData(string gender, int age, double height, double weight, double bmi) {
            this.BMIDataNumber = $"BMI-{Guid.NewGuid().ToString()}";
            this.Gender = gender;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            this.BMI = bmi;
            counter++;
        }

        public override string ToString() {
            return $"BMIDataNumber: {this.BMIDataNumber}\n" +
                   $"Gender: {this.Gender}\n" +
                   $"Age: {this.Age}\n" +
                   $"Height: {this.Height}\n" +
                   $"Weight: {this.Weight}\n";
        }

        //public enum GenderType {
        //    Male,
        //    Female
        //}


    }
}
