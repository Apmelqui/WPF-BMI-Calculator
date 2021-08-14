using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment04_Adriano_Melquiades {
    public class BMIData {
        public DateTime Date { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public double BMI { get; set; }

        public BMIData(DateTime date, string gender, int age, double height, double weight) {
            this.Date = date;
            this.Gender = gender;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }

        //public enum GenderType {
        //    Male,
        //    Female
        //}


    }
}
