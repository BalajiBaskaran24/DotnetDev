using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_Models.Model
{
    //[Table("Project Info")]
    /// <summary>
    /// If above annotation is added the table name will be as per annotation,
    /// else class name. Similarly for column name
    /// </summary>
    public class Project
    {
        //[Key] To mention the field that should act as primary key
        public int ProjectId { get; set; }

        //[Column("Folder Path")]
        //[Required] To mention this to be required field
        public string RelativeFolderPath { get; set; }

    }
}