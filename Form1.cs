using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;

namespace JuanCecilioCespedesBatallanos
{
    public partial class FrmCliente : Form
    {
        CN_Cliente oCliente = new CN_Cliente();
        string accion = "";
        //G = guardar
        //M = Modificar
        //N = Nuevo
        //E = Eliminar
        //I = imprimir

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accion = "N";
            limpiarEntradas();
            txtCodigo.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void limpiarEntradas()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtNit.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "N" || accion == "G" )
            {
                accion = "G";
                oCliente.Nomcli = txtNombre.Text;
                oCliente.Dircli = txtDireccion.Text;
                oCliente.Telcli = txtTelefono.Text;
                oCliente.Nitcli = txtNit.Text;
                oCliente.Emailcli = txtEmail.Text;
                if (oCliente.Guardar())
                {
                    MessageBox.Show("Datos Introducidos Correctamente");
                }
                else
                {
                    MessageBox.Show("Error Verifique los Dato");
                }
            }
            if (accion == "M")
            {
                oCliente.Nomcli = txtNombre.Text;
                oCliente.Dircli = txtDireccion.Text;
                oCliente.Telcli = txtTelefono.Text;
                oCliente.Nitcli = txtNit.Text;
                oCliente.Emailcli = txtEmail.Text;
                if (oCliente.Modificar(txtCodigo.Text))
                {
                    MessageBox.Show("Datos Modificados Correctamente");
                }
                else
                {
                    MessageBox.Show("Error Verifique los Dato");
                }

            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = "M";
            limpiarEntradas();
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                DataTable TablaCliente = new DataTable();
                             
                
               
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Se abre una ventana de busqueda");
                }
                else {
                    /// tengo que llamar a una funcion de la capa de negocio
                    
                    if (oCliente.VerificarCliente(txtCodigo.Text, ref TablaCliente))
                    {
                       txtNombre.Text= TablaCliente.Rows[0][0].ToString();
                        txtDireccion.Text = TablaCliente.Rows[0][1].ToString();
                        txtTelefono.Text = TablaCliente.Rows[0][2].ToString();
                        txtNit.Text = TablaCliente.Rows[0][3].ToString();
                        txtEmail.Text = TablaCliente.Rows[0][4].ToString();
                       
                    }
                    else {
                        MessageBox.Show("Error de Dato y/o El Código No Existe....");
                        txtCodigo.Clear();
                        limpiarEntradas();
                        txtCodigo.Focus();
                    }
                        

                
                }


            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            accion = "N";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            accion = "I";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (accion == "N")
            {
                accion = "E";
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
            }
            else
            {
                if (accion == "E")
                {
                    accion = "N";
                    
                   
                    if (oCliente.Eliminar(txtCodigo.Text))
                    {
                        MessageBox.Show("Datos Eliminado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error Verifique los Dato");
                    }
                    limpiarEntradas();
                    btnCancelar_Click(sender, e);

                }
            }
        }
    }
}
