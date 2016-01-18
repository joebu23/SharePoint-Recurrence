using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePoint_Recurrence
{
    public class RecurrenceData
    {
        public List<DateTime> Recurrences
        {
            get
            {
                return null;
            }
        }

        public List<string> Days { get; set; }

        public bool RepeatForever { get; set; }

        public int RecurrencesToReturn { get; set; }

        public int RecurrenceCount { get; set; }

        public DateTime RecurrenceEnd { get; set; }

        //private string _frequency;
        public string Frequency { get; set; }
        //{
        //    get
        //    {
        //        return _frequency;
        //    }
        //    set
        //    {
        //        _frequency = value;
        //    }
        //}

        //public enum Frequency
        //{
        //    Daily,
        //    Weekly,
        //    Monthly,
        //    MonthlyByDay,
        //    Annually,
        //    AnnuallyByDay
        //}
    }
}
