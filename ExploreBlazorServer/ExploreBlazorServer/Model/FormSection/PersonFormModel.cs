//Below namespace is for built in validation
using System.ComponentModel.DataAnnotations;

namespace ExploreBlazorServer.Model.FormSection
{
    public class PersonFormModel
    {
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Length Mismatch")]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Range(0, 125, ErrorMessage = "Please enter valid age")]
        public int Age { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Concent is must")]
        public bool GaveConcent { get; set; }
    }
}
