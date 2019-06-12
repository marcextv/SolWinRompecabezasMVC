using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponenteJuego
{
    public class ControladorJuego
    {
        #region Atributos de la clase
        ///<summary>
        ///Datos o variables miembro
        ///</summary>

        private VistaJuego ObjVista;
        private CerebroJuego ObjCerebro;
        private Tiempo ObjTiempo;
        private Sonido ObjSonido;
        private GrafosRompecabezas ObjGrafosRompecabezas;

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

        public ControladorJuego()
        {
            ObjVista = new VistaJuego();
            ObjCerebro = new CerebroJuego();
            ObjTiempo = new Tiempo();
            ObjGrafosRompecabezas = new GrafosRompecabezas();
            ObjSonido = new Sonido();
        }

        #endregion

        #region Métodos
        ///<summary>
        ///Funciones miembro
        ///</summary>              

        public void CargarAplicacion(Form ObjFrm)
        {
            ObjVista.CargarFormulario(ObjFrm);            
        }

        public void InicializarConfiguracion(RadioButton rdbOpcion1, RadioButton rdbOpcion2, RadioButton rdbOpcion3)
        {
            ObjVista.InicializarControles(rdbOpcion1, rdbOpcion2, rdbOpcion3);
        }

        public void InicializarControlesJuego(List<Button> ListaBotones, TextBox txtTiempo,
                                              System.Windows.Forms.Timer tmrCronometro,
                                              System.Windows.Forms.Timer tmrControlMovimiento)
        {
            ObjVista.InicializarControles(ListaBotones);
            ObjTiempo.InicializarControles(txtTiempo, tmrCronometro, tmrControlMovimiento);
        }

        public void InicilizarDatos()
        {
            ObjTiempo.InicilizarDatos();
            ObjCerebro.InicializarDatos();
            ObjGrafosRompecabezas.InicilizarDatos();            
        }

        public void CargarCampoDeJuego(List<Button> ListaBotones, GroupBox grbRompecabezas, 
                                       TextBox TextBox1, TextBox TextBox2, ListBox listBox1,
                                       System.Windows.Forms.Timer tmrCronometro,
                                       System.Windows.Forms.Timer tmrControlMusica,
                                       AxWMPLib.AxWindowsMediaPlayer axWMPSonido)
        {
            ObjCerebro.ObtenerRompecabezasOrdenado(ListaBotones, grbRompecabezas);
            ObjGrafosRompecabezas.GenerarMovimientosPiezas_IA(ListaBotones, TextBox1, TextBox2, listBox1);
            ObjTiempo.ActivarCronometro(tmrCronometro);
            ObjTiempo.ActivarCronometro(tmrControlMusica);
            ObjSonido.CargarArchivoSonido(axWMPSonido);
        }           

        public void SeleccionarOpcionConfiguracion(RadioButton rdbOpcion1, RadioButton rdbOpcion2, RadioButton rdbOpcion3)
        {
            ObjVista.SeleccionarOpcion(rdbOpcion1, rdbOpcion2, rdbOpcion3);
        }

        public void ActualizarDatosDeCarga(TextBox txtNumeroMovimientosTentativos, 
                                           TextBox txtNumeroMovimientosPC,
                                           TextBox txtNumeroMovimientosUsuario)
        {
            ObjVista.ActualizarDatos(txtNumeroMovimientosTentativos, 
                                       txtNumeroMovimientosPC,
                                       txtNumeroMovimientosUsuario);            
        }

        public void CargarDatosCronometro(TextBox txtTiempo)
        {
            ObjTiempo.GenerarPanelCronometro(txtTiempo);            
        }

        public void ActualizarControlesSonido(System.Windows.Forms.Timer tmrControlMusica,
                                              AxWMPLib.AxWindowsMediaPlayer axWMPSonido)
        {
            ObjVista.ActualizarCargaSonido(tmrControlMusica, axWMPSonido);            
        }

        public void ArmarRompecabezas(ListBox ObjListBox, System.Windows.Forms.Timer ObjTimer)
        {
            ObjGrafosRompecabezas.GenerarDatosArmarRompecabezas_IA(ObjListBox);
            ObjTiempo.ActivarCronometro(ObjTimer);            
        }

        public void ControlarTiempoArmarRompecabezas(List<Button> ListaBotones, ListBox listBox2, System.Windows.Forms.Timer tmrCronometro)
        {
            ObjGrafosRompecabezas.ControlTiempoArmarRompecabezas_IA(ListaBotones, listBox2, tmrCronometro);            
        }

        public void ActivarFichaJuego(Button btnRompecabezas, List<Button> ListaBotones,
                                      ListBox listBox1, TextBox txtNumeroMovimientosUsuario,
                                      TextBox txtNumeroMovimientosPC, TextBox TextBox1,
                                      TextBox TextBox2, GroupBox grbRompecabezas,
                                      System.Windows.Forms.Timer tmrCronometro)
        {
            CerebroJuego.NumeroMovimientosUsuario = ObjCerebro.RegistrarJugadaUsuario(btnRompecabezas, ListaBotones, listBox1, ObjGrafosRompecabezas);
            txtNumeroMovimientosUsuario.Text = CerebroJuego.NumeroMovimientosUsuario.ToString();
            txtNumeroMovimientosPC.Text = GrafosRompecabezas.NumeroMovimientosPC.ToString();

            ObjCerebro.MoverFicha(btnRompecabezas, ListaBotones, TextBox1, TextBox2);
            ObjCerebro.VerificarGanador(ListaBotones, grbRompecabezas, tmrCronometro);

            //Rompecabezas.NumeroMovimientosUsuario = ObjRompecabezas.RegistrarJugadaUsuario(btnRompecabezas1, ListaBotones, listBox1, ObjDDC);
            //txtNumeroMovimientosUsuario.Text = Rompecabezas.NumeroMovimientosUsuario.ToString();
            //txtNumeroMovimientosPC.Text = DirectorDeComportamientos.NumeroMovimientosPC.ToString();

            //ObjRompecabezas.MoverFicha(btnRompecabezas1, ListaBotones, TextBox1, TextBox2);
            //ObjRompecabezas.VerificarGanador(ListaBotones, grbRompecabezas, tmrCronometro);
        }

        public void CerrarAplicacion(Form ObjForm)
        {
            ObjVista.CerrarFormulario(ObjForm);
        }

        #endregion
    }
}
