<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="GirlMobContactList.WebUserControl1" %>
    <div>
       <asp:Label ID="LabelFirstName" runat="server" Text="First name"></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LabelLastname" runat="server" Text="Last name"></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LabelSSN" runat="server" Text="SSN"></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="TextBoxSSN" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="ButtonChangeable" runat="server" Text="Button" />
    </div>
<asp:Label ID="LabelError" Text="" ForeColor="Red" runat="server" Font-Bold="False" />
<asp:Label ID="LabelInfo" Text="" ForeColor="Green" runat="server" Font-Bold="False" />