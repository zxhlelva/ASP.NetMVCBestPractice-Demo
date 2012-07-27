<%@ Page Title="" Language="C#"
    MasterPageFile="~/Views/Shared/Site.Master"
    Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="MvcBestPractices.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Page</h2>

    <fieldset>
        <legend>Fields</legend>
        <p>
            Id:
            <%= Html.Encode(((Post)ViewData["post"]).Id) %>
        </p>
        <p>
            Content:
            <%= Html.Encode(((Post)ViewData["post"]).Content)%>
        </p>
        <p>
            Title:
            <%= Html.Encode(((Post)ViewData["post"]).Title)%>
        </p>
    </fieldset>
    <p>
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

