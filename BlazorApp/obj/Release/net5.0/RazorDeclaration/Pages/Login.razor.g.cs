// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\Pages\Login.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\Pages\Login.razor"
      
    private string username;
    private string password;
    private string message;
    private int status{get;set;}=0; //1 means login, 0 means not login

    private MemberData member;
    async Task login(){             // Task is a built in class, to perform asynchronous operations
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\Pages\Login.razor"
                                            
        if (await MyLogin.LoginVerify(this.username, this.password))
        {
            status = MyLogin.getlogin();
            member = MyLogin.getLoggedinUserInfo();
            //NavigationManager.NavigationTo("/"); //bavigate back to home

        }
        else
        {
            message = "User name or password is incorrect";
        }


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\v-mingsy\Documents\CS504_Software_engineering\hop10-blazordeployment-yangms123\Module 10\BlazorApp\Pages\Login.razor"
                                                       
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SqliteService db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginService MyLogin { get; set; }
    }
}
#pragma warning restore 1591