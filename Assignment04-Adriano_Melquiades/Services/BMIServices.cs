using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment04_Adriano_Melquiades.Services {
    public static class BMIServices {
        private static string root = $@"C:\_test\Assignment04";
        private static List<BMIData> BMIList = new List<BMIData>();

        public static void Create(BMIData BMIData) {
            string filename = $@"{root}\{BMIData.BMIDataNumber}.xml";

            //if (File.Exists(filename))
            //	throw new Exception($"There is already a record for DataNumber {BMIData.BMIDataNumber}. Data {BMIData.BMIDataNumber} not saved.");


            var serializer = new XmlSerializer(typeof(BMIData));

            try {
                using (var stream = new FileStream(filename, FileMode.Create)) {
                    serializer.Serialize(stream, BMIData);
                }
            } catch (Exception e) {
                throw new Exception($"Fatal error ocurred while trying to save DataNumber {BMIData.BMIDataNumber}. Data {BMIData.BMIDataNumber} not saved. {e.Message}");
            }
        }

        public static List<BMIData> GetAll() {
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);

            BMIList = new List<BMIData>();
            var files = Directory.GetFiles(root, "*.xml");

            foreach (string file in files) {
                using (var stream = new FileStream(file, FileMode.Open)) {
                    var serializer = new XmlSerializer(typeof(BMIData));

                    var data = (BMIData)serializer.Deserialize(stream);

                    BMIList.Add(data);
                }
            }

            return BMIList;
        }




        public static void Delete(BMIData obj) {
            string fileToDelete = $@"{root}\{obj.BMIDataNumber}.xml";
            if (File.Exists(fileToDelete))
                File.Delete(fileToDelete);
        }

        public static void Update(BMIData obj) {
            string filename = $@"{root}\{obj.BMIDataNumber}.xml";
            Delete(obj);
            Create(obj);
        }

        public static int Under1500() {
            var count = BMIList.Where(x => x.BMI < 1500).Count();

            return count;
        }

        public static string Max() {
            var max = BMIList.Max(x => x.BMI);
            
            return max.ToString();
        }

        public static string Min() {
            var min = BMIList.Min(x => x.BMI);

            return min.ToString();
        }

        public static string Avg() {
            var avg = BMIList.Average(x => x.BMI);

            return avg.ToString();
        }


    }
}
