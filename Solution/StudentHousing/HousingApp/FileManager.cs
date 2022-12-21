using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class FileManager
    {
        //public static bool CheckLoginDetails(string username, string password)
        //{
            
        //}

        public static void WriteLoginDeails(Building abc)
        {
            
            using StreamWriter file = new StreamWriter("LoginDetails.txt", append: true);
            file.WriteLine(abc.Getusername() + "," + abc.Getpassword());

        }

    }
}
