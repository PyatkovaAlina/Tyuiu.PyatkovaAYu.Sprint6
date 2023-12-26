using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                   resStr = resStr + " " + line;                    
                }
            }
            return resStr;
        }
    }
}
