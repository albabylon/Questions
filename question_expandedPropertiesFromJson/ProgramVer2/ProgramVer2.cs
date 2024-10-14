using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_expandedPropertiesFromJson
{
    internal class ProgramVer2
    {
        private class PersonData
        {
            //неопределенное количество полей, должно определяться из jsonProperties.json
        }
        private static void GetDataFromJson()
        {
            //метод заполняет PersonData из jsonData.json - по совпаданию имен свойства и параметра в json
        }
        private static void GetPropertiesFromJson()
        {
            //метод который получает из jsonProperties.json настраимовые извне поля для PersonData, которые в дальнейшем может заполнить GetDataFromJson()
        }

        static void Main(string[] args)
        {
            GetPropertiesFromJson(); //получает возможные поля из jsonProperties.json
            
            List<PersonData> datas = new List<PersonData>();           
            GetDataFromJson(); //заполняем список datas по json
        }
    }
}
