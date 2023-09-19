using System.ComponentModel.DataAnnotations;

namespace ExploreBlazorServer.Model.FormConclusion;

public class MilkshakeOrderModel
{
    [Required]
    [MinLength(1, ErrorMessage = "Select MS type")]
    public string TypeofMilkshake { get; set; }

    [Required]
    [MinLength(1, ErrorMessage = "Select MS Type")]
    public string SizeofMilkshake { get; set; }

    [Required]
    [MinLength(3, ErrorMessage = "Provide Order Name")]
    public string OrderName { get; set; }


    [Range(1, 10, ErrorMessage = "Valid number between 1 to 10")]
    public int Quantity { get; set; }


    public bool AddWhippedIceCream { get; set; }
}
