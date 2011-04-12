using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WS_MonRut;

public partial class _Default : System.Web.UI.Page
{
    MonRutWsSoapClient MR = new MonRutWsSoapClient("MonRutWsSoap");
    Route[] myRoutes;
    Bus[] myBuses;
    Station[] myStations;
    Driver[] myDrivers;
    User[] myUsers;

    protected void Page_Load(object sender, EventArgs e)
    {       
        Cargar_Rutas();
        Cargar_Choferes();
        Cargar_Terminales();
        Cargar_Autobuses();
        Cargar_Usuarios();

        Cargar_Autobus_Choferes();
        Cargar_Autobus_Rutas();
        Cargar_Terminal_Rutas();        
    }

    //Enventos para Guardar un Registro Nuevo
    protected void Btn_Ruta_Guardar_Click(object sender, EventArgs e)
    {        
        MR.AddRoute(TBox_Ruta_Nombre.Text);

        Limpiar_Rutas();
    }

    protected void Btn_Autobus_Guardar_Click(object sender, EventArgs e)
    {
        int number = int.Parse(TBox_Autobus_Numero.Text);
        int seats = int.Parse(TBox_Autobus_Asientos.Text);
        int capacity = int.Parse(TBox_Autobus_Capacidad.Text);
        MR.AddBus(number, seats, capacity);
        

        Limpiar_Autobuses();
    }

    protected void Btn_Terminal_Guardar_Click(object sender, EventArgs e)
    {
        MR.AddStation(  TBox_Terminal_Nombre.Text, TBox_Terminal_Ciudad.Text, TBox_Terminal_Colonia.Text, int.Parse(TBox_Terminal_CP.Text),
                        TBox_Terminal_Estado.Text, int.Parse(TBox_Terminal_Numero.Text), DDL_Terminal_Rutas.SelectedIndex);

        Limpiar_Terminales();
    }

    protected void Btn_Chofer_Guardar_Click(object sender, EventArgs e)
    {
        MR.AddDriver(TBox_Chofer_Nombre.Text, TBox_Chofer_Apellidos.Text, int.Parse(Tbox_Chofer_Edad.Text));
    }

    protected void Btn_Usuario_Guardar_Click(object sender, EventArgs e)
    {
        bool admin = false;
        admin = (DDL_Usuario_Rol.SelectedItem.Selected)? true : false;
        MR.AddUser(TBox_Usuario_Nombre.Text, TBox_Usuario_Contrasena.Text, admin);
    }

    //Eventos para Borrar un Registro
    protected void Btn_Ruta_Borrar_Click(object sender, EventArgs e)
    {
        MR.DeleteRoute(int.Parse(DDL_Rutas.DataValueField));
        Limpiar_Rutas();
    }

    protected void Btn_Autobus_Borrar_Click(object sender, EventArgs e)
    {
        MR.DeleteBus(int.Parse(DDL_Autobuses.DataValueField));
        Limpiar_Autobuses();
    }

    protected void Btn_Terminal_Borrar_Click(object sender, EventArgs e)
    {
        MR.DeleteStation(int.Parse(DDL_Terminales.DataValueField));
        Limpiar_Terminales();
    }

    protected void Btn_Chofer_Borrar_Click(object sender, EventArgs e)
    {
        MR.DeleteDriver(int.Parse(DDL_Choferes.DataValueField));
        Limpiar_Choferes();
    }

    protected void Btn_Usuario_Borrar_Click(object sender, EventArgs e)
    {
        MR.DeleteUser(int.Parse(DDL_Usuarios.DataValueField));
        Limpiar_Usuarios();
    }

    //Eventos para Modificar un Registro Existente
    protected void Btn_Ruta_Modificar_Click(object sender, EventArgs e)
    {
        MR.UpdateRoute(int.Parse(DDL_Rutas.DataValueField), TBox_Ruta_Nombre.Text);
        Limpiar_Rutas();
    }

    protected void Btn_Autobus_Modificar_Click(object sender, EventArgs e)
    {
       
    }

    protected void Btn_Terminal_Modificar_Click(object sender, EventArgs e)
    {

    }

    protected void Btn_Usuario_Modificar_Click(object sender, EventArgs e)
    {

    }


    //Eventos para Limpiar los Campops
    protected void Btn_Ruta_Limpiar_Click(object sender, EventArgs e)
    {
        Limpiar_Rutas();
    }

    protected void Btn_Autobus_Limpiar_Click(object sender, EventArgs e)
    {
        Limpiar_Autobuses();
    }

    protected void Btn_Terminal_Limpiar_Click(object sender, EventArgs e)
    {
        Limpiar_Terminales();
    }

    protected void Btn_Chofer_Limpiar_Click(object sender, EventArgs e)
    {
        Limpiar_Choferes();
    }

    protected void Btn_Usuario_Limpiar_Click(object sender, EventArgs e)
    {
        Limpiar_Usuarios();
    }

    //Eventos al Seleccionar de una Drop Down List
    protected void DDL_Rutas_SelectedIndexChanged(object sender, EventArgs e)
    {
        Route selRoute = MR.GetRoute(int.Parse(DDL_Rutas.DataValueField));
        TBox_Ruta_Nombre.Text = selRoute.Name;
    }

    protected void DDL_Autobuses_SelectedIndexChanged(object sender, EventArgs e)
    {
        Bus selBus = MR.GetBus(int.Parse(DDL_Autobuses.DataValueField));
        TBox_Autobus_Numero.Text = selBus.Number.ToString();
        TBox_Autobus_Asientos.Text = selBus.Seats.ToString();
        TBox_Autobus_Capacidad.Text = selBus.Capacity.ToString();
        
        
    }

    protected void DDL_Terminales_SelectedIndexChanged(object sender, EventArgs e)
    {
        Station selStation = MR.GetStation(int.Parse(DDL_Terminales.DataValueField));
        TBox_Terminal_Numero.Text = selStation.Number.ToString();
        TBox_Terminal_Nombre.Text = selStation.Name;
        TBox_Terminal_Colonia.Text = selStation.District;
        TBox_Terminal_Ciudad.Text = selStation.City;
        TBox_Terminal_Estado.Text = selStation.State;
        TBox_Terminal_CP.Text = selStation.ZipCode.ToString();
    }

    protected void DDL_Choferes_SelectedIndexChanged(object sender, EventArgs e)
    {
        Driver selDriver = MR.GetDriver(int.Parse(DDL_Choferes.DataValueField));
        TBox_Chofer_Nombre.Text = selDriver.FirstName;
        TBox_Chofer_Apellidos.Text = selDriver.LastName;
        Tbox_Chofer_Edad.Text = selDriver.Age.ToString();
    }

    protected void DDL_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
        User selUser = MR.GetUser(int.Parse(DDL_Usuarios.DataValueField));
        TBox_Usuario_Nombre.Text = selUser.Name;
    }

    public void Cargar_Rutas()
    {
        DDL_Rutas.Items.Clear();
        myRoutes = MR.GetRouteList(0, 10);
        DDL_Rutas.Items.Add("Selecciona la Ruta Deseada");

        for (int i = 0; i < myRoutes.Length; i++)
        {
            int id = myRoutes[i].Id;
            DDL_Rutas.Items.Add(myRoutes[i].Name);
            DDL_Rutas.DataValueField = id.ToString();
        }
    }

    public void Cargar_Autobuses()
    {
        DDL_Autobuses.Items.Clear();
        myBuses = MR.GetBusList(0, 10);
        DDL_Autobuses.Items.Add("Selecciona el Autobus Deseado");
        DDL_Autobus_Chofer.Items.Add("Asigna el Chofer Deseado");
        DDL_Autobus_Ruta.Items.Add("Asigna la Ruta Deseada");

        for (int i = 0; i < myBuses.Length; i++)
        {
            int id = myBuses[i].Id;
            DDL_Autobuses.Items.Add(myBuses[i].Number.ToString());
            DDL_Autobuses.DataValueField = id.ToString();
        }
    }

    public void Cargar_Terminales()
    {
        DDL_Terminales.Items.Clear();
        myStations = MR.GetStationList(0, 10);
        DDL_Terminales.Items.Add("Selecciona la Terminal Deseada");
        DDL_Terminal_Rutas.Items.Add("Selecciona la Terminal Deseada");

        for (int i = 0; i < myStations.Length; i++)
        {
            int id = myStations[i].Id;
            DDL_Terminales.Items.Add(myStations[i].Name);
            DDL_Terminales.DataValueField = id.ToString();
        }
    }

    public void Cargar_Choferes()
    {
        DDL_Choferes.Items.Clear();
        myDrivers = MR.GetDriverList(0, 10);
        DDL_Choferes.Items.Add("Selecciona el Chofer Deseado");

        for (int i = 0; i < myDrivers.Length; i++)
        {
            int id = myDrivers[i].Id;
            DDL_Choferes.Items.Add(myDrivers[i].FirstName);
            DDL_Autobuses.DataValueField = id.ToString();
        }
    }

    public void Cargar_Usuarios()
    {
        DDL_Usuarios.Items.Clear();
        myUsers = MR.GetUserList(0, 10);
        DDL_Usuarios.Items.Add("Selecciona el Usuario Deseado");
        DDL_Usuario_Rol.Items.Add("Selecciona el Rol Deseado");
        DDL_Usuario_Rol.Items.Add("Administrador");

        for (int i = 0; i < myUsers.Length; i++)
        {
            int id = myUsers[i].Id;
            DDL_Usuarios.Items.Add(myUsers[i].Name);
            DDL_Usuarios.DataValueField = id.ToString();
        }
    }

    public void Cargar_Autobus_Choferes()
    {
        DDL_Autobus_Chofer.Items.Clear();
        myDrivers = MR.GetDriverList(0, 10);

        for (int i = 0; i < myDrivers.Length; i++)
        {
            int id = myDrivers[i].Id;
            DDL_Autobus_Chofer.Items.Add(myDrivers[i].FirstName);
            DDL_Autobus_Chofer.DataValueField = id.ToString();
        }
    }

    public void Cargar_Autobus_Rutas()
    {
        myRoutes = MR.GetRouteList(0, 10);
        DDL_Autobus_Ruta.Items.Clear();
        for (int i = 0; i < myRoutes.Length; i++)
        {
            int id = myRoutes[i].Id;
            DDL_Autobus_Ruta.Items.Add(myRoutes[i].Name);
            DDL_Autobus_Ruta.DataValueField = id.ToString();
        }
    }

    public void Cargar_Terminal_Rutas()
    {
        myRoutes = MR.GetRouteList(0, 10);
        DDL_Terminal_Rutas.Items.Clear();
        for (int i = 0; i < myRoutes.Length; i++)
        {
            int id = myRoutes[i].Id;
            DDL_Terminal_Rutas.Items.Add(myRoutes[i].Name);
            DDL_Terminal_Rutas.DataValueField = id.ToString();
        }
    }

    public void Limpiar_Rutas()
    {
        TBox_Ruta_Nombre.Text = "";
        DDL_Rutas.SelectedIndex.Equals(0);
    }

    public void Limpiar_Autobuses()
    {
        TBox_Autobus_Numero.Text = "";
        TBox_Autobus_Asientos.Text = "";
        TBox_Autobus_Capacidad.Text = "";
        DDL_Autobus_Chofer.SelectedIndex.Equals(0);
        DDL_Autobus_Ruta.SelectedIndex.Equals(0);
        DDL_Autobuses.SelectedIndex.Equals(0);
    }

    public void Limpiar_Terminales()
    {
        TBox_Terminal_Numero.Text = "";
        TBox_Terminal_Nombre.Text = "";
        TBox_Terminal_Colonia.Text = "";
        TBox_Terminal_Ciudad.Text = "";
        TBox_Terminal_Estado.Text = "";
        TBox_Terminal_CP.Text = "";
        DDL_Terminal_Rutas.SelectedIndex.Equals(0);
    }

    public void Limpiar_Choferes()
    {
        TBox_Chofer_Nombre.Text = "";
        Tbox_Chofer_Edad.Text = "";
    }

    public void Limpiar_Usuarios()
    {
        TBox_Usuario_Nombre.Text = "";
        TBox_Usuario_Edad.Text = "";
        TBox_Usuario_Email.Text = "";
        TBox_Usuario_Contrasena.Text = "";
        DDL_Usuario_Rol.SelectedIndex.Equals(0);
    }
}