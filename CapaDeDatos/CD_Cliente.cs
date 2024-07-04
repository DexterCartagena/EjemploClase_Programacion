using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
   public class CD_Cliente
    {
        ConexionBD oConexionBD = new ConexionBD();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comandoQuery = new SqlCommand();

        public void Guardar(string Nomcli, string Dircli, string Telcli, string Nitcli, string Emailcli)
        {
            
            comandoQuery.Connection = oConexionBD.abrirBd();
            
            comandoQuery.CommandText = "insert into tcliente" +
                " values('" + Dircli + "','" +
                Emailcli + "','" + Nitcli + "','" +
                Nomcli + "','" + Telcli + "')";
            
            
            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();

            comandoQuery.Connection=oConexionBD.cerrarBD();
        }
        public void Modificar(string idcliente,string Nomcli, string Dircli, string Telcli, string Nitcli, string Emailcli)
        {
            comandoQuery.Connection = oConexionBD.abrirBd();

            comandoQuery.CommandText = "update tcliente" +
                " set dircli='" + Dircli + "'," +
                " Emailcli= '"+Emailcli + "', Nitcli='" + Nitcli + "',Nomcli='" +
                Nomcli + "',telcli='" + Telcli + "' where tclienteID="+idcliente;


            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();

            comandoQuery.Connection = oConexionBD.cerrarBD();
        }

        public void Eliminar(string idCliente)
        {
            comandoQuery.Connection = oConexionBD.abrirBd();

            comandoQuery.CommandText = "delete from tcliente" +
                " where tclienteID=" + idCliente;


            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();

            comandoQuery.Connection = oConexionBD.cerrarBD();
        }
        public void Imprimir()
        {

        }
        public DataTable BuscarCliente(string IdCliente)
        {
            comandoQuery.Connection = oConexionBD.abrirBd();
            
            comandoQuery.CommandText = "select cli.Nomcli, cli.Dircli, cli.Telcli, cli.Nitcli, cli.Emailcli "+
            " from Tcliente cli where cli.TclienteID = " + IdCliente ;

            leer = comandoQuery.ExecuteReader();
            //puto codigo... que faltaba y corria todo a la primera jajajjaja
            tabla.Clear();
            tabla.Load(leer);
            //comandoQuery.CommandType = CommandType.Text;
            oConexionBD.cerrarBD();
            return tabla;
        }
    }
}
