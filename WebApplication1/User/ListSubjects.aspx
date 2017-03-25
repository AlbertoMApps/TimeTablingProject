<%@ Page Title="List Subjects" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListSubjects.aspx.cs" Inherits="WebApplication1.User.ListSubjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="<%: ResolveUrl( "~/Content/DataTables/css/jquery.dataTables.css" )%>" rel="stylesheet" />
    <script src="<%: ResolveUrl("~/Scripts/DataTables/jquery.dataTables.js")%>"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $('#MainContent_GridView1').DataTable({
                "oLanguage": { "sUrl": "//cdn.datatables.net/plug-ins/1.10.13/i18n/Spanish.json" },
                "columnDefs" : [
                    { 
                        "render" : function (data, type, row ) {
                            return "<a href='ManageSubject?subjectId=" +  data + "'>" + data + "</a>";
                        },

                        "targets" : 0

                    },
                    {"title" : "Nombre de asignatura", "targets": 1},
                    {"title" : "Horas", "targets": 2},
                    {"title" : "Clase teorica", "targets": 3},
                    {"title" : "Clase practica", "targets": 4 },
                    {"title" : "Tipo de curso", "targets": 5 },
                    { "title": "Trimestre", "targets": 6 },
                    { "title": "ID Profesor", "targets": 7 }

                ]
            });

        });

    </script>

    <div style="margin-top:10px; margin-bottom:10px; ">
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" BackColor="White" 
            BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="SubjectName" HeaderText="SubjectName" SortExpression="SubjectName" />
                <asp:BoundField DataField="Horas" HeaderText="Horas" SortExpression="Horas" />
                <asp:BoundField DataField="TeoryClassStatus" HeaderText="TeoryClassStatus" SortExpression="TeoryClassStatus" />
                <asp:BoundField DataField="PracticeClassType" HeaderText="PracticeClassType" SortExpression="PracticeClassType" />
                <asp:BoundField DataField="CourseType" HeaderText="CourseType" SortExpression="CourseType" />
                <asp:BoundField DataField="TermType" HeaderText="TermType" SortExpression="TermType" />
                <asp:BoundField DataField="ApplicationUser_Id" HeaderText="ApplicationUser_Id" SortExpression="ApplicationUser_Id" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="WebApplication1.User.ListSubjects"></asp:ObjectDataSource>
    </div>

    
</asp:Content>
