// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace IdeaBank.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using IdeaBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using IdeaBank.Shared;

#line default
#line hidden
#nullable disable
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 167 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\Pages\Modal.razor"
       
    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";

    public async Task Open()
    {
        StateHasChanged();
        ModalDisplay = "block;";
        await Task.Delay(250);
        ModalClass = "show";
        StateHasChanged();
    }

    public async Task Close()
    {
        ModalClass = "";
        await Task.Delay(250);
        ModalDisplay = "none;";
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
