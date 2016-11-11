<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<List<Model.Categories>>" %>
  
<%
    foreach (var item in Model)
    {
        %>
    <%--<li><%Html.ActionLink(item.Name, "BookList", "Books", new { ID = item.ID }); %></li>-->--%>
     <li><a href="/Books/BookList/<%=item.ID %>"><%=item.Name %></a></li>
<%
    }
     %>
