<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ViewMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Regist
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="action_area">
    	<h2 class="action_type"><img src="Images/register.gif" alt="会员注册" /></h2>
        <form action="/User/Regist" method="post" class="member_form">
        	<p><label><span>*</span>用户名</label><input name="Name" type="text" class="opt_input" /><%= Html.ValidationMessage("Name") %></p>
            <p><label><span>*</span>密&#160;&#160;&#160;&#160;码</label><input name="LoginPwd" type="password" class="opt_input" /><%= Html.ValidationMessage("LoginPwd") %></p>
            <p><label><span>*</span>确认密码</label><input name="password" type="password" class="opt_input" />请再次输入密码</p>
            <p><label><span>*</span>电子邮件</label><input name="Mail" type="password" class="opt_input" />请输入电子邮件</p>
            <p><label><span>*</span>性&#160;&#160;&#160;&#160;别</label><input name="gender" type="password" class="opt_input" /></p>
            
            <p><label><span>*</span>验证码</label><input name="checkno" type="text" class="opt_input" style="width:60px;" /><img src="Images/checkno.gif" /> 请输入验证码</p>
            <p class="form_sub"><input type="checkbox" name=""  checked="checked" />  在此计算机上保留我的密码</p>
            <p class="form_sub"><input type="submit" value="确定了，马上提交" class="opt_sub" /></p>
            <p class="form_sub">加<span>*</span>的为必填项目</p>
            <p class="form_sub">><a href="login.html">已经有账号，马上登录</a><br />>如果你已经有“第三波书店”社区账号，请<a href="javascript:alert('书店社区暂未开通');">点这里</a>登录升级</p>
        </form>
    </div>
    




</asp:Content>
