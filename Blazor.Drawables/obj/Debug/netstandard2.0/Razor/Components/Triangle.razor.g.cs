#pragma checksum "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d165453773a88cbf2f6a0338b2b64e317c09dc"
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
#line 1 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\_Imports.razor"
using System.Drawing;

#line default
#line hidden
    public partial class Triangle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
 if (!NoFill && !NoStroke)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "polygon");
            __builder.AddAttribute(2, "points", 
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                      GetPoints()

#line default
#line hidden
            );
            __builder.AddAttribute(3, "fill", "rgba(" + (
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                               Color.R

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                        Color.G

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                                 Color.B

#line default
#line hidden
            ) + "," + (
#line 4 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                                          Color.A

#line default
#line hidden
            ) + ")");
            __builder.AddAttribute(4, "stroke", "rgba(" + (
#line 5 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           StrokeColor.R

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                          StrokeColor.G

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                         StrokeColor.B

#line default
#line hidden
            ) + "," + (
#line 5 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                                        StrokeColor.A

#line default
#line hidden
            ) + ")");
            __builder.AddAttribute(5, "stroke-dasharray", 
#line 6 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                StrokeDashArray

#line default
#line hidden
            );
            __builder.AddAttribute(6, "stroke-linejoin", 
#line 6 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                                   Join.ToString().ToLower()

#line default
#line hidden
            );
            __builder.AddAttribute(7, "stroke-linecap", 
#line 7 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                              Cap.ToString().ToLower()

#line default
#line hidden
            );
            __builder.AddAttribute(8, "stroke-width", 
#line 8 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                            StrokeWidth

#line default
#line hidden
            );
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 9 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                       OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 10 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                          OnDoubleClick

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMouseMove

#line default
#line hidden
            ));
            __builder.AddAttribute(12, "onmousewheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#line 12 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                            OnMouseWheel

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "ondrag", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#line 13 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                      OnDrag

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMousePressed

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                         OnMouseReleased

#line default
#line hidden
            ));
            __builder.AddAttribute(16, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                          OnMouseOut

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 17 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMouseOver

#line default
#line hidden
            ));
            __builder.AddAttribute(18, "style", "opacity:" + (
#line 18 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                             Opacity

#line default
#line hidden
            ));
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#line 21 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
}
else if (NoStroke && !NoFill)
{

#line default
#line hidden
            __builder.AddContent(21, "    ");
            __builder.OpenElement(22, "polygon");
            __builder.AddAttribute(23, "points", 
#line 24 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                      GetPoints()

#line default
#line hidden
            );
            __builder.AddAttribute(24, "fill", "rgba(" + (
#line 24 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                               Color.R

#line default
#line hidden
            ) + "," + (
#line 24 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                        Color.G

#line default
#line hidden
            ) + "," + (
#line 24 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                                 Color.B

#line default
#line hidden
            ) + "," + (
#line 24 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                                          Color.A

#line default
#line hidden
            ) + ")");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 25 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                       OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                          OnDoubleClick

#line default
#line hidden
            ));
            __builder.AddAttribute(27, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 27 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMouseMove

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "onmousewheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#line 28 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                            OnMouseWheel

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "ondrag", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#line 29 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                      OnDrag

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 30 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMousePressed

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 31 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                         OnMouseReleased

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 32 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                          OnMouseOut

#line default
#line hidden
            ));
            __builder.AddAttribute(33, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 33 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMouseOver

#line default
#line hidden
            ));
            __builder.AddAttribute(34, "style", "opacity:" + (
#line 34 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                             Opacity

#line default
#line hidden
            ));
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#line 36 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
}
else if (!NoStroke && NoFill)
{

#line default
#line hidden
            __builder.AddContent(37, "    ");
            __builder.OpenElement(38, "polygon");
            __builder.AddAttribute(39, "points", 
#line 39 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                      GetPoints()

#line default
#line hidden
            );
            __builder.AddAttribute(40, "stroke", "rgba(" + (
#line 40 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           StrokeColor.R

#line default
#line hidden
            ) + "," + (
#line 40 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                          StrokeColor.G

#line default
#line hidden
            ) + "," + (
#line 40 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                         StrokeColor.B

#line default
#line hidden
            ) + "," + (
#line 40 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                                        StrokeColor.A

#line default
#line hidden
            ) + ")");
            __builder.AddAttribute(41, "stroke-width", 
#line 41 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                            StrokeWidth

#line default
#line hidden
            );
            __builder.AddAttribute(42, "stroke-dasharray", 
#line 42 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                StrokeDashArray

#line default
#line hidden
            );
            __builder.AddAttribute(43, "stroke-linejoin", 
#line 42 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                                                                   Join.ToString().ToLower()

#line default
#line hidden
            );
            __builder.AddAttribute(44, "stroke-linecap", 
#line 43 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                              Cap.ToString().ToLower()

#line default
#line hidden
            );
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 44 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                       OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(46, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 45 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                          OnDoubleClick

#line default
#line hidden
            ));
            __builder.AddAttribute(47, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 46 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMouseMove

#line default
#line hidden
            ));
            __builder.AddAttribute(48, "onmousewheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#line 47 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                            OnMouseWheel

#line default
#line hidden
            ));
            __builder.AddAttribute(49, "ondrag", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#line 48 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                      OnDrag

#line default
#line hidden
            ));
            __builder.AddAttribute(50, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 49 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMousePressed

#line default
#line hidden
            ));
            __builder.AddAttribute(51, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 50 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                         OnMouseReleased

#line default
#line hidden
            ));
            __builder.AddAttribute(52, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 51 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                          OnMouseOut

#line default
#line hidden
            ));
            __builder.AddAttribute(53, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 52 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMouseOver

#line default
#line hidden
            ));
            __builder.AddAttribute(54, "style", "opacity:" + (
#line 53 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                             Opacity

#line default
#line hidden
            ));
            __builder.AddMarkupContent(55, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#line 56 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(57, "    ");
            __builder.OpenElement(58, "polygon");
            __builder.AddAttribute(59, "points", 
#line 59 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                      GetPoints()

#line default
#line hidden
            );
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 60 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                       OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(61, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 61 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                          OnDoubleClick

#line default
#line hidden
            ));
            __builder.AddAttribute(62, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 62 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMouseMove

#line default
#line hidden
            ));
            __builder.AddAttribute(63, "onmousewheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#line 63 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                            OnMouseWheel

#line default
#line hidden
            ));
            __builder.AddAttribute(64, "ondrag", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#line 64 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                      OnDrag

#line default
#line hidden
            ));
            __builder.AddAttribute(65, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 65 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMousePressed

#line default
#line hidden
            ));
            __builder.AddAttribute(66, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 66 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                         OnMouseReleased

#line default
#line hidden
            ));
            __builder.AddAttribute(67, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 67 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                          OnMouseOut

#line default
#line hidden
            ));
            __builder.AddAttribute(68, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 68 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                           OnMouseOver

#line default
#line hidden
            ));
            __builder.AddAttribute(69, "style", "opacity:" + (
#line 69 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
                             Opacity

#line default
#line hidden
            ));
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#line 71 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 75 "C:\Users\shive\Desktop\Test\Blazor.Drawable\Blazor.Drawables\Components\Triangle.razor"
 
    [Parameter]
    public double X1{ get; set; }
    [Parameter]
    public double X2 { get; set; }
    [Parameter]
    public double X3 { get; set; }
    [Parameter]
    public double Y1 { get; set; }
    [Parameter]
    public double Y2 { get; set; }
    [Parameter]
    public double Y3 { get; set; }
    [Parameter]
    public double Opacity { get; set; } = 1;
    [Parameter]
    public bool NoFill { get; set; }
    [Parameter]
    public System.Drawing.Color Color { get; set; } = Color.Black;
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
    public EventCallback<MouseEventArgs> OnMouseOver { get; set; }

    private string GetPoints()
    {
        return $"{X1},{Y1} {X2},{Y2} {X3},{Y3}";
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
