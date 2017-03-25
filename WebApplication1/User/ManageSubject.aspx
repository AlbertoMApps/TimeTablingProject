<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageSubject.aspx.cs" Inherits="WebApplication1.User.ManageSubject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="<%: ResolveUrl( "~/Content/DataTables/css/jquery.dataTables.css" )%>" rel="stylesheet" />
    <script src="<%: ResolveUrl("~/Scripts/DataTables/jquery.dataTables.js")%>"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $('#MainContent_GridView1').DataTable({
                "oLanguage": { "sUrl": "//cdn.datatables.net/plug-ins/1.10.13/i18n/Spanish.json" },
                "columnDefs" : [
                    { 

                        "targets" : 0

                    },
                    {"title" : "Horas a trabajar ", "targets": 1},
                    {"title" : "Nombre del profesor", "targets": 2},
                    { "title": "Dia de la semana", "targets": 3 },
                    { "title": "Comentario", "targets": 4 },
                    {"title" : "ID de asignatura", "targets": 5},
                    {"title" : "ID Profesor", "targets": 6 }

                ]
            });

        });
     </script>


     <h2>Detalles de asignatura por semana</h2>
    <p class="danger">
        <asp:Literal runat="server" ID="ErrorMessage"></asp:Literal>
    </p>

     <div class="form-horizontal">
        <h4>Rellena los campos por dia </h4>
        <hr />

         <div class="form-group">
                <asp:Label ID="lblTotalHours" runat="server" Text="Horas a trabajar en total" CssClass="col-md-2 control-label"></asp:Label>
                 <div class="col-md-10" style="display:inline-flex">
                    <asp:TextBox ID="txtTotalHours" runat="server"  CssClass="form-control" style="margin-top:0px" Enabled="false"></asp:TextBox>
                </div>
        </div>

        <div class="form-group">
                <asp:Label ID="lblHours" runat="server" Text="Horas a trabajar" CssClass="col-md-2 control-label"></asp:Label>
                 <div class="col-md-10" style="display:inline-flex">
                    <asp:TextBox ID="txtHours1" runat="server"  CssClass="form-control" style="margin-top:0px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="required1" runat="server" ErrorMessage="Debe poner texto para saber las horas de imparticion" Display="Dynamic" 
                         ControlToValidate="txtHours1"> * </asp:RequiredFieldValidator>
                </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblTeacherName" runat="server" Text="Nombre del profesor " CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10" style="display:inline-flex">
                <asp:TextBox ID="txtTeacherName" runat="server"  CssClass="form-control" style="margin-top:0px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe poner su nombre" Display="Dynamic" 
                         ControlToValidate="txtTeacherName"> * </asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblDayOfWeek" runat="server" Text="Dia de la semana " CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10" style="display:inline-flex">
                <asp:DropDownList ID="ddDayOfWeek" runat="server" CssClass="form-control" >
                    <asp:ListItem Value="0">Lunes</asp:ListItem>
                    <asp:ListItem Value="1">Martes</asp:ListItem>
                    <asp:ListItem Value="2">Miercoles</asp:ListItem>
                    <asp:ListItem Value="3">Jueves</asp:ListItem>
                    <asp:ListItem Value="4">Viernes</asp:ListItem>
                </asp:DropDownList>
                <br />
         </div>

         <div class="form-group">
            <asp:Label ID="lblComment" runat="server" Text="Comentario sobre horas y aulas " CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10" style="display:inline-flex">
                <asp:TextBox ID="txtComment" runat="server"  CssClass="form-control" style="margin:10px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe poner su comentario" Display="Dynamic" 
                         ControlToValidate="txtComment"> * </asp:RequiredFieldValidator>
            </div>
        </div>

         <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="cmdSave" runat="server" Text="Agrega" OnClick="btnSave_Click" CssClass="btn btn-default" style="margin-top:10px;"/>
                <a href="ListSubjects" style="margin: 20px; position: absolute;">Volver</a>
            </div>
        </div>

            <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id"></asp:BoundField>
                    <asp:BoundField DataField="NumHoras" HeaderText="NumHoras" SortExpression="NumHoras"></asp:BoundField>
                    <asp:BoundField DataField="TeacherName" HeaderText="TeacherName" SortExpression="TeacherName"></asp:BoundField>
                    <asp:BoundField DataField="DayOfWeekType" HeaderText="DayOfWeekType" SortExpression="DayOfWeekType"></asp:BoundField>
                    <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message"></asp:BoundField>
                    <asp:BoundField DataField="Subject_Id" HeaderText="Subject_Id" SortExpression="Subject_Id"></asp:BoundField>
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
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="WebApplication1.User.ManageSubject">
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="" Name="subjectId" QueryStringField="subjectId" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>

         </div>

     </div>
</asp:Content>
