// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Test.MyComponent>(0);
            builder.AddAttribute(1, "StringProperty", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                               42.ToString()

#line default
#line hidden
#nullable disable
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591