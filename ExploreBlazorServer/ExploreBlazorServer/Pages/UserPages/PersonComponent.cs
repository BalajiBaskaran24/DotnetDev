using Microsoft.AspNetCore.Components;

namespace ExploreBlazorServer.Pages.UserPages;

public partial class PersonComponent
{
    [Parameter]
    public string FirstName { get; set; }

    [Parameter]
    public string LastName { get; set; }

    [Parameter]
    public RenderFragment AddressFragment { get; set; }
}
