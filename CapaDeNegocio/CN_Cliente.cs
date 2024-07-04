using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
namespace CapaDeNegocio
{
    public class CN_Cliente
    {
        CD_Cliente oCliente = new CD_Cliente();
        public string Dircli { get; set; }
        public string Emailcli { get; set; }
        public string Nitcli { get; set; }
        public string Nomcli { get; set; }
        public string Telcli { get; set; }

        public Boolean Guardar()
        {
            if (Nomcli.Trim() == "")
            {
                return false;
            }
            if (Dircli.Trim() == "")
            {
                return false;
            }
            if (Telcli.Trim() == "")
            {
                return false;
            }
            //if (Nitcli.Trim() == "")
            //{
            //    return false;

            //}
            //if (Emailcli.Trim() == "")
            //{
            //    return false;

            //}

            try
            {
                oCliente.Guardar(Nomcli, Dircli, Telcli, Nitcli, Emailcli);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
            
            
        }

        public bool Modificar(string idcliente)
        {
            if (Nomcli.Trim() == "")
            {
                return false;
            }
            if (Dircli.Trim() == "")
            {
                return false;
            }
            if (Telcli.Trim() == "")
            {
                return false;
            }
            //if (Nitcli.Trim() == "")
            //{
            //    return false;

            //}
            //if (Emailcli.Trim() == "")
            //{
            //    return false;

            //}

            try
            {
                oCliente.Modificar(idcliente,Nomcli, Dircli, Telcli, Nitcli, Emailcli);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Eliminar(string idcliente)
        {
            if (string.IsNullOrWhiteSpace(idcliente))
            {
                return false;
            } 
            try
            {
                oCliente.Eliminar(idcliente);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public void Imprimir()
        {

        }
        public bool VerificarCliente(string codigo, ref DataTable TablaCliente)
        {
            int IdCliente;
            if (!int.TryParse(codigo,out IdCliente))
            {
               
                
                return false;
            } 
            try
            {
                TablaCliente = oCliente.BuscarCliente(IdCliente.ToString());
                if (TablaCliente.Rows.Count == 0)
                {
                    return false;
                }
                return true; 
                
            }
            catch (Exception)
            {
                
                return false;
            }
        }


    }
}
