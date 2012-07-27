<%@ Page Title="" Language="C#"
    MasterPageFile="~/Views/Shared/Site.Master"
    Inherits="System.Web.Mvc.ViewPage<ShowPostModel>" %>
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
            <%= Html.Encode(Model.Post.Id) %>
        </p>
        <p>
            Content:
            <%= Html.Encode(Model.Post.Content) %>
        </p>
        <p>
            Title:
            <%= Html.Encode(Model.Post.Title) %>
        </p>
    </fieldset>
    <p>
    <%=Html.ActionLink("Edit", "Edit", new { PostID=Model.Post.Id }) %> |
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

