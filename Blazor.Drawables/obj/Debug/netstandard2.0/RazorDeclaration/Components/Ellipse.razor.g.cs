#pragma checksum "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Ellipse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed4a6595be9812310e297c29a4f8f22b3e1ee1a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Drawables.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\_Imports.razor"
using System.Drawing;

#line default
#line hidden
    public partial class Ellipse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 78 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Ellipse.razor"
 
    [Parameter]
    public int X { get; set; }
    [Parameter]
    public int Y { get; set; }

    [Parameter]
    public double Width { get; set; }
    [Parameter]
    public double Height { get; set; }
    [Parameter]
    public double Opacity { get; set; } = 1;
    [Parameter]
    public bool NoFill { get; set; }
    [Parameter]
    public System.Drawing.Color Color { get; set; }
    [Parameter]
    public bool NoStroke { get; set; }
    [Parameter]
    public Color StrokeColor { get; set; }
    [Parameter]
    public double StrokeWidth { get; set; } = 1;
    [Parameter]
    public StrokeLineCap Cap { get; set; }
    [Parameter]
    public StrokeLineJoin Join { get; set; }
    [Parameter]
    public int StrokeDashArray { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnDoubleClick { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseMove { get; set; }
    [Parameter]
    public EventCallback<WheelEventArgs> OnMouseWheel { get; set; }
    [Parameter]
    public EventCallback<DragEventArgs> OnDrag { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMousePressed { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseReleased { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseOut { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnMouseOver { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
