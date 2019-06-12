using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponenteJuego
{
    public class Sonido
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

        public Sonido()
        {
            
        }

        #endregion

        #region Métodos
        ///<summary>
        ///Funciones miembro
        ///</summary>              

        public void ActivarCronometro(System.Windows.Forms.Timer tmrControlMusica)
        {
            tmrControlMusica.Enabled = true;
        }

        public void CargarArchivoSonido(AxWMPLib.AxWindowsMediaPlayer axWMPSonido)
        {

            //axWMPSonido.URL = @"C:\Users\César\Desktop\Documentos CV\Paper 15-Puzzle\Proyecto Modificado\SolucionWindowsRompecabezas\AplicacionWindowsRompecabezas\Recursos\alibombo.mid";
            //axWMPSonido.URL = @"C:\Users\Cesar\Desktop\Documentos Septiembre 2012\Tesis CV\IA\Razonamientos Hacia Adelante y Hacia Atras\Rompecabezas 15-Puzzle\SolWinRompecabezasMVC\WinAppRompecabezas\Recursos\alibombo.mid";
            axWMPSonido.URL = @"C:\Recursos\alibombo.mid";
        }

        public void PararCronometro(System.Windows.Forms.Timer tmrControlMusica)
        {
            tmrControlMusica.Enabled = false;
        }       

        #endregion
    }
}
