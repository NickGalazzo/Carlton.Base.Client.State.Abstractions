// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Carlton.Base.Client.State
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class CarltonComponentBase<TViewModel> : Microsoft.AspNetCore.Components.ComponentBase, ICarltonComponent<TViewModel>, IStatusComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.State.Abstractions\CarltonComponentBase.razor"
       
    [Parameter]
    public TViewModel ViewModel { get; set; }
    [Parameter]
    public EventCallback OnComponentEvent { get; init; }
    [Parameter]
    public ComponentStatus ComponentStatus { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
