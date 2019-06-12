using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using class WinAppRompecabezas;

namespace ComponenteJuego
{
    public class VistaJuego
    {
        #region Atributos de la clase
        ///<summary>
        ///Datos o variables miembro
        ///</summary>

        #endregion

        #region Propiedades
        ///<summary>
        ///Manejo de descriptores de acceso
        ///</summary>        

        #endregion

        #region Constructores de la clase
        ///<summary>
        /// Constructores
        ///</summary>

        public VistaJuego()
        {

        }

        #endregion

        #region Métodos
        ///<summary>
        ///Funciones miembro
        ///</summary>              

        public void CargarFormulario(Form ObjFrm)
        {
            ObjFrm.Show();
        }

        public void CerrarFormulario(Form ObjForm)
        {
            ObjForm.Close();
        }

        public void InicializarControles(RadioButton rdbOpcion1, RadioButton rdbOpcion2, RadioButton rdbOpcion3)
        {
            rdbOpcion1.Checked = false;
            rdbOpcion2.Checked = false;
            rdbOpcion3.Checked = false;            
        }

        public void InicializarControles(List<Button> ListaBotones)
        {
            for (int i = 0; i < ListaBotones.Count; i++)
                ListaBotones[i].Text = "1";

            for (int i = 0; i < ListaBotones.Count; i++)
                ListaBotones[i].Visible = true;            
        }

        public void SeleccionarOpcion(RadioButton rdbOpcion1, RadioButton rdbOpcion2, RadioButton rdbOpcion3)
        {
            if (rdbOpcion1.Checked == true)
            {
                ClaseGlobalJuego.NumeroDeMovimientos = 16;
            }
            if (rdbOpcion2.Checked == true)
            {
                ClaseGlobalJuego.NumeroDeMovimientos = 32;
            }
            if (rdbOpcion3.Checked == true)
            {
                ClaseGlobalJuego.NumeroDeMovimientos = 64;
            }
        }

        public void ActualizarDatos(TextBox txtNumeroMovimientosTentativos,
                                    TextBox txtNumeroMovimientosPC,
                                    TextBox txtNumeroMovimientosUsuario)
        {
            txtNumeroMovimientosTentativos.Text = ClaseGlobalJuego.NumeroDeMovimientos.ToString();
            GrafosRompecabezas.NumeroMovimientosPC = ClaseGlobalJuego.NumeroDeMovimientos;
            txtNumeroMovimientosPC.Text = GrafosRompecabezas.NumeroMovimientosPC.ToString();
            CerebroJuego.NumeroMovimientosUsuario = 0;
            txtNumeroMovimientosUsuario.Text = CerebroJuego.NumeroMovimientosUsuario.ToString();
        }

        public void ActualizarCargaSonido(System.Windows.Forms.Timer tmrControlMusica,
                                          AxWMPLib.AxWindowsMediaPlayer axWMPSonido)
        {
            if (tmrControlMusica.Interval == 40000)
            {
                tmrControlMusica.Enabled = false;
                axWMPSonido.Ctlcontrols.stop();
                tmrControlMusica.Enabled = true;
                axWMPSonido.Ctlcontrols.play();
            }
        }

        #endregion
    }
}
