namespace ExploreBlazorServer.Model.UserInfo;

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<AddressModel> Addresses { get; set; }
}
