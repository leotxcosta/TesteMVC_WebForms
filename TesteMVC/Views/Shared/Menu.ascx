<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="TesteMVC.Views.Shared.Menu" %>
<%@ Register Assembly="TesteMVC" Namespace="TesteMVC" TagPrefix="cc1" %>
<cc1:CSSMenu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" IncludeStyleBlock="False" EnableViewState="False" EnableTheming="False" ItemWrap="True" Orientation="Horizontal" RenderingMode="List" ValidateRequestMode="Disabled" ViewStateMode="Disabled">
</cc1:CSSMenu>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" SiteMapProvider="TesteSiteMapProvider" EnableViewState="False" ViewStateMode="Disabled" ShowStartingNode="False" />
