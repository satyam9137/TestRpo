using System;
using System.Reflection.Emit;
using static System.Collections.Specialized.BitVector32;

@model Registration_Page.Models.RegisterViewModel

<h2> Register</h2>

<form asp-action= "Index" method= "post" >
    < div >
        < label asp-for="Username"></label>
        <input asp-for="Username" class= "form-control" />
        < span asp - validation -for= "Username" style = "color:red" ></ span >
    </ div >
    < div >
        < label asp -for= "Email" ></ label >
        < input asp -for= "Email" class= "form-control" />
        < span asp - validation -for= "Email" style = "color:red" ></ span >
    </ div >
    < div >
        < label asp -for= "Password" ></ label >
        < input asp -for= "Password" type = "password" class= "form-control" />
        < span asp - validation -for= "Password" style = "color:red" ></ span >
    </ div >
    < div >
        < label asp -for= "ConfirmPassword" ></ label >
        < input asp -for= "ConfirmPassword" type = "password" class= "form-control" />
        < span asp - validation -for= "ConfirmPassword" style = "color:red" ></ span >
    </ div >
    < button type = "submit" > Register </ button >
</ form >

@if(ViewBag.Message != null)
{
    < p style = "color:green" > @ViewBag.Message </ p >
}

@section Scripts
{
    @{ await Html.RenderPartialAsync("_ValidationScriptsPartial"); }
}
