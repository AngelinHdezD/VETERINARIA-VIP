using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria__VIP_1._0_
{
    public partial class PaginaPrincipal : Form
    {
        ConexionSQLN cn=new ConexionSQLN();

        private string user;
        //Rutas de las Imagenes
        private string rutaImagen1 = @"D:\Documentos\Personal\Skul\Universidad\ITD\Semestre 6\Ingeniería de Software\Proyecto\Programa\VeteVIP\Noticia.png";
        private string rutaImagen2 = @"D:\Documentos\Personal\Skul\Universidad\ITD\Semestre 6\Ingeniería de Software\Proyecto\Programa\VeteVIP\Noticia2.jpg";
        private string rutaImagen3 = @"D:\Documentos\Personal\Skul\Universidad\ITD\Semestre 6\Ingeniería de Software\Proyecto\Programa\VeteVIP\Noticia3.jpg";

        public PaginaPrincipal()
        {
            InitializeComponent();

        }

        public PaginaPrincipal(string user)
        {
            this.user = user;
            InitializeComponent();
            // Carga las imágenes desde las rutas de archivo
            imagenes.Add(Image.FromFile(rutaImagen1));
            imagenes.Add(Image.FromFile(rutaImagen2));
            imagenes.Add(Image.FromFile(rutaImagen3));

            pictureBox1.Image = imagenes[posicionActual];

        }

        //Movimiento de la Seccion de Noticias
        private List<Image> imagenes = new List<Image>();
        private int posicionActual = 0;

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Disminuye el contador de posición actual
            posicionActual--;

            // Verifica si el contador está fuera de los límites de la lista
            if (posicionActual < 0)
            {
                // Si está fuera de los límites, muestra la última imagen en la lista
                posicionActual = imagenes.Count - 1;
            }

            // Muestra la imagen correspondiente en el PictureBox
            pictureBox1.Image = imagenes[posicionActual];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Aumenta el contador de posición actual
            posicionActual++;

            // Verifica si el contador está fuera de los límites de la lista
            if (posicionActual >= imagenes.Count)
            {
                // Si está fuera de los límites, muestra la primera imagen en la lista
                posicionActual = 0;
            }

            // Muestra la imagen correspondiente en el PictureBox
            pictureBox1.Image = imagenes[posicionActual];
        }

        private void lblEMERGENCIA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Muestra un cuadro de diálogo para obtener el nombre de la mascota
            string nombreMascota;
            nombreMascota = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la mascota:", "Nombre de la mascota", "");

            // Verifica si se ingresó un nombre de mascota válido
            if (!string.IsNullOrEmpty(nombreMascota))
            {
                int resultado=cn.citaEmerg(user, nombreMascota);
                if (resultado==1)
                {
                    MessageBox.Show("La Cita de Emergencia ha sido anexada");
                }
                else
                {
                    MessageBox.Show("No se encontró una mascota con el nombre ingresado.", "Nombre de la mascota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se encontró una mascota con el nombre ingresado.", "Nombre de la mascota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            ForoVIP formularioNuevo = new ForoVIP(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnMascota_Click_1(object sender, EventArgs e)
        {
            PaginaMascota formularioNuevo = new PaginaMascota(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }
        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void LLsMedico_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServicioVeterinario formularioNuevo = new ServicioVeterinario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void LLsEstetico_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServicioEstetico formularioNuevo = new ServicioEstetico(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                user = "";
                InicioDeSesion inicio = new InicioDeSesion();
                this.Hide();
                inicio.Show();
                inicio.FormClosed += (s, args) => this.Close();
            }
            else if (boton == DialogResult.Cancel)
            {
                btnSalir.Focus();
            }
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
