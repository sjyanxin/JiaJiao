<%@ Page Title="Class" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Class.aspx.cs" Inherits="JiaJiao.Web.Class.Class" %>

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
        <tr>
          <%
              foreach (var item in teachers)
              {%>
                <a href="../teacher/TeacherClass.aspx?id=<%= item.ID%>">  <%=item.TeacherName %></a>
            <%  }
               %>
            <td class="tdbg">
               
            </td>
            <td class="tdbg"></td>
        </tr>
    </table>
    <!--Search end-->
    <br />
    <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3" 
        BorderWidth="1px" 
        AutoGenerateColumns="false" RowStyle-HorizontalAlign="Center" >
        <Columns>
            <asp:BoundField DataField="Day" HeaderText="星期" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time1" HeaderText="8-10" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time2" HeaderText="10-12" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time3" HeaderText="12-14" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time4" HeaderText="14-16" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time5" HeaderText="16-18" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time6" HeaderText="18-20" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Time7" HeaderText="20-22" ItemStyle-HorizontalAlign="Center" />


        </Columns>
    </asp:GridView>

</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
