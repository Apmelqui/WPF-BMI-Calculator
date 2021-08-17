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

			if (File.Exists(filename))
				throw new Exception($"There is already a record for DataNumber {BMIData.BMIDataNumber}. Data {BMIData.BMIDataNumber} not saved.");

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




		public static void Read() {

		}

		public static void Remove(string filename) {
			//Remover o arquivo
			//filename = {root}-{BMIData.BMIDataNumber}.xml
		}

		public static void Update(BMIData data) {
			Remove(data.BMIDataNumber);
			Create(data);
			
			
			

    }




    }
}
