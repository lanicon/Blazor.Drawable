#pragma checksum "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1de1f090b698872dcb2d79afff2133d13d783dc2"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class Bezier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "path");
            __builder.AddAttribute(1, "d", 
#line 2 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
          GetPath()

#line default
#line hidden
            );
            __builder.AddAttribute(2, "r", 
#line 3 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
          StrokeWidth

#line default
#line hidden
            );
            __builder.AddAttribute(3, "fill", "rgba(" + (
#line 4 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                  Color.Transparent.R

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                                       Color.Transparent.G

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                                                            Color.Transparent.B

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                                                                                 Color.Transparent.A

#line default
#line hidden
            ) + ")");
            __builder.AddAttribute(4, "stroke", "rgba(" + (
#line 5 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                    StrokeColor.R

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                                   StrokeColor.G

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                                                  StrokeColor.B

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                                                                 StrokeColor.A

#line default
#line hidden
            ) + ")");
            __builder.AddAttribute(5, "stroke-dasharray", 
#line 6 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                         StrokeDashArray

#line default
#line hidden
            );
            __builder.AddAttribute(6, "stroke-linejoin", 
#line 6 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                                                            Join.ToString().ToLower()

#line default
#line hidden
            );
            __builder.AddAttribute(7, "stroke-linecap", 
#line 7 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                       Cap.ToString().ToLower()

#line default
#line hidden
            );
            __builder.AddAttribute(8, "stroke-width", 
#line 8 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                     StrokeWidth

#line default
#line hidden
            );
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 9 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 10 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                   OnDoubleClick

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                    OnMouseMove

#line default
#line hidden
            ));
            __builder.AddAttribute(12, "onmousewheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#line 12 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                     OnMouseWheel

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "ondrag", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#line 13 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
               OnDrag

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                    OnMousePressed

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                  OnMouseReleased

#line default
#line hidden
            ));
            __builder.AddAttribute(16, "style", "opacity:" + (
#line 16 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
                      Opacity

#line default
#line hidden
            ));
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 20 "C:\Users\Shivendra\source\repos\Blazor.Test.Components\Blazor.Drawables\Components\Bezier.razor"
 
    [Parameter]
    public int X1 { get; set; }
    [Parameter]
    public int Y1 { get; set; }
    [Parameter]
    public int X2 { get; set; }
    [Parameter]
    public int Y2 { get; set; }
    [Parameter]
    public int X3 { get; set; }
    [Parameter]
    public int Y3 { get; set; }
    [Parameter]
    public int X4 { get; set; }
    [Parameter]
    public int Y4 { get; set; }
    [Parameter]
    public double Opacity { get; set; } = 1;
    [Parameter]
    public Color StrokeColor { get; set; } = Color.Black;
    [Parameter]
    public double StrokeWidth { get; set; } = 2;
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
    
    private string GetPath()
    {
        return $"M{X1},{Y1} C{X2},{Y2} {X3},{Y3} {X4},{Y4}";
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
