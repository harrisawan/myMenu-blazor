// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyMenu.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\new project\MyMenu\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\new project\MyMenu\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Companies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Menus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Items;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\new project\MyMenu\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\new project\MyMenu\Client\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\new project\MyMenu\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\new project\MyMenu\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\new project\MyMenu\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\new project\MyMenu\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\new project\MyMenu\Client\Pages\AdminHome.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/adminhome/{userid}")]
    public partial class AdminHome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "D:\new project\MyMenu\Client\Pages\AdminHome.razor"
       

    [Parameter]
    public string UserId { get; set; }

    [CascadingParameter]
    public AdminLayout Layout { get; set; }

    private List<Company> Companies { get; set; } = new List<Company>();
    private CompanyViewModel addCompany { get; set; } = new CompanyViewModel();

    private bool dense = false;
    private bool hover = true;
    private bool ronly = false;
    private string searchString = "";
    private Company selectedItem = null;
    private string companyId { get; set; }
    private IFileListEntry file { get; set; }

    string status;
    public byte[] imageUploaded { get; set; }
    private CompanyDetailViewModel companyDetailViewModel { get; set; } = new CompanyDetailViewModel();


    // Dialog Box
    private bool dialogBoxVisible;
    private void OpenDialog()
    {
        status = "";
        file = null;
        imageUploaded = null;
        companyDetailViewModel.Name = null;
        companyDetailViewModel.Description = null;
        selectedItem = null;
        companyDetailViewModel = new CompanyDetailViewModel();
        dialogBoxVisible = true;
    }
    private void ResetForm()
    {
        status = "";
        file = null;
        imageUploaded = null;
        companyDetailViewModel.Name = null;
        companyDetailViewModel.Description = null;
        selectedItem = null;
        companyDetailViewModel = new CompanyDetailViewModel();
    }
    private async Task OpenEditDialog()
    {
        if (selectedItem != null)
        {
            var result = await companyService.GetCompaniesById(selectedItem.Id);
            companyDetailViewModel = new CompanyDetailViewModel();
            companyDetailViewModel.Name = result.Name;
            companyDetailViewModel.Description = result.Description;
            imageUploaded= result.ImgUrl;
            dialogBoxVisible = true;
        }
        else
        {
            Snackbar.Add("Firstly! Click On Desired Row");
        }
    }

    protected override async Task OnInitializedAsync()
    {
        Companies = (await companyService.GetAllCompaniesByUserId(UserId)).ToList();
        Layout.Uid = UserId;
        myService.CallRequestRefresh();

    }
    private bool FilterFunc(Company company)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (company.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    async Task HandleSelection(IFileListEntry[] files)
    {
        imageUploaded = null;
        file = files.FirstOrDefault();
        if (file != null)
        {
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            status = $"Finished loading {file.Size} bytes from {file.Name}";
            imageUploaded = ms.ToArray();
        }

    }
    private async void UpdateCompanyHandler()
    {
        companyDetailViewModel.UserId = long.Parse(UserId);

        companyDetailViewModel.Photo = imageUploaded;
        var res = (await companyService.UpdateCompany(companyDetailViewModel, selectedItem.Id));

        //dialogBoxVisible = false;
        Snackbar.Add("Company Updated successfully");
        Companies = (await companyService.GetAllCompaniesByUserId(UserId)).ToList();
    }
    private async void AddNewCompanyHandler()
    {
        companyDetailViewModel.UserId = long.Parse(UserId);
        companyDetailViewModel.Photo = imageUploaded;
        var res = (await companyService.AddNewCompany(companyDetailViewModel, UserId));
        //dialogBoxVisible = false;
        Snackbar.Add("Company added successfully");
        Companies = (await companyService.GetAllCompaniesByUserId(UserId)).ToList();

    }
    private string ConvertImageToDisplay(byte[] image)
    {
        if (image != null)
        {
            var base64 = Convert.ToBase64String(image);
            var fs = string.Format("data:image/jgp;base64,{0}", base64);
            return fs;
        }
        return "";
    }

    public async Task DeleteCompanyHandler()
    {
        if (selectedItem != null)
        {
            await companyService.DeleteCompany(selectedItem.Id);
            Snackbar.Add("Record Deleted");
            Companies = (await companyService.GetAllCompaniesByUserId(UserId)).ToList();
        }
        else
        {
            Snackbar.Add("Firstly! Click On Desired Row");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMyService myService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService companyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService Dialog { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
#pragma warning restore 1591
