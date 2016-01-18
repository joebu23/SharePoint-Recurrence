using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharePoint_Recurrence;

namespace SharePoint_RecurrenceTests
{
    [TestClass]
    public class RecurrenceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new RecurrenceService(TestData());

            var data = service.FindRecurrences();
        }

        private string TestData()
        {
            return @"<recurrence>
	<rule>
		<firstDayOfWeek>su</firstDayOfWeek>
		<repeat>
			<weekly mo='TRUE' tu='TRUE' weekFrequency='1' />
		</repeat>
		<repeatForever>FALSE</repeatForever>
	</rule>
</recurrence>";
        }
    }
}
