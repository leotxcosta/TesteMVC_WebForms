<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="TesteMVC.Views.Shared.Menu" %>
<asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" IncludeStyleBlock="False" EnableViewState="False"></asp:Menu>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" SiteMapProvider="TesteSiteMapProvider" EnableViewState="False" ViewStateMode="Disabled" />
