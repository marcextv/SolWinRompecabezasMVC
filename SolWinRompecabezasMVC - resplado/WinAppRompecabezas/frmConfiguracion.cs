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
    public partial class frmConfiguracion : Form
    {
        ControladorJuego ObjControladorJuego = new ControladorJuego();

        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            ObjControladorJuego.InicializarConfiguracion(rdbOpcion1, rdbOpcion2, rdbOpcion3);            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.SeleccionarOpcionConfiguracion(rdbOpcion1, rdbOpcion2, rdbOpcion3);

            ObjControladorJuego.CargarAplicacion(new frmRompecabezas());
            //frmRompecabezas ObjFrm = new frmRompecabezas();
            //ObjFrm.Show();
        }        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ObjControladorJuego.CerrarAplicacion(this);
        }
    }
}
