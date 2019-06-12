using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComponenteJuego
{
    public class ClaseGlobalJuego
    {
        #region Atributos de la clase
        ///<summary>
        ///Datos o variables miembro
        ///</summary>
        
        private static int mNumeroDeMovimientos;

        #endregion

        #region Propiedades
        ///<summary>
        ///Manejo de descriptores de acceso
        ///</summary>        

        public static int NumeroDeMovimientos
        {
            get { return mNumeroDeMovimientos; }
            set { mNumeroDeMovimientos = value; }
        }

        #endregion

        #region Constructores de la clase
        ///<summary>
        /// Constructores
        ///</summary>

        #endregion

        #region Métodos
        ///<summary>
        ///Funciones miembro
        ///</summary>              

        #endregion
    }
}
