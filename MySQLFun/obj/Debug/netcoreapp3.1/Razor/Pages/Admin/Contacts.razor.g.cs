#pragma checksum "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/13_ZM_holder/Mission13_ZM/MySQLFun/Pages/Admin/Contacts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8a9899f719e25c360c32327793854f599ae67fa"
// <auto-generated/>
#pragma warning disable 1591
namespace MySQLFun.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/13_ZM_holder/Mission13_ZM/MySQLFun/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/13_ZM_holder/Mission13_ZM/MySQLFun/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/13_ZM_holder/Mission13_ZM/MySQLFun/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/13_ZM_holder/Mission13_ZM/MySQLFun/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/13_ZM_holder/Mission13_ZM/MySQLFun/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/13_ZM_holder/Mission13_ZM/MySQLFun/Pages/Admin/_Imports.razor"
using MySQLFun.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/contacts")]
    public partial class Contacts : OwningComponentBase<IBowlersRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MySQLFun.Pages.Admin.ContactList>(0);
            __builder.AddAttribute(1, "TableTitle", "");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591