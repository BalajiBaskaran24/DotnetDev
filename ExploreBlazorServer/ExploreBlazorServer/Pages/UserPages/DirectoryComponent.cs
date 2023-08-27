using ExploreBlazorServer.Model.UserInfo;

namespace ExploreBlazorServer.Pages.UserPages
{
    public partial class DirectoryComponent
    {

        public List<PersonModel> People = new List<PersonModel>();

        public DirectoryComponent()
        {
            PersonModel person = new PersonModel();
            person.FirstName = "Tim";
            person.LastName = "Corey";
            person.Addresses = new List<AddressModel>();
            person.Addresses.Add(new AddressModel { Street = "park street", City = "Salem", State = "TN", Type = "Home" });
            person.Addresses.Add(new AddressModel { Street = "RS street", City = "Pollachi", State = "TN", Type = "Vacation stay" });
            People.Add(person);

            person = new PersonModel();
            person.FirstName = "John";
            person.LastName = "Cena";
            person.Addresses = new List<AddressModel>();
            person.Addresses.Add(new AddressModel { Street = "anna park st", City = "Salem", State = "TN", Type = "Home" });
            People.Add(person);

            person = new PersonModel();
            person.FirstName = "Under";
            person.LastName = "Taker";
            person.Addresses = new List<AddressModel>();
            People.Add(person);
        }
    }
}
