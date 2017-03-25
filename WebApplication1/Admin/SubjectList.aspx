<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubjectList.aspx.cs" Inherits="WebApplication1.Admin.SubjectList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="<%: ResolveUrl( "~/Content/DataTables/css/jquery.dataTables.css" )%>" rel="stylesheet" />
    <script src="<%: ResolveUrl("~/Scripts/DataTables/jquery.dataTables.js")%>"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $('#MainContent_GridView1').DataTable({
                "oLanguage": { "sUrl": "//cdn.datatables.net/plug-ins/1.10.13/i18n/Spanish.json" },
                "columnDefs": [
                    {

                        "targets": 0

                    },
                    { "title": "ID", "targets": 1 },
                    { "title": "Nombre asignatura", "targets": 2 },
                    { "title": "Horas", "targets": 3 },
                    { "title": "Estado clase teoria", "targets": 4 },
                    { "title": "Estado clase practica", "targets": 5 },
                    { "title": "Profesor asignado", "targets": 6 }

                ]
            });

        });
    </script>

    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="SubjectName" HeaderText="SubjectName" SortExpression="SubjectName" />
            <asp:BoundField DataField="Horas" HeaderText="Horas" SortExpression="Horas" />
            <asp:BoundField DataField="TeoryClassStatus" HeaderText="TeoryClassStatus" SortExpression="TeoryClassStatus" />
            <asp:BoundField DataField="PracticeClassType" HeaderText="PracticeClassType" SortExpression="PracticeClassType" />
            <asp:BoundField DataField="TeacherName" HeaderText="TeacherName" SortExpression="TeacherName" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="WebApplication1.Admin.SubjectList"></asp:ObjectDataSource>

</asp:Content>
