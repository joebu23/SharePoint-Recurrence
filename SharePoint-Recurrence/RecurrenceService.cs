using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SharePoint_Recurrence
{
    public class RecurrenceService
    {
        private static string recurrenceData;

        public RecurrenceService(string _recurrenceData)
        {
            recurrenceData = _recurrenceData;
        }

        public List<DateTime> FindRecurrences()
        {
            var returnData = new List<DateTime>();
            var returnModel = new RecurrenceData();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(recurrenceData);

            XmlNodeList nodes = doc.SelectNodes("//recurrence");

            foreach (XmlNode node in nodes)
            {
                XmlNodeList rules = node.SelectNodes("//repeat");

                foreach (XmlNode rule in rules)
                {
                    var ruleData = rule.FirstChild;
                    var atts = ruleData.Attributes;

                    returnModel.Frequency = ruleData.Name;

                    foreach (XmlAttribute att in atts)
                    {
                        if (att.Name.Length == 2)
                        {
                            returnModel.Days.Add(att.Name);
                        }


                        var y = 1;
                    }

                    var x = 1;
                }


            }




            return returnData;
        }
    }
}
