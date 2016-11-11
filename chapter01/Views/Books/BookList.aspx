<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ViewMaster.Master" Inherits="System.Web.Mvc.ViewPage<List<Books>>" %>
<%@ Import Namespace="Model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    BookList
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(function () {
            $("select").change(function () {
               
                location.href = "/Books/BookList/<%=Model[0].CategrayId%>?oName=" + $(this).val();
            })
        })
    </script>
     <div class="main">
         <div class="list_asc">
        	<!--choice order type-->
            <div class="type_choice f_left">
            	排序方式
                <select name="list_type">
                    <option value="clicks">按销量 排序</option>
                    <option value="publishdate">按出版日期 排序</option>
                    <option value="UnitPrice">按价格 排序</option>
                </select>
            </div>
            <!--page no-->
            <div class="turn_area f_right">
            	<span id="turn_pre"><<</span>
                <span id="turn_page">第一页</span>
                <span id="turn_next">>></span>
            </div>
            
        </div>
    <%
        foreach (Books item in Model)
        {
            %>
     <dl class="list_area">
        	<dt><a href="/Books/BookDetail/<%=item.ID %>"><img src="<%= Url.Content("~/images/books_01.gif") %>" width="100" height="100"  alt="暮光之城" /></a></dt>
            <dd>
            	<h2 class="b_title"><a href="#"><%=item.Title %></a></h2>
                <!--将书籍的id 写入span-->
                <div class="b_score">顾客评分：<span id="book_id_15">5</span></div>
                <div class="b_property">作者：<%=item.Author %><br />出版社：科学出版社<br />出版时间：<%=item.PublishDate %></div>
                <h4 class="b_intro"><%=item.ContentDescription %></h4>
                <div class="b_buy">
                	<span class="gray del">￥<%=item.UnitPrice %></span>　<span class="red">￥26.30</span>　折扣：75折　节省：￥8.70
                    <img src="<%= Url.Content("~/Images/btn_goumai.gif")%>" onmouseover="this.src='<%= Url.Content("~/Images/btn_goumai_click.gif")%>'" />
                    <img src="<%= Url.Content("~/Images/btn_zancun.gif")%>" onmouseover="this.src='<%= Url.Content("~/Images/btn_zancun_click.gif")%>'" />
                </div>
            </dd>
        </dl>
    <%
        }
         %>

         </div>

</asp:Content>
