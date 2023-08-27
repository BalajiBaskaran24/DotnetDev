using ExploreBlazorServer.Model.UserInfo;
using Microsoft.AspNetCore.Components;

namespace ExploreBlazorServer.Pages.UserPages
{
    public partial class AddressComponent
    {
        [Parameter]
        public AddressModel Address { get; set; }
    }
}
