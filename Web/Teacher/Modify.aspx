﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="JiaJiao.Web.Teacher.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTeacherName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTeacherTel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Email
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTeacherEmail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTeacherAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		简介
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTeacherDescribe" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	    <tr>
                        <td height="25" width="30%" align="right">
                            角色 ：
                        </td>
                        <td height="25" width="*" align="left">
                            <asp:DropDownList ID="DropDownList1" DataValueField="RoleID" DataTextField="Description"
                                runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td height="100" width="30%" align="right">
                            肖像 ：
                        </td>
                    
                        <td height="100" width="*" align="left">
                           <input id="fileUpLoad" type="file" runat="server" width="0"   onchange="javascript:PreviewImg(this);" /> 
                      
                        </td>
                    </tr>
               
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

