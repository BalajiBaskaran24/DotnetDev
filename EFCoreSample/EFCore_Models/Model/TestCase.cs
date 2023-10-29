using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Models.Model
{
    public class TestCase
    {
        public int TestCaseId { get; set; }
        public string TestCaseNameEnumFormat { get; set; }
        public string TestCaseNameStringFormat { get; set; }
        public string TestResult { get; set; }
    }
}
