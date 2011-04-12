<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Monitoreo de Rutas</title>
    <link href="css/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <div id="headder">Administrador de Catalogos - Monitoreo de Rutas</div>
        <div id="middle" >
            <div class="catalogs_section">
                <div class="catalogs1">
                    <div class="catalogs_title"><p>Rutas</p></div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Ruta_Nombre" runat="server" Width="110px" Height="35px" Text="Nombre" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Ruta_Nombre" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:DropDownList ID="DDL_Rutas" runat="server" Width="295px" Height="28px" 
                            onselectedindexchanged="DDL_Rutas_SelectedIndexChanged" 
                            AutoPostBack="True"></asp:DropDownList>
                        <asp:Button ID="Btn_Ruta_Limpiar" runat="server" Width="145px" Height="35px" 
                            Text="Limpiar" onclick="Btn_Ruta_Limpiar_Click" />
                        <asp:Button ID="Btn_Ruta_Borrar" runat="server" Width="145px" Height="35px" 
                            Text="Borrar" onclick="Btn_Ruta_Borrar_Click"/>
                        <asp:Button ID="Btn_Ruta_Guardar" runat="server" Width="145px" Height="35px" 
                            Text="Guardar" onclick="Btn_Ruta_Guardar_Click"/>
                        <asp:Button ID="Btn_Ruta_Modificar" runat="server" Width="145px" Height="35px" 
                            Text="Modificar" onclick="Btn_Ruta_Modificar_Click"/>
                    </div>
                    
                </div>
                <div class="catalogs1">
                    <div class="catalogs_title"><p>Autobuses</p></div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Autobus_Numero" runat="server" Width="110px" Height="35px" Text="Numero" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Autobus_Numero" runat="server" Width="180px" Height="25px"></asp:TextBox>                  
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Autobus_Asientos" runat="server" Width="110px" Height="35px" Text="Asientos" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Autobus_Asientos" runat="server" Width="180px" Height="25px"></asp:TextBox>                  
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Autobus_Capacidad" runat="server" Width="110px" Height="35px" Text="Capacidad" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Autobus_Capacidad" runat="server" Width="180px" Height="25px"></asp:TextBox>                  
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Autobus_Chofer" runat="server" Width="110px" Height="35px" Text="Chofer" style="margin-top:5px"></asp:Label>
                        <asp:DropDownList ID="DDL_Autobus_Chofer" runat="server" Width="185px" Height="28px"></asp:DropDownList>                  
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Autobus_Ruta" runat="server" Width="110px" Height="35px" Text="Ruta" style="margin-top:5px"></asp:Label>
                        <asp:DropDownList ID="DDL_Autobus_Ruta" runat="server" Width="185px" Height="28px"></asp:DropDownList>                  
                    </div>
                    <div class="catalogs_row">
                        <asp:DropDownList ID="DDL_Autobuses" runat="server" Width="295px" Height="28px" 
                            onselectedindexchanged="DDL_Autobuses_SelectedIndexChanged" 
                            AutoPostBack="True"></asp:DropDownList>
                        <asp:Button ID="Btn_Autobus_Limpiar" runat="server" Width="145px" Height="35px" 
                            Text="Limpiar" onclick="Btn_Autobus_Limpiar_Click" />
                        <asp:Button ID="Btn_Autobus_Borrar" runat="server" Width="145px" Height="35px" 
                            Text="Borrar" onclick="Btn_Autobus_Borrar_Click"/>
                        <asp:Button ID="Btn_Autobus_Guardar" runat="server" Width="145px" Height="35px" 
                            Text="Guardar" onclick="Btn_Autobus_Guardar_Click"/>
                        <asp:Button ID="Btn_Autobus_Modificar" runat="server" Width="145px" 
                            Height="35px" Text="Modificar" onclick="Btn_Autobus_Modificar_Click"/>
                    </div>
                </div>
                <div class="catalogs1">
                    <div class="catalogs_title"><p>Terminales</p></div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Terminal_Numero" runat="server" Width="110px" Height="35px" Text="Numero" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Terminal_Numero" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Terminal_Nombre" runat="server" Width="110px" Height="35px" Text="Nombre" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Terminal_Nombre" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Terminal_Colonia" runat="server" Width="110px" Height="35px" Text="Colonia" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Terminal_Colonia" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Terminal_Ciudad" runat="server" Width="110px" Height="35px" Text="Ciudad" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Terminal_Ciudad" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Terminal_Estado" runat="server" Width="110px" Height="35px" Text="Estado" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Terminal_Estado" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Terminal_CP" runat="server" Width="110px" Height="35px" Text="C.P." style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Terminal_CP" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Terminal_Ruta" runat="server" Width="110px" Height="35px" Text="Ruta" style="margin-top:5px"></asp:Label>  
                        <asp:DropDownList ID="DDL_Terminal_Rutas" runat="server" Width="180px" Height="25px"></asp:DropDownList>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:DropDownList ID="DDL_Terminales" runat="server" Width="295px" 
                            Height="28px" onselectedindexchanged="DDL_Terminales_SelectedIndexChanged" 
                            AutoPostBack="True"></asp:DropDownList>
                        <asp:Button ID="Btn_Terminal_Limpiar" runat="server" Width="145px" Height="35px" 
                            Text="Limpiar" onclick="Btn_Terminal_Limpiar_Click" />
                        <asp:Button ID="Btn_Terminal_Borrar" runat="server" Width="145px" Height="35px" 
                            Text="Borrar" onclick="Btn_Terminal_Borrar_Click"/>
                        <asp:Button ID="Btn_Terminal_Guardar" runat="server" Width="145px" 
                            Height="35px" Text="Guardar" onclick="Btn_Terminal_Guardar_Click"/>
                        <asp:Button ID="Btn_Terminal_Modificar" runat="server" Width="145px" 
                            Height="35px" Text="Modificar" onclick="Btn_Terminal_Modificar_Click"/>
                    </div>
                </div>
            </div>
            <div class="catalogs_section">
                <div class="catalogs2">
                    <div class="catalogs_title"><p>Choferes</p></div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Chofer_Nombre" runat="server" Width="110px" Height="35px" Text="Nombre" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Chofer_Nombre" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="LBL_Chofer_Apellidos" runat="server" Width="110px" Height="35px" Text="Apellidos" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Chofer_Apellidos" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Chofer_Edad" runat="server" Width="110px" Height="35px" Text="Edad" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="Tbox_Chofer_Edad" runat="server" Width="180px" Height="25px"></asp:TextBox>                  
                    </div>
                    <div class="catalogs_row">
                        <asp:DropDownList ID="DDL_Choferes" runat="server" Width="295px" Height="28px" 
                            onselectedindexchanged="DDL_Choferes_SelectedIndexChanged" 
                            AutoPostBack="True"></asp:DropDownList>
                        <asp:Button ID="Btn_Chofer_Limpiar" runat="server" Width="145px" Height="35px" 
                            Text="Limpiar" onclick="Btn_Terminal_Limpiar_Click" />
                        <asp:Button ID="Btn_Chofer_Borrar" runat="server" Width="145px" Height="35px" 
                            Text="Borrar" onclick="Btn_Chofer_Borrar_Click"/>
                        <asp:Button ID="Btn_Chofer_Guardar" runat="server" Width="145px" Height="35px" 
                            Text="Guardar" onclick="Btn_Chofer_Guardar_Click"/>
                        <asp:Button ID="Btn_Chofer_Modificar" runat="server" Width="145px" Height="35px" Text="Modificar"/>
                    </div>
                </div>
                <div class="catalogs2">
                    <div class="catalogs_title"><p>Usuarios</p></div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Usuario_Nombre" runat="server" Width="110px" Height="35px" Text="Nombre" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Usuario_Nombre" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Usuario_Edad" runat="server" Width="110px" Height="35px" Text="Edad" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Usuario_Edad" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Usuario_Email" runat="server" Width="110px" Height="35px" Text="Email" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Usuario_Email" runat="server" Width="180px" Height="25px"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Usuario_Contrasena" runat="server" Width="110px" Height="35px" Text="Contrasena" style="margin-top:5px"></asp:Label>
                        <asp:TextBox ID="TBox_Usuario_Contrasena" runat="server" Width="180px" 
                            Height="25px" TextMode="Password"></asp:TextBox>                    
                    </div>
                    <div class="catalogs_row">
                        <asp:Label ID="Lbl_Usuario_Rol" runat="server" Width="110px" Height="35px" Text="Rol" style="margin-top:5px"></asp:Label>
                        <asp:DropDownList ID="DDL_Usuario_Rol" runat="server" Width="185px" Height="28px"></asp:DropDownList>                  
                    </div>
                    <div class="catalogs_row">
                        <asp:DropDownList ID="DDL_Usuarios" runat="server" Width="295px" Height="28px" 
                            onselectedindexchanged="DDL_Usuarios_SelectedIndexChanged" 
                            AutoPostBack="True"></asp:DropDownList>
                        <asp:Button ID="Btn_Usuario_Limpiar" runat="server" Width="145px" Height="35px" 
                            Text="Limpiar" onclick="Btn_Usuario_Limpiar_Click" />
                        <asp:Button ID="Btn_Usuario_Borrar" runat="server" Width="145px" Height="35px" 
                            Text="Borrar" onclick="Btn_Usuario_Borrar_Click"/>
                        <asp:Button ID="Btn_Usuario_Guardar" runat="server" Width="145px" Height="35px" 
                            Text="Guardar" onclick="Btn_Usuario_Guardar_Click"/>
                        <asp:Button ID="Btn_Usuario_Modificar" runat="server" Width="145px" 
                            Height="35px" Text="Modificar" onclick="Btn_Usuario_Modificar_Click"/>
                    </div>
                </div>
                <div class="catalogs2">
                    <div class="catalogs_title"><p></p></div>
                    <div class="catalogs_row">
                        <!-- CATALOGO DISPONIBLE -->                   
                    </div>
                    <div class="catalogs_row">
                        <!-- CATALOGO DISPONIBLE -->
                    </div>
                </div>
            </div>            
        </div>    
        <br />
    </div>
    </form>
</body>
</html>
