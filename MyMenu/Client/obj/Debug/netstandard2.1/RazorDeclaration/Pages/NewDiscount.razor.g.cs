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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/newdiscount/{companyid}")]
    public partial class NewDiscount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "D:\new project\MyMenu\Client\Pages\NewDiscount.razor"
       
    [Parameter]
    public string CompanyId { get; set; }
    private List<DaysOfWeek> weekdays { get; set; } = new List<DaysOfWeek>();
    private DaysOfWeek days { get; set; } = new DaysOfWeek();
    private List<DiscountPeriods> discountList { get; set; } = new List<DiscountPeriods>();
    private List<DiscountTransaction> discounttransactionList { get; set; } = new List<DiscountTransaction>();
    private DiscountViewModel discountViewModel { get; set; } = new DiscountViewModel();
    bool buttonShow = false;
    MudTimePicker _picker;
    MudTimePicker _picker1;
    MudTimePicker _picker2;
    MudTimePicker _picker3;
    private string date = DateTime.Now.ToString("yyyy-MM-dd");
    private string dateTo = DateTime.Now.ToString("yyyy-MM-dd");
    string fromtime = null;
    string totime = null;
    string displaytimefrom = null;
    TimeSpan? time = new TimeSpan(00, 45, 00);
    bool Checked = false;

    public List<int> CheckedValue { get; set; } = new List<int>();


    protected override async Task OnInitializedAsync()
    {
        weekdays = (await discountDayService.GetAllDays()).ToList();
        discountList = (await discountService.GetAllDiscountByCompanyId(CompanyId)).ToList();
    }
    private bool dense = false;
    private bool hover = true;
    private bool ronly = false;
    private string searchString = "";
    private DiscountPeriods selectedItem = null;

    // Dialog Box
    private bool visible;
    private int rating;
    private void OpenDialog()
    {
        visible = true;
    }
    void Submit() => visible = false;



    private bool FilterFunc(DiscountPeriods discount)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (discount.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    void CheckboxClicked(int CheckID, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            if (!CheckedValue.Contains(CheckID))
            {
                CheckedValue.Add(CheckID);
            }
        }
        else
        {
            if (CheckedValue.Contains(CheckID))
            {
                CheckedValue.Remove(CheckID);
            }
        }
    }
    public async Task AddDiscountRecord()
    {
        selectedItem = null;
        discountViewModel.FromDate = Convert.ToDateTime(date);
        discountViewModel.ToDate = Convert.ToDateTime(dateTo);
        discountViewModel.FromTime = Convert.ToDateTime(fromtime);
        discountViewModel.ToTime = Convert.ToDateTime(totime);
        discountViewModel.CompanyId = int.Parse(CompanyId);

        if (CheckedValue != null)
        {
            foreach (var list in CheckedValue)
            {
                discountViewModel.DaysIdList.Add(list);
            }
        }
        await discountService.AddNewDiscount(discountViewModel);
        Snackbar.Add("Discount added successfully");
        discountList = (await discountService.GetAllDiscountByCompanyId(CompanyId)).ToList();
    }
    public void ResetForm()
    {
        buttonShow = false;
        selectedItem = null;
        date = DateTime.Now.ToString("yyyy-MM-dd");
        dateTo = date;
        fromtime = DateTime.Now.ToString("hh:mm tt");
        totime = DateTime.Now.ToString("hh:mm tt");
        discountViewModel.Name = null;
        CheckedValue = new List<int>();
    }
    private async Task GetEditRecord()
    {

        if (selectedItem != null)
        {
            buttonShow = true;
            var result = await discountService.GetDiscountById(selectedItem.Id);
            discounttransactionList = (await discountService.GetDiscountTransactionByDiscountId(selectedItem.Id)).ToList();
            discountViewModel = new DiscountViewModel();
            discountViewModel.Name = result.Name;
            date = result.FromDate.ToString("yyyy-MM-dd");
            dateTo = result.FromDate.ToString("yyyy-MM-dd");
            fromtime = result.FromTime.ToString("hh:mm tt");
            totime = result.ToTime.ToString("hh:mm tt");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 274 "D:\new project\MyMenu\Client\Pages\NewDiscount.razor"
             foreach (var list in discounttransactionList)
            {
                CheckedValue.Add(list.DayId);
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 277 "D:\new project\MyMenu\Client\Pages\NewDiscount.razor"
             
        }
        else
        {
            Snackbar.Add("Firstly! Click On Desired Row");
        }
    }
    public async Task EditDiscountRecord()
    {
        discountViewModel.CompanyId = int.Parse(CompanyId);
        discountViewModel.FromDate = DateTime.Parse(date);
        discountViewModel.ToDate = DateTime.Parse(dateTo);
        discountViewModel.FromTime = DateTime.Parse(fromtime);
        discountViewModel.ToTime = DateTime.Parse(totime);
        if (CheckedValue != null)
        {
            foreach (var list in CheckedValue)
            {
                discountViewModel.DaysIdList.Add(list);
            }
        }
        await discountService.UpdateDiscount(discountViewModel, selectedItem.Id);
        Snackbar.Add("Discount Updated successfully");
        discountList = (await discountService.GetAllDiscountByCompanyId(CompanyId)).ToList();
    }

    public async Task DeleteDiscountHandler()
    {
        if (selectedItem != null)
        {
            await discountService.DeleteDiscount(selectedItem.Id);
            Snackbar.Add("Record Deleted");
            discountList = (await discountService.GetAllDiscountByCompanyId(CompanyId)).ToList();
        }
        else
        {
            Snackbar.Add("Firstly! Click On Desired Row");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDiscountService discountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDiscountDayService discountDayService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
#pragma warning restore 1591
