<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Register.aspx.cs" Inherits="HealthMonitoringSystem_WebApp.Register" %>

<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">
    <div class="accountHeader">
    <h2>
        Create a New Account</h2>
    <p>Use the form below to create a new account.</p>
    <p>Passwords are required to be a minimum of <%= Membership.MinRequiredPasswordLength %> characters in length.</p>
</div>
    <dx:ASPxLabel ID="lblUserName" runat="server" AssociatedControlID="tbUserName" Text="User Name:" />
    <div class="form-field">
        <dx:ASPxTextBox ID="tbUserName" runat="server" Width="200px">
            <ValidationSettings ValidationGroup="RegisterUserValidationGroup">
                <RequiredField ErrorText="User Name is required." IsRequired="true" />
            </ValidationSettings>
        </dx:ASPxTextBox>
    </div>
    <dx:ASPxLabel AssociatedControlID="tbEmail" ID="lblEmail" runat="server" Text="E-mail:" />
    <div class="form-field">
        <dx:ASPxTextBox ID="tbEmail" runat="server" Width="200px">
            <ValidationSettings ValidationGroup="RegisterUserValidationGroup">
                <RequiredField ErrorText="E-mail is required." IsRequired="true" />
                <RegularExpression ErrorText="Email validation failed" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
            </ValidationSettings>
        </dx:ASPxTextBox>
    </div>
    <dx:ASPxLabel AssociatedControlID="tbPassword" ID="lblPassword" runat="server" Text="Password:" />
    <div class="form-field">
        <dx:ASPxTextBox ID="tbPassword" ClientInstanceName="Password" Password="true" runat="server"
            Width="200px">
            <ValidationSettings ValidationGroup="RegisterUserValidationGroup">
                <RequiredField ErrorText="Password is required." IsRequired="true" />
            </ValidationSettings>
        </dx:ASPxTextBox>
    </div>
    <dx:ASPxLabel ID="lblConfirmPassword" runat="server" AssociatedControlID="tbConfirmPassword"
                  Text="Confirm password:"></dx:ASPxLabel>
    <div class="form-field">
        <dx:ASPxTextBox ID="tbConfirmPassword" Password="true" runat="server" Width="200px">
            <ValidationSettings ValidationGroup="RegisterUserValidationGroup">
                <RequiredField ErrorText="Confirm Password is required." IsRequired="true" />
            </ValidationSettings>
            <ClientSideEvents Validation="function(s, e) {
                var originalPasswd = Password.GetText();
                var currentPasswd = s.GetText();
                e.isValid = (originalPasswd  == currentPasswd );
                e.errorText = 'The Password and Confirmation Password must match.';
            }" />
        </dx:ASPxTextBox>
    </div>
    <dx:ASPxButton ID="btnCreateUser" runat="server" Text="Create User" ValidationGroup="RegisterUserValidationGroup"
        OnClick="btnCreateUser_Click">
    </dx:ASPxButton>
</asp:content>