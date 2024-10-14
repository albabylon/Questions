using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_expandedPropertiesFromJson
{
    internal class ProgramVer1
    {
        private class PersonData
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
        }

        private static void GetDataFromJson ()
        {
            //метод заполняет PersonData из jsonData.json - по совпаданию имен свойства и параметра в json
        }

        static void Main(string[] args)
        {
            List<PersonData> datas = new List<PersonData> ();
            GetDataFromJson(); //заполняем список datas по json
        }
    }
}
