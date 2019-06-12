using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponenteJuego
{
    public class Tiempo
    {
        #region Atributos de la clase
        ///<summary>
        ///Datos o variables miembro
        ///</summary>
        
        private static int mHoras;
        private static int mMinutos;
        private static int mSegundos;  
 
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

        public Tiempo()
        {
            mHoras = 0;
            mMinutos = 0;
            mSegundos = 0;
        }

        #endregion

        #region Métodos
        ///<summary>
        ///Funciones miembro
        ///</summary>              

        public void InicilizarDatos()
        {
            mHoras = 0;
            mMinutos = 0;
            mSegundos = 0;
        }

        public void InicializarControles(TextBox txtTiempo,
                                         System.Windows.Forms.Timer tmrCronometro,
                                         System.Windows.Forms.Timer tmrControlMovimiento)
        {
            txtTiempo.Text = "00" + ":" + "00" + ":" + "00";
            PararCronometro(tmrCronometro);
            PararCronometro(tmrControlMovimiento);
        }

        public void ActivarCronometro(System.Windows.Forms.Timer ObjTimer)
        {
            ObjTimer.Enabled = true;
        }

        public void PararCronometro(System.Windows.Forms.Timer ObjTimer)
        {
            ObjTimer.Enabled = false;
        }

        public void GenerarPanelCronometro(TextBox txtTiempo)
        {
            mSegundos++;
            if (mSegundos == 60)
            {
                mSegundos = 0;
                mMinutos++;
                if (mMinutos == 60)
                {
                    mMinutos = 0;
                    mHoras++;
                }
            }

            txtTiempo.Text = mHoras.ToString() + ":" +
                             mMinutos.ToString() + ":" +
                             mSegundos.ToString();
        }        

        #endregion
    }
}
