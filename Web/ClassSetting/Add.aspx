<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="JiaJiao.Web.ClassSetting.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                <table cellspacing="0" cellpadding="0" width="100%" border="0">
                    <tr>
                        <td height="25" width="30%" align="right">
                            老师 ：
                        </td>
                        <td height="25" width="*" align="left">
                            <asp:DropDownList ID="ddlTeacher" DataTextField="TeacherName" DataValueField="ID" runat="server">
                            </asp:DropDownList>
                          
                        </td>
                    </tr>
                    <tr>
                        <td height="25" width="30%" align="right">
                            开班星期 ：
                        </td>
                        <td height="25" width="*" align="left">
                            <asp:DropDownList ID="ddlDay" runat="server" AutoPostBack=true
                                onselectedindexchanged="ddlDay_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <td height="25" width="30%" align="right">
                            开班时间 ：
                        </td>
                        <td height="25" width="*" align="left">
                            <asp:DropDownList ID="ddlTime" DataTextField="Time" DataValueField="ID" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td height="25" width="30%" align="right">
                            开班人数 ：
                        </td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtTotal" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td height="25" width="30%" align="right">
                            已报名人数 ：
                        </td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtCount" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <script src="/js/calendar1.js" type="text/javascript"></script>
            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" class="inputbutton"
                    onmouseover="this.className='inputbutton_hover'" onmouseout="this.className='inputbutton'">
                </asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消" OnClick="btnCancle_Click" class="inputbutton"
                    onmouseover="this.className='inputbutton_hover'" onmouseout="this.className='inputbutton'">
                </asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
