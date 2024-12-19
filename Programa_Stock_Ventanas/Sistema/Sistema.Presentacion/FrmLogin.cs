using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.TxtClave.KeyDown += new KeyEventHandler(TxtClave_KeyDown);
        }
        private void TxtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAcceder_Click(sender, e);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = UsuarioSN.Login(TxtEmail.Text.Trim(),TxtClave.Text.Trim());
                if(Tabla.Rows.Count<=0) /*Mi objeto tabla, tiene 0 filas o no tiene, al menos un registro valido con ese email y esa clave, yo voy a mostrar el mensaje de error. */
                {
                    MessageBox.Show("El email o la clave es incorrecta.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][4]) == false)
                    {
                        MessageBox.Show("Este usuario no esta activo.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FrmPrincipal Frm = new FrmPrincipal();
                        Variables.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        Frm.IdUsuario= Convert.ToInt32(Tabla.Rows[0][0]);
                        Frm.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                        Frm.Rol = Convert.ToString(Tabla.Rows[0][2]);
                        Frm.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                        Frm.Estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                        Frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
