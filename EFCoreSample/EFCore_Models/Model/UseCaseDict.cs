using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Models.Model
{
    /// <summary>
    /// Sample model with dictionary
    /// </summary>
    public class UseCaseDict
    {
        public int UseCaseDictId { get; set; }

        //This will throw error
        //Unable to determine the relationship represented by navigation 'UseCaseDict.SampleDataColl' of type
        //'Dictionary<int, int>'. Either manually configure the relationship, or ignore this property using the
        //'[NotMapped]' attribute or by using 'EntityTypeBuilder.Ignore' in 'OnModelCreating'.
        //public Dictionary<int, int> SampleDataColl { get; set; }
    }

    public class SampleData
    {
        public int SampleDataId { get; set; }
        public string SampleDataName { get; set; }
    }
}
