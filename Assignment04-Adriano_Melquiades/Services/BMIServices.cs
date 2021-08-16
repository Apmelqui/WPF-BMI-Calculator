using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment04_Adriano_Melquiades.Services {
    class BMIServices {
        private string root = $@"C:\_test\";

		public void Create(BMIData BMIData) {
			string filename = $@"{this.root}{BMIData.BMIDataNumber}.xml";

			if (File.Exists(filename))
				throw new Exception($"There is already a record for account guid {BMIData.BMIDataNumber}. Account {BMIData.BMIDataNumber} not saved. Try to save this account again later.");

			var serializer = new XmlSerializer(typeof(BMIData));

			try {
				using (var stream = new FileStream(filename, FileMode.Create)) {
					serializer.Serialize(stream, BMIData);
				}
			} catch (Exception e) {
				throw new Exception($"Fatal error ocurred while trying to save account {BMIData.BMIDataNumber}. Account {BMIData.BMIDataNumber} not saved. {e.Message}");
			}
		}

	}
}
