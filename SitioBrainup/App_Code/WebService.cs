using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]

    public List<EntRol> Lista()
    {
        return (new BusRol().Mostrar());
    }

    [WebMethod]

    public void Agregar(EntRol rol)
    {
        new BusRol().Agregar(rol);
    }

    [WebMethod]

    public EntRol Details(int IdRol)
    {
        return (new BusRol().Detalles(IdRol));

    }

    [WebMethod]

    public void Actualizar(EntRol rol)
    {
        new BusRol().Actualizar(rol);
    }

    [WebMethod]

    public void Eliminar(int IdRol)
    {
        new BusRol().Eliminar(IdRol);
    }

}
