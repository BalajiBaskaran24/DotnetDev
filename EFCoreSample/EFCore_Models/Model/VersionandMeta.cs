using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Models.Model
{
    /// <summary>
    /// HW board number, SW and FW version 
    /// </summary>
    public class VersionandMeta
    {
        public int VersionandMetaId { get; set; }
        public string SWVersion { get; set; }
        public string FWVersion { get; set; }
        public string BoardInfo { get; set; }
    }
}
