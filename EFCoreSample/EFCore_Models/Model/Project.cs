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
        //[MaxLength(15)] To define the maximum length of an input
        //[NotMapped()] Not required to be added in table
        public string RelativeFolderPath { get; set; }

    }
}