using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponenteJuego
{
    public class CerebroJuego
    {
        #region Atributos de la clase
        ///<summary>
        ///Datos o variables miembro
        ///</summary>

        private int[] mArregloPiezas = new int[16];
        private int mPosicionCasilleroVacio;
        private int mPosicionCasilleroOcupado;
        private int mContador;

        private Tiempo ObjTiempo = new Tiempo();
        private GrafosRompecabezas ObjGrafoRompecabezas = new GrafosRompecabezas();

        private static int mNumeroMovimientosUsuario;
        
        #endregion

        #region Propiedades
        ///<summary>
        ///Manejo de descriptores de acceso
        ///</summary>        

        public static int NumeroMovimientosUsuario
        {
            get { return mNumeroMovimientosUsuario; }
            set { mNumeroMovimientosUsuario = value; }
        }

        #endregion

        #region Constructores de la clase
        ///<summary>
        /// Constructores
        ///</summary>

        public CerebroJuego()
        {
            int i;
            for (i = 0; i < mArregloPiezas.Length; i++)
                mArregloPiezas[i] = i + 1;

            mPosicionCasilleroVacio = 0;
            mPosicionCasilleroOcupado = 0;
            mContador = 0;
        }

        #endregion

        #region Métodos
        ///<summary>
        ///Funciones miembro
        ///</summary>              

        public void InicializarDatos()
        {
            int i;
            for (i = 0; i < mArregloPiezas.Length; i++)
                mArregloPiezas[i] = i + 1;

            mPosicionCasilleroVacio = 0;
            mPosicionCasilleroOcupado = 0;
            mContador = 0;
        }

        public void ObtenerRompecabezasOrdenado(List<Button> ListaBotones, GroupBox grbRompecabezas)
        {
            int i;

            for (i = 0; i < mArregloPiezas.Length; i++)
                mArregloPiezas[i] = i + 1;

            for (i = 0; i < mArregloPiezas.Length - 1; i++)
                ListaBotones[i].Text = mArregloPiezas[i].ToString();

            ListaBotones[15].Visible = false;
            ListaBotones[15].Text = "-1";

            grbRompecabezas.Enabled = true;
        }

        public void ObtenerRompecabezasAleatorio(List<Button> ListaBotones, GroupBox grbRompecabezas)
        {
            int i, indice;

            for (i = 0; i < mArregloPiezas.Length; i++)
                mArregloPiezas[i] = i + 1;

            Random random = new Random();
            mContador = 0;
            do
            {
                indice = random.Next() % 15;
                if (mArregloPiezas[indice] != 0)
                {
                    ListaBotones[mContador].Text = mArregloPiezas[indice].ToString();
                    mContador = mContador + 1;
                    mArregloPiezas[indice] = 0;
                }
            }
            while (mContador != 15);

            for (i = 0; i < ListaBotones.Count - 1; i++)
                ListaBotones[i].Visible = true;

            ListaBotones[15].Visible = false;
            ListaBotones[15].Text = "-1";

            grbRompecabezas.Enabled = true;
        }

        public void MoverFicha(Button ObjBtn, List<Button> ListaBotones, TextBox TextBox1, TextBox TextBox2)
        {
            mPosicionCasilleroOcupado = ObjBtn.TabIndex;
            mPosicionCasilleroVacio = ObjGrafoRompecabezas.BuscarFichaVacia(ListaBotones);

            TextBox1.Text = mPosicionCasilleroOcupado.ToString();
            TextBox2.Text = mPosicionCasilleroVacio.ToString();

            ObjGrafoRompecabezas.IntercambioDatosFichas(ListaBotones, mPosicionCasilleroOcupado, mPosicionCasilleroVacio);
        }

        public int RegistrarJugadaUsuario(Button btnPuzzle, List<Button> ListaBotones, ListBox listBox1, GrafosRompecabezas ObjAux)
        {
            int dato;
            dato = btnPuzzle.TabIndex;
            ObjGrafoRompecabezas.InsertarListaDatosMovimientos(ObjAux, dato);
            listBox1.Items.Add(dato.ToString());
            mNumeroMovimientosUsuario += 1;
            GrafosRompecabezas.NumeroMovimientosPC += 1;

            return mNumeroMovimientosUsuario;
        }
        
        public void VerificarGanador(List<Button> ListaBotones, GroupBox grbRompecabezas, System.Windows.Forms.Timer tmrCronometro)
        {
            mContador = 0;
            int indice, ValorFicha;

            for (int i = 0; i < ListaBotones.Count; i++)
            {
                indice = ListaBotones[i].TabIndex;
                ValorFicha = int.Parse(ListaBotones[i].Text);
                if (indice == ValorFicha - 1)
                {
                    mContador++;
                }
            }

            if (mContador == 15)
            {
                MessageBox.Show("Fin del juego...Felicitaciones");
                grbRompecabezas.Enabled = false;
                ObjTiempo.PararCronometro(tmrCronometro);
            }
        }


        #endregion
    }
}
