﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Form
    {


        private int childFormNumber = 0;
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;

        private Bitmap originalImage;

        public FrmPrincipal()
        {
            InitializeComponent();
           // CargarImagenDeFondo();
            //this.Resize += new EventHandler(Formulario_Redimensionado); // Agrega el evento de redimensionamiento

        }
        /*     private void CargarImagenDeFondo()
             {
                 try
                 {
                     string imagePath = Application.StartupPath + @"\img\ImgPrincipal.jpg";
                     //MessageBox.Show("Ruta de la imagen: " + imagePath); // Mostrar la ruta para depuración
                     originalImage = new Bitmap(imagePath);
                     SetResponsiveBackgroundImage(originalImage); // Pasa la imagen original como argumento
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error al cargar la imagen: " + ex.Message + "\n" + ex.StackTrace); // Mostrar más detalles del error
                 }
             }*/
        /*  private void Formulario_Redimensionado(object sender, EventArgs e)
          {
              SetResponsiveBackgroundImage(originalImage); // Pasa la imagen original como argumento
          }*/
        /* private void SetResponsiveBackgroundImage(Bitmap originalImage)
         {
             try
             {
                 if (originalImage != null && this.ClientSize.Width > 0 && this.ClientSize.Height > 0)
                 {
                     // Crear un nuevo bitmap para la imagen redimensionada
                     Bitmap scaledImage = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
                     using (Graphics g = Graphics.FromImage(scaledImage))
                     {
                         // Establecer modo de interpolación a alta calidad
                         g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                         // Calcular la relación de aspecto
                         float aspectRatio = (float)originalImage.Width / (float)originalImage.Height;
                         int newWidth, newHeight;
                         if (this.ClientSize.Width / aspectRatio > this.ClientSize.Height)
                         {
                             newWidth = this.ClientSize.Width;
                             newHeight = (int)(this.ClientSize.Width / aspectRatio);
                         }
                         else
                         {
                             newHeight = this.ClientSize.Height;
                             newWidth = (int)(this.ClientSize.Height * aspectRatio);
                         }

                         // Dibujar la imagen redimensionada
                         g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                     }

                     // Establecer la imagen de fondo redimensionada
                     this.BackgroundImage = scaledImage;
                     this.BackgroundImageLayout = ImageLayout.Stretch; // O ImageLayout.Zoom según tu preferencia
                 }
             }
             catch (Exception ex)
             {
                 // Opcionalmente, puedes descomentar esta línea para ver los errores en tiempo de ejecución
                 MessageBox.Show("Error al ajustar la imagen: " + ex.Message + "\n" + ex.StackTrace);
             }


         }
     */

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.MdiParent = this;
            frm.Show();

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulo frm = new FrmArticulo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            StBarraInferior.Text = "Desarrollado por JyE CODEX, Usuario: " + this.Nombre;
            MessageBox.Show("Bienvenido: " + this.Nombre, "SistemaAV24", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.Rol.Equals("Administrador"))
            {
                MnuAlmacen.Enabled = true;
                MnuIngresos.Enabled = true;
                MnuVentas.Enabled = true;
                MnuAccesos.Enabled = true;
                MnuConsultas.Enabled = true;
                TsCompras.Enabled = true;
                TsVentas.Enabled = true;


            }
            else
            {

                if (this.Rol.Equals("Vendedor"))
                {
                    MnuAlmacen.Enabled = false;
                    MnuIngresos.Enabled = false;
                    MnuVentas.Enabled = true;
                    MnuAccesos.Enabled = false;
                    MnuConsultas.Enabled = true;
                    TsCompras.Enabled = false;
                    TsVentas.Enabled = true;
                }
                else
                {
                    if (this.Rol.Equals("Almacenero"))
                    {
                        MnuAlmacen.Enabled = true;
                        MnuIngresos.Enabled = true;
                        MnuVentas.Enabled = false;
                        MnuAccesos.Enabled = false;
                        MnuConsultas.Enabled = true;
                        TsCompras.Enabled = true;
                        TsVentas.Enabled = false;
                    }
                    else
                    {
                        MnuAlmacen.Enabled = false;
                        MnuIngresos.Enabled = false;
                        MnuVentas.Enabled = false;
                        MnuAccesos.Enabled = false;
                        MnuConsultas.Enabled = false;
                        TsCompras.Enabled = false;
                        TsVentas.Enabled = false;
                    }
                }
            }
           
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas salir del Sistema?", "Sistema V2024", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_VentaFechas frm = new FrmConsulta_VentaFechas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_CompraFechas frm = new FrmConsulta_CompraFechas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TsCompras_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TsVentas_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
