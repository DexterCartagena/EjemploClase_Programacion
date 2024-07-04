using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public class CD_Tpersona
    {
        //private ConexionBD conexion = new ConexionBD();

        //SqlDataReader leer;
        //DataTable tabla = new DataTable();
        //SqlCommand comandoQuery = new SqlCommand();
        
        //// crear los procedimiento y funciones del método CRUD o ABM
        //public void insertarPersona(string nombre, string appaterno, string apmaterno, string celular, string ci, string dir_per, string pro_per)
        //{
        //    comandoQuery.Connection = conexion.abrirBd();
        //    comandoQuery.CommandText = "insert into tpersona" +
        //        " values('"+ nombre +"','"+
        //        appaterno+"','"+apmaterno+"','"+
        //        celular+"','"+ci+"','"+dir_per+"','"+pro_per +"')";
        //    comandoQuery.CommandType = CommandType.Text;
        //    comandoQuery.ExecuteNonQuery();

        //}

        //public void modificarPersona(string idpersona,string nombre, string appaterno, string apmaterno, string celular,string ci, string dir_per, string pro_per)
        //{
        //    /*
        //     update TPersona set 
        //    nombre='Carlos', apPaterno='Butrom', apMaterno='Perez', celular='7182964'
        //    where IDPersona=4
             
        //     */
        //    comandoQuery.Connection = conexion.abrirBd();
        //    comandoQuery.CommandText = "update Tpersona set nombre='"
        //     +nombre+"', appaterno='" 
        //     +appaterno+"', apmaterno='"
        //     +apmaterno+"', dir_per='"
        //     +dir_per + "', pro_per='"
        //     + pro_per + "', celular='"
        //     + celular+"',carnet='"
        //     +ci+"' where idpersona="
        //     +idpersona;
        //     comandoQuery.CommandType = CommandType.Text;
        //    comandoQuery.ExecuteNonQuery();

        //}

        //public void EliminarPersona(string idpersona)
        //{
        //    /*
        //    delete from TPersona
        //    where IDPersona=1
             
        //     */
        //    comandoQuery.Connection = conexion.abrirBd();
        //    comandoQuery.CommandText = "Delete from Tpersona where idpersona="+idpersona;
        //    comandoQuery.CommandType = CommandType.Text;
        //    comandoQuery.ExecuteNonQuery();

        //}

        //public  DataTable SelecionarTodoPersona()
        //{
        //    /*
        //    delete from TPersona
        //    where IDPersona=1
             
        //     */
        //    comandoQuery.Connection = conexion.abrirBd();
        //    comandoQuery.CommandText = "select idpersona as Codigo,carnet as Carnet_Identidad ,nombre, " +
        //    "appaterno as ApPaterno, apmaterno as ApMaterno, Celular as Telefono_celular, "+
        //    "dir_per as Dirección, pro_per as Profesión  from tpersona";
           
        //    leer = comandoQuery.ExecuteReader();
        //    tabla.Load(leer);
        //    comandoQuery.CommandType = CommandType.Text;
        //    return tabla;

        //}
        //public DataTable BuscarPersona(string buscar)
        //{
        //    /*
        //    delete from TPersona
        //    where IDPersona=1
             
        //     */
        //    comandoQuery.Connection = conexion.abrirBd();
        //    comandoQuery.CommandText = "select idpersona as Codigo,carnet as Carnet_Identidad ,nombre, " +
        //    "appaterno as ApPaterno, apmaterno as ApMaterno, Celular as Telefono_celular, "+
        //    " dir_per as Dirección, pro_per as Profesión from tpersona" +
        //    " where nombre+appaterno+apmaterno+dir_per+pro_per like '%" + buscar+"%'" ;

        //    leer = comandoQuery.ExecuteReader();
        //    tabla.Load(leer);
        //    comandoQuery.CommandType = CommandType.Text;
        //    return tabla;

        //}
        //public DataTable VerificarPersonaCI(string buscar)
        //{
        //    /*
        //    delete from TPersona
        //    where IDPersona=1
             
        //     */
        //    comandoQuery.Connection = conexion.abrirBd();
        //    comandoQuery.CommandText = "select idpersona as Codigo,carnet as Carnet_Identidad ,nombre, " +
        //    "appaterno as ApPaterno, apmaterno as ApMaterno, Celular as Telefono_celular, "+
        //    "dir_per as Dirección, pro_per as Profesión  from tpersona" +
        //    " where carnet= '" + buscar + "'";

        //    leer = comandoQuery.ExecuteReader();
        //    tabla.Load(leer);
        //    comandoQuery.CommandType = CommandType.Text;
        //    return tabla;

        //}






    }
}
