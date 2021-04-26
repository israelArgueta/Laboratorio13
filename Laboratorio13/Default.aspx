<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio13._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class ="row">

    <div class ="row">
        <div class ="col-xs-3" style="left:0px; top:0px">
            nombre:
            <asp:TextBox ID="nom" runat="server" >

            </asp:TextBox> 
            
            </div>
            <div class ="col-xs-3">
                apellido:
                <asp:TextBox ID="ape" runat ="server">
                   </asp:TextBox> 
            
            
                </div>
            <div class ="col-xs-3">
                direccion:
                <asp:TextBox ID="direc" runat ="server">
                   </asp:TextBox> 
                </div>
       
        </div>
        
     <br /> 
        <div class="col-xs-3">
            fecha de nacimiento:
            <asp:Calendar ID="fecha" runat ="server" >
                </asp:Calendar>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-3">
                <asp:RadioButton ID="ra" runat ="server" Text="Estudiante" GroupName="grupo" OnCheckedChanged="ra_CheckedChanged"/>
                
                </div>
             <div class="col-xs-3">
                <asp:RadioButton ID="ra2" runat ="server" Text="Maestros" GroupName="grupo"/>
                
                </div>
             <div class="col-xs-3">
                <asp:RadioButton ID="ra3" runat ="server" Text="Personal Administrativo" GroupName="grupo"/>
                
                </div>
             <div class="col-xs-3">
                <asp:Button ID="sele" runat ="server" Text="Aceptar" OnClick="sele_Click"/>
                
                </div>
            </div>
    <div class="row">
        <div class="col-xs-3">
            <asp:Label ID ="lo" runat="server" Text="" Visible="False" ForeColor="#000099"></asp:Label>
            </div>
        <br/>
        <div class="col-xs-3">
            <asp:Label ID ="ca" runat="server" Text="" Visible="False" ForeColor="#000099"></asp:Label>
            </div>
        <div class="col-xs-3">
            <asp:TextBox ID ="va" runat="server" Visible="False" ></asp:TextBox>
            </div>
        <div class="col-xs-3">
            <asp:Label ID ="la" runat="server" Text="" Visible="False" ForeColor="#000099"></asp:Label>
            </div>
        <div class="col-xs-3">
            <asp:TextBox ID ="mos" runat="server" Visible="False" ></asp:TextBox>
            </div>
        <br/>
        <div class="col-xs-3">
            <asp:Label ID="labor" runat ="server" Text="Fecha Inicial De Labores" Visible ="false" >
                </asp:Label>
             <asp:Calendar ID="inicio" runat ="server" Visible="false" >
                </asp:Calendar>
            </div>
         <div class="col-xs-3">
            <asp:Label ID="final" runat ="server" Text="Fecha Final De Labores" Visible ="false" >
                </asp:Label>
             <asp:Calendar ID="laborfinal" runat ="server" Visible="false" >
                </asp:Calendar>
            </div>
        </div>
     <div class="col-xs-3">
                <asp:Button ID="Agre" runat ="server" Text="Agregar" OnClick="Agre_Click"/>
                
                </div>


</asp:Content>
