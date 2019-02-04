using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace bmiProjekt
{
    class DB
    {
        static public string InsertBmi(BmiCal bmi)
        {
            string message = "Weight and Height saved without problems";
            
            try
            {

                XmlDocument Xml = new XmlDocument();
                XmlSerializer Ser = new XmlSerializer(bmi.GetType());
                MemoryStream stream = new MemoryStream();

                Ser.Serialize(stream, bmi);
                stream.Position = 0;
                Xml.Load(stream);
                Xml.Save("BMINumbers");
                return message;

            }
            catch (Exception)
            {

                return "Error, Weight and Height not saved";
            }

            
        }
    }
}
