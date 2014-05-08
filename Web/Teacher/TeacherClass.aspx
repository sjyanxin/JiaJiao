﻿<%@ Page Title="Class" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="TeacherClass.aspx.cs" Inherits="JiaJiao.Web.Teacher.TeacherClass" %>

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

            <td class="tdbg" colspan=2>

                <asp:Label ID="Label1" runat="server" Font-Bold=true Font-Size=XX-Large  Text=""></asp:Label>

            </td>

        </tr>
        <tr align="center">

            <td class="tdbg" height="100" width="100">

               
                <asp:Image ID="Image1" runat="server" />

            </td>
                <td class="tdbg">

                <asp:Label ID="Label2" runat="server" Font-Size=Medium Text=""></asp:Label>

            </td>
        </tr>
    </table>
    <!--Search end-->
    <br />
    <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"
        BorderWidth="1px" OnRowDataBound="gridView_RowDataBound"
        AutoGenerateColumns="false" RowStyle-HorizontalAlign="Center">
        <Columns>
           <%-- <asp:BoundField DataField="Time0" HeaderText="星期" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time1" HeaderText="8-10" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time2" HeaderText="10-12" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time3" HeaderText="12-14" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time4" HeaderText="14-16" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time5" HeaderText="16-18" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time6" HeaderText="18-20" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time7" HeaderText="20-22" ItemStyle-HorizontalAlign="Center" />--%>
            <asp:BoundField DataField="Day" HeaderText="星期" ItemStyle-HorizontalAlign="Center" />
            <asp:HyperLinkField HeaderText="8-10"  ControlStyle-Width="50"  DataTextField ="Time1" />
            <asp:HyperLinkField HeaderText="10-12" ControlStyle-Width="50"  DataTextField="Time2" />
            <asp:HyperLinkField HeaderText="12-14" ControlStyle-Width="50"  DataTextField="Time3" />
            <asp:HyperLinkField HeaderText="14-16" ControlStyle-Width="50"  DataTextField="Time4" />
            <asp:HyperLinkField HeaderText="16-18" ControlStyle-Width="50"  DataTextField="Time5" />
            <asp:HyperLinkField HeaderText="18-20" ControlStyle-Width="50"  DataTextField="Time6" />
            <asp:HyperLinkField HeaderText="20-22" ControlStyle-Width="50"  DataTextField="Time7" />

        </Columns>
    </asp:GridView>

</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
