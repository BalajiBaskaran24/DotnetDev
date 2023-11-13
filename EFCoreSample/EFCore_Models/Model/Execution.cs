using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Models.Model
{
    public class Execution
    {
        public int ExecutionId { get; set; }

        /// <summary>
        /// Run 1/2/3
        /// </summary>
        public string ExecutionIndex { get; set; }

        public string RelativeFolderPath { get; set; }

        public Execution()
        {

        }

        public Execution(int execId, string exeIndex, string relFolderPath)
        {
            ExecutionId = execId;
            ExecutionIndex = exeIndex;
            RelativeFolderPath = relFolderPath;
        }
    }
}
