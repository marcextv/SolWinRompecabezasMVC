using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponenteJuego;

namespace WinAppRompecabezas
{
    public partial class frmRompecabezas : Form
    {
        private List<Button> ListaBotones = new List<Button>();
        ControladorJuego ObjControladorJuego = new ControladorJuego();

        public frmRompecabezas()
        {
            InitializeComponent();
            IngresarDatosLista();
        }

        private void IngresarDatosLista()
        {
            ListaBotones.Add(btnRompecabezas1);
            ListaBotones.Add(btnRompecabezas2);
            ListaBotones.Add(btnRompecabezas3);
            ListaBotones.Add(btnRompecabezas4);
            ListaBotones.Add(btnRompecabezas5);
            ListaBotones.Add(btnRompecabezas6);
            ListaBotones.Add(btnRompecabezas7);
            ListaBotones.Add(btnRompecabezas8);
            ListaBotones.Add(btnRompecabezas9);
            ListaBotones.Add(btnRompecabezas10);
            ListaBotones.Add(btnRompecabezas11);
            ListaBotones.Add(btnRompecabezas12);
            ListaBotones.Add(btnRompecabezas13);
            ListaBotones.Add(btnRompecabezas14);
            ListaBotones.Add(btnRompecabezas15);
            ListaBotones.Add(btnRompecabezas16);
        }


        private void frmRompecabezas_Load(object sender, EventArgs e)
        {
            ObjControladorJuego.ActualizarDatosDeCarga(txtNumeroMovimientosTentativos,
                                                       txtNumeroMovimientosPC,
                                                       txtNumeroMovimientosUsuario);

            ObjControladorJuego.InicializarControlesJuego(ListaBotones, txtTiempo, tmrCronometro, tmrControlMovimiento);
            ObjControladorJuego.InicilizarDatos();

            ObjControladorJuego.CargarCampoDeJuego(ListaBotones, grbRompecabezas, TextBox1,
                                                   TextBox2, listBox1, tmrCronometro,
                                                   tmrControlMusica, axWMPSonido);
        }

        private void mnuArchivoNuevo_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActualizarDatosDeCarga(txtNumeroMovimientosTentativos,
                                                       txtNumeroMovimientosPC,
                                                       txtNumeroMovimientosUsuario);

            ObjControladorJuego.InicializarControlesJuego(ListaBotones, txtTiempo, tmrCronometro, tmrControlMovimiento);
            ObjControladorJuego.InicilizarDatos();

            ObjControladorJuego.CargarCampoDeJuego(ListaBotones, grbRompecabezas, TextBox1,
                                                   TextBox2, listBox1, tmrCronometro,
                                                   tmrControlMusica, axWMPSonido);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActualizarDatosDeCarga(txtNumeroMovimientosTentativos,
                                                       txtNumeroMovimientosPC,
                                                       txtNumeroMovimientosUsuario);

            ObjControladorJuego.InicializarControlesJuego(ListaBotones, txtTiempo, tmrCronometro, tmrControlMovimiento);
            ObjControladorJuego.InicilizarDatos();

            ObjControladorJuego.CargarCampoDeJuego(ListaBotones, grbRompecabezas, TextBox1,
                                                   TextBox2, listBox1, tmrCronometro,
                                                   tmrControlMusica, axWMPSonido);
        }

        private void mnuArchivoSalir_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.CerrarAplicacion(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.CerrarAplicacion(this);
        }

        private void mnuAyudaContenido_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.CargarAplicacion(new frmContenido());
        }

        private void mnuAyudaAcercaDe_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.CargarAplicacion(new frmAcercaDe());
        }

        private void tmrCronometro_Tick(object sender, EventArgs e)
        {
            ObjControladorJuego.CargarDatosCronometro(txtTiempo);
        }

        private void btnArmarRompecabezas_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ArmarRompecabezas(listBox2, tmrControlMovimiento);
        }        

        private void tmrControlMusica_Tick(object sender, EventArgs e)
        {
            ObjControladorJuego.ActualizarControlesSonido(tmrControlMusica, axWMPSonido);
        }

        private void tmrControlMovimiento_Tick(object sender, EventArgs e)
        {
            ObjControladorJuego.ControlarTiempoArmarRompecabezas(ListaBotones, listBox2, tmrCronometro);
        }

        private void btnRompecabezas1_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas1, ListaBotones, listBox1, 
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC, 
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas2_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas2, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas3_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas3, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas4_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas4, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas5_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas5, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas6_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas6, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas7_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas7, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas8_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas8, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas9_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas9, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas10_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas10, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas11_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas11, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas12_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas12, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas13_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas13, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas14_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas14, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas15_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas15, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }

        private void btnRompecabezas16_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.ActivarFichaJuego(btnRompecabezas16, ListaBotones, listBox1,
                                                  txtNumeroMovimientosUsuario, txtNumeroMovimientosPC,
                                                  TextBox1, TextBox2, grbRompecabezas, tmrCronometro);
        }
        
    }
}
