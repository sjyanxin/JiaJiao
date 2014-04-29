
<%@ Page Title="Class" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="StudentReg.aspx.cs" Inherits="JiaJiao.Web.Teacher.StudentReg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Title -->

    <!--Title end -->

    <!--Add  -->

    <!--Add end -->

    <!--Search -->
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr align="center">
         
            <td class="tdbg">
               
                <asp:Label ID="Label1" runat="server" Text="学 号："></asp:Label>
               
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
               
            </td>
         
        </tr>
          <tr align="center">
         
            <td class="tdbg">
               
                <asp:Label ID="Label2" runat="server" Text="验证码："></asp:Label>
               
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               
            </td>
           
        </tr>
         <tr align="center">
         
            <td class="tdbg">
               
                 <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="报名" />
               
            </td>
           
        </tr>
    </table>
    <!--Search end-->
  
    <br />
  

</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
