using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class ConexionBD
    {
        //1.- cadena de conexión
        string cadena = "Data Source=DESKTOP-Q84724U; Initial Catalog=VentasPrueba; Integrated Security=True;";
        
        // agregar el using System.Data.SqlClient; si sale error agregar el NUget
        public SqlConnection conectarBd = new SqlConnection();

        public ConexionBD()
        {
            conectarBd.ConnectionString = cadena;
        }

        public SqlConnection abrirBd()
        {
            if (conectarBd.State == ConnectionState.Closed)
            {
                conectarBd.Open();
            }
            return conectarBd;
        }
        public SqlConnection cerrarBD()
        {
            if (conectarBd.State == ConnectionState.Open)
            {
                conectarBd.Close();
            }
            return conectarBd;


        }
    }
}
