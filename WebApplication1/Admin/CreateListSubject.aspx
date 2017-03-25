<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateListSubject.aspx.cs" Inherits="WebApplication1.Admin.CreateListSubject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Asignaturas </h2>

     <div class="form-horizontal">
        <h4>Crear una nueva asignatura para impartir </h4>
        <hr />
     
         <div class="form-group">
            <asp:Label ID="lblSubjectName" runat="server" Text="Asignatura" CssClass="col-md-2 control-label"></asp:Label>
             <div class="col-md-10" style="display:inline-flex">
                <asp:TextBox ID="txtSubjectName" runat="server"  CssClass="form-control" style="margin-top:0px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="required1" runat="server" ErrorMessage="Debe poner texto para la asignatura" Display="Dynamic" 
                ControlToValidate="txtSubjectName"> * </asp:RequiredFieldValidator>
            </div>
        </div>

         <div class="form-group">
            <asp:Label ID="lblHours" runat="server" Text="Horas" CssClass="col-md-2 control-label"></asp:Label>
             <div class="col-md-10" style="display:inline-flex">
                <asp:TextBox ID="txtHours" runat="server"  CssClass="form-control" style="margin-top:0px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe poner texto para las horas" Display="Dynamic" 
                ControlToValidate="txtHours"> * </asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
         <asp:Label ID="lblTeory" runat="server" Text="Elige la opcion para la clase teorica " CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
              <asp:DropDownList ID="ddTeory" runat="server" CssClass="form-control">
                  <asp:ListItem Value="0">Open</asp:ListItem>
                  <asp:ListItem Value="1">Close</asp:ListItem>
              </asp:DropDownList>
            </div>
         </div>

         <div class="form-group">
         <asp:Label ID="lblPractice" runat="server" Text="Elige la opcion para la clase practica " CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
              <asp:DropDownList ID="ddPractice" runat="server" CssClass="form-control">
                  <asp:ListItem Value="0">Laboratorio</asp:ListItem>
                  <asp:ListItem Value="1">Clase informatica</asp:ListItem>
                  <asp:ListItem Value="2">Close</asp:ListItem>
              </asp:DropDownList>
            </div>
         </div>

         <div class="form-group">
         <asp:Label ID="lblCourseType" runat="server" Text="Elige la opcion para el tipo de curso  " CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
              <asp:DropDownList ID="ddCourseType" runat="server" CssClass="form-control">
                  <asp:ListItem Value="0">CursoTeorico</asp:ListItem>
                  <asp:ListItem Value="1">CursoMedio</asp:ListItem>
                  <asp:ListItem Value="2">CursoSuperior</asp:ListItem>
                  <asp:ListItem Value="3">PostGrado</asp:ListItem>
              </asp:DropDownList>
            </div>
         </div>

         <div class="form-group">
         <asp:Label ID="lblTerm" runat="server" Text="Elige la opcion para el tipo de trimestre  " CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
              <asp:DropDownList ID="ddTerm" runat="server" CssClass="form-control">
                  <asp:ListItem Value="0">Primer</asp:ListItem>
                  <asp:ListItem Value="1">Segundo</asp:ListItem>
                  <asp:ListItem Value="2">Tercero</asp:ListItem>
              </asp:DropDownList>
            </div>
         </div>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
            <asp:Button ID="cmdSave" runat="server" Text="Guarda" OnClick="Button1_Click" CssClass="btn btn-default" />
            </div>
        </div>

    
        <div class="form-group">
            <asp:Label ID="lblResult" runat="server" CssClass="col-md-2 control-label"></asp:Label>
         </div>
    
   </div>
</asp:Content>
