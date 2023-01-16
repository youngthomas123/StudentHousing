using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HousingApp
{
    public class FileManager
    {
        public static string number="";
        public static string firstname="";
        public  static string lastname = "";
        public static bool CheckLoginDetails(string username, string password)
        {
            bool check;
            string FilePath = "C:\\Users\\vasan_8i\\Desktop\\student housing\\student-housing\\Solution\\StudentHousing\\HousingApp\\LoginDetails.txt";

            using StreamReader br = new StreamReader(FilePath);

            

            while (true)

            {
                string[] data;
                string text = br.ReadLine();
                if (text != null)
                {
                    data = text.Split(',');

                    if (string.Equals(data[0], username) && string.Equals(data[1], password))
                    {

                        check = true;

                        number = Convert.ToString(data[2]);
                        firstname = data[3];
                        lastname = data[4];

                        br.Close();
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                }
                else
                {
                    check = false;
                    br.Close();
                    break;
                }
            }
            return check;

        }
        public void SaveToFile(Building building)
        {
            File.WriteAllText(@"C:\Users\vasan_8i\Desktop\student housing\student-housing\Solution\StudentHousing\HousingApp\Data.xml", string.Empty);


            FileStream? stream = null;
            string fileName = @"C:\Users\vasan_8i\Desktop\student housing\student-housing\Solution\StudentHousing\HousingApp\Data.xml";
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Write);

                Type mainType = typeof(Building);
                List<Type> auxiliaryTypes = new List<Type> { typeof(House), typeof(Admin), typeof(Student), typeof(Announcement), typeof(Complaint), typeof(Task), typeof(Message) };
                DataContractSerializer serializer = new DataContractSerializer(mainType, auxiliaryTypes);
                serializer.WriteObject(stream, building);

            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }

            }
        }
        public Building LoadFromFile()
        {
            FileStream? stream = null;
            string fileName = @"C:\Users\vasan_8i\Desktop\student housing\student-housing\Solution\StudentHousing\HousingApp\Data.xml";

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlDictionaryReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                                                new XmlDictionaryReaderQuotas());

                Type mainType = typeof(Building);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(House), typeof(Admin), typeof(Student), typeof(Announcement), typeof(Complaint), typeof(Task), typeof(Message) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                return (Building?)serializer.ReadObject(reader);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }

            }
        }

      

    }
}
