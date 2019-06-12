using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponenteJuego
{
    public class GrafosRompecabezas
    {
        #region Atributos de la clase
        ///<summary>
        ///Datos o variables miembro
        ///</summary>

        private int mPosicionCasilleroVacio;
        private int mPosicionCasilleroOcupado;
        private int mContador;
        
        private List<int> mListaDatosMovimientos = new List<int>();
        
        private List<int> mG0 = new List<int>();
        private List<int> mG1 = new List<int>();
        private List<int> mG2 = new List<int>();
        private List<int> mG3 = new List<int>();
        private List<int> mG4 = new List<int>();
        private List<int> mG5 = new List<int>();
        private List<int> mG6 = new List<int>();
        private List<int> mG7 = new List<int>();
        private List<int> mG8 = new List<int>();
        private List<int> mG9 = new List<int>();
        private List<int> mG10 = new List<int>();
        private List<int> mG11 = new List<int>();
        private List<int> mG12 = new List<int>();
        private List<int> mG13 = new List<int>();
        private List<int> mG14 = new List<int>();
        private List<int> mG15 = new List<int>();
        private Tiempo ObjTiempo = new Tiempo();
        
        private static int mNumeroMovimientosPC;

        #endregion

        #region Propiedades
        ///<summary>
        ///Manejo de descriptores de acceso
        ///</summary>        

        public static int NumeroMovimientosPC
        {
            get { return mNumeroMovimientosPC; }
            set { mNumeroMovimientosPC = value; }
        }

        #endregion

        #region Constructores de la clase
        ///<summary>
        /// Constructores
        ///</summary>

        public GrafosRompecabezas()
        {
            mPosicionCasilleroVacio = 0;
            mPosicionCasilleroOcupado = 0;
            mContador = 0;
            mListaDatosMovimientos.Clear();

            mG0.Add(0); mG0.Add(1); mG0.Add(4);
            mG1.Add(1); mG1.Add(0); mG1.Add(2); mG1.Add(5);
            mG2.Add(2); mG2.Add(1); mG2.Add(3); mG2.Add(6);
            mG3.Add(3); mG3.Add(2); mG3.Add(7);
            mG4.Add(4); mG4.Add(0); mG4.Add(5); mG4.Add(8);
            mG5.Add(5); mG5.Add(1); mG5.Add(4); mG5.Add(6); mG5.Add(9);
            mG6.Add(6); mG6.Add(2); mG6.Add(5); mG6.Add(7); mG6.Add(10);
            mG7.Add(7); mG7.Add(3); mG7.Add(6); mG7.Add(11);
            mG8.Add(8); mG8.Add(4); mG8.Add(9); mG8.Add(12);
            mG9.Add(9); mG9.Add(5); mG9.Add(8); mG9.Add(10); mG9.Add(13);
            mG10.Add(10); mG10.Add(6); mG10.Add(9); mG10.Add(11); mG10.Add(14);
            mG11.Add(11); mG11.Add(7); mG11.Add(10); mG11.Add(15);
            mG12.Add(12); mG12.Add(8); mG12.Add(13);
            mG13.Add(13); mG13.Add(9); mG13.Add(12); mG13.Add(14);
            mG14.Add(14); mG14.Add(10); mG14.Add(13); mG14.Add(15);
            mG15.Add(15); mG15.Add(11); mG15.Add(14);
        }

        #endregion

        #region Métodos
        ///<summary>
        ///Funciones miembro
        ///</summary>              

        public void InicilizarDatos()
        {
            mPosicionCasilleroVacio = 0;
            mPosicionCasilleroOcupado = 0;
            mContador = 0;
            mListaDatosMovimientos.Clear();
        }

        public void InsertarListaDatosMovimientos(GrafosRompecabezas ObjAux, int dato)
        {
            ObjAux.mListaDatosMovimientos.Add(dato);
            //m_ListaDatosMovimientos.Add(dato);
        }

        public void InvertirListaDatosMovimientos(ListBox listBox2)
        {
            listBox2.Items.Clear();
            mListaDatosMovimientos.Reverse();
        }

        public int BuscarFichaVacia(List<Button> ListaBotones)
        {
            mPosicionCasilleroVacio = 0;

            for (int i = 0; i < ListaBotones.Count; i++)
            {
                if (ListaBotones[i].Text == "-1")
                {
                    mPosicionCasilleroVacio = ListaBotones[i].TabIndex;
                    return (mPosicionCasilleroVacio);
                }
            }

            return (mPosicionCasilleroVacio);
        }

        public void IntercambioDatosFichas(List<Button> ListaBotones)
        {
            if ((mPosicionCasilleroVacio == 0 && mPosicionCasilleroOcupado == 1) || (mPosicionCasilleroVacio == 0 && mPosicionCasilleroOcupado == 4) ||
                (mPosicionCasilleroVacio == 1 && mPosicionCasilleroOcupado == 0) || (mPosicionCasilleroVacio == 1 && mPosicionCasilleroOcupado == 2) || (mPosicionCasilleroVacio == 1 && mPosicionCasilleroOcupado == 5) ||
                (mPosicionCasilleroVacio == 2 && mPosicionCasilleroOcupado == 1) || (mPosicionCasilleroVacio == 2 && mPosicionCasilleroOcupado == 3) || (mPosicionCasilleroVacio == 2 && mPosicionCasilleroOcupado == 6) ||
                (mPosicionCasilleroVacio == 3 && mPosicionCasilleroOcupado == 2) || (mPosicionCasilleroVacio == 3 && mPosicionCasilleroOcupado == 7) ||
                (mPosicionCasilleroVacio == 4 && mPosicionCasilleroOcupado == 0) || (mPosicionCasilleroVacio == 4 && mPosicionCasilleroOcupado == 5) || (mPosicionCasilleroVacio == 4 && mPosicionCasilleroOcupado == 8) ||
                (mPosicionCasilleroVacio == 5 && mPosicionCasilleroOcupado == 1) || (mPosicionCasilleroVacio == 5 && mPosicionCasilleroOcupado == 4) || (mPosicionCasilleroVacio == 5 && mPosicionCasilleroOcupado == 6) || (mPosicionCasilleroVacio == 5 && mPosicionCasilleroOcupado == 9) ||
                (mPosicionCasilleroVacio == 6 && mPosicionCasilleroOcupado == 2) || (mPosicionCasilleroVacio == 6 && mPosicionCasilleroOcupado == 5) || (mPosicionCasilleroVacio == 6 && mPosicionCasilleroOcupado == 7) || (mPosicionCasilleroVacio == 6 && mPosicionCasilleroOcupado == 10) ||
                (mPosicionCasilleroVacio == 7 && mPosicionCasilleroOcupado == 3) || (mPosicionCasilleroVacio == 7 && mPosicionCasilleroOcupado == 6) || (mPosicionCasilleroVacio == 7 && mPosicionCasilleroOcupado == 11) ||
                (mPosicionCasilleroVacio == 8 && mPosicionCasilleroOcupado == 4) || (mPosicionCasilleroVacio == 8 && mPosicionCasilleroOcupado == 9) || (mPosicionCasilleroVacio == 8 && mPosicionCasilleroOcupado == 12) ||
                (mPosicionCasilleroVacio == 9 && mPosicionCasilleroOcupado == 5) || (mPosicionCasilleroVacio == 9 && mPosicionCasilleroOcupado == 8) || (mPosicionCasilleroVacio == 9 && mPosicionCasilleroOcupado == 10) || (mPosicionCasilleroVacio == 9 && mPosicionCasilleroOcupado == 13) ||
                (mPosicionCasilleroVacio == 10 && mPosicionCasilleroOcupado == 6) || (mPosicionCasilleroVacio == 10 && mPosicionCasilleroOcupado == 9) || (mPosicionCasilleroVacio == 10 && mPosicionCasilleroOcupado == 11) || (mPosicionCasilleroVacio == 10 && mPosicionCasilleroOcupado == 14) ||
                (mPosicionCasilleroVacio == 11 && mPosicionCasilleroOcupado == 7) || (mPosicionCasilleroVacio == 11 && mPosicionCasilleroOcupado == 10) || (mPosicionCasilleroVacio == 11 && mPosicionCasilleroOcupado == 15) ||
                (mPosicionCasilleroVacio == 12 && mPosicionCasilleroOcupado == 8) || (mPosicionCasilleroVacio == 12 && mPosicionCasilleroOcupado == 13) ||
                (mPosicionCasilleroVacio == 13 && mPosicionCasilleroOcupado == 9) || (mPosicionCasilleroVacio == 13 && mPosicionCasilleroOcupado == 12) || (mPosicionCasilleroVacio == 13 && mPosicionCasilleroOcupado == 14) ||
                (mPosicionCasilleroVacio == 14 && mPosicionCasilleroOcupado == 10) || (mPosicionCasilleroVacio == 14 && mPosicionCasilleroOcupado == 13) || (mPosicionCasilleroVacio == 14 && mPosicionCasilleroOcupado == 15) ||
                (mPosicionCasilleroVacio == 15 && mPosicionCasilleroOcupado == 11) || (mPosicionCasilleroVacio == 15 && mPosicionCasilleroOcupado == 14))
            {
                ListaBotones[mPosicionCasilleroVacio].Text = ListaBotones[mPosicionCasilleroOcupado].Text;
                ListaBotones[mPosicionCasilleroVacio].Visible = true;
                ListaBotones[mPosicionCasilleroOcupado].Text = "-1";
                ListaBotones[mPosicionCasilleroOcupado].Visible = false;
            }
        }

        public void IntercambioDatosFichas(List<Button> ListaBotones, int PosicionCasilleroOcupado, int PosicionCasilleroVacio)
        {
            mPosicionCasilleroOcupado = PosicionCasilleroOcupado;
            mPosicionCasilleroVacio = PosicionCasilleroVacio;

            if ((mPosicionCasilleroVacio == 0 && mPosicionCasilleroOcupado == 1) || (mPosicionCasilleroVacio == 0 && mPosicionCasilleroOcupado == 4) ||
                (mPosicionCasilleroVacio == 1 && mPosicionCasilleroOcupado == 0) || (mPosicionCasilleroVacio == 1 && mPosicionCasilleroOcupado == 2) || (mPosicionCasilleroVacio == 1 && mPosicionCasilleroOcupado == 5) ||
                (mPosicionCasilleroVacio == 2 && mPosicionCasilleroOcupado == 1) || (mPosicionCasilleroVacio == 2 && mPosicionCasilleroOcupado == 3) || (mPosicionCasilleroVacio == 2 && mPosicionCasilleroOcupado == 6) ||
                (mPosicionCasilleroVacio == 3 && mPosicionCasilleroOcupado == 2) || (mPosicionCasilleroVacio == 3 && mPosicionCasilleroOcupado == 7) ||
                (mPosicionCasilleroVacio == 4 && mPosicionCasilleroOcupado == 0) || (mPosicionCasilleroVacio == 4 && mPosicionCasilleroOcupado == 5) || (mPosicionCasilleroVacio == 4 && mPosicionCasilleroOcupado == 8) ||
                (mPosicionCasilleroVacio == 5 && mPosicionCasilleroOcupado == 1) || (mPosicionCasilleroVacio == 5 && mPosicionCasilleroOcupado == 4) || (mPosicionCasilleroVacio == 5 && mPosicionCasilleroOcupado == 6) || (mPosicionCasilleroVacio == 5 && mPosicionCasilleroOcupado == 9) ||
                (mPosicionCasilleroVacio == 6 && mPosicionCasilleroOcupado == 2) || (mPosicionCasilleroVacio == 6 && mPosicionCasilleroOcupado == 5) || (mPosicionCasilleroVacio == 6 && mPosicionCasilleroOcupado == 7) || (mPosicionCasilleroVacio == 6 && mPosicionCasilleroOcupado == 10) ||
                (mPosicionCasilleroVacio == 7 && mPosicionCasilleroOcupado == 3) || (mPosicionCasilleroVacio == 7 && mPosicionCasilleroOcupado == 6) || (mPosicionCasilleroVacio == 7 && mPosicionCasilleroOcupado == 11) ||
                (mPosicionCasilleroVacio == 8 && mPosicionCasilleroOcupado == 4) || (mPosicionCasilleroVacio == 8 && mPosicionCasilleroOcupado == 9) || (mPosicionCasilleroVacio == 8 && mPosicionCasilleroOcupado == 12) ||
                (mPosicionCasilleroVacio == 9 && mPosicionCasilleroOcupado == 5) || (mPosicionCasilleroVacio == 9 && mPosicionCasilleroOcupado == 8) || (mPosicionCasilleroVacio == 9 && mPosicionCasilleroOcupado == 10) || (mPosicionCasilleroVacio == 9 && mPosicionCasilleroOcupado == 13) ||
                (mPosicionCasilleroVacio == 10 && mPosicionCasilleroOcupado == 6) || (mPosicionCasilleroVacio == 10 && mPosicionCasilleroOcupado == 9) || (mPosicionCasilleroVacio == 10 && mPosicionCasilleroOcupado == 11) || (mPosicionCasilleroVacio == 10 && mPosicionCasilleroOcupado == 14) ||
                (mPosicionCasilleroVacio == 11 && mPosicionCasilleroOcupado == 7) || (mPosicionCasilleroVacio == 11 && mPosicionCasilleroOcupado == 10) || (mPosicionCasilleroVacio == 11 && mPosicionCasilleroOcupado == 15) ||
                (mPosicionCasilleroVacio == 12 && mPosicionCasilleroOcupado == 8) || (mPosicionCasilleroVacio == 12 && mPosicionCasilleroOcupado == 13) ||
                (mPosicionCasilleroVacio == 13 && mPosicionCasilleroOcupado == 9) || (mPosicionCasilleroVacio == 13 && mPosicionCasilleroOcupado == 12) || (mPosicionCasilleroVacio == 13 && mPosicionCasilleroOcupado == 14) ||
                (mPosicionCasilleroVacio == 14 && mPosicionCasilleroOcupado == 10) || (mPosicionCasilleroVacio == 14 && mPosicionCasilleroOcupado == 13) || (mPosicionCasilleroVacio == 14 && mPosicionCasilleroOcupado == 15) ||
                (mPosicionCasilleroVacio == 15 && mPosicionCasilleroOcupado == 11) || (mPosicionCasilleroVacio == 15 && mPosicionCasilleroOcupado == 14))
            {
                ListaBotones[mPosicionCasilleroVacio].Text = ListaBotones[mPosicionCasilleroOcupado].Text;
                ListaBotones[mPosicionCasilleroVacio].Visible = true;
                ListaBotones[mPosicionCasilleroOcupado].Text = "-1";
                ListaBotones[mPosicionCasilleroOcupado].Visible = false;
            }
        }

        /// <summary>
        /// //////////////////
        /// </summary>
        /// <param name="ListaBotones"></param>
        /// <param name="TextBox1"></param>
        /// <param name="TextBox2"></param>
        /// <param name="listBox1"></param>
        /// <param name="nMovimientos"></param>

        public void GenerarMovimientosPiezas_IA(List<Button> ListaBotones, TextBox TextBox1, TextBox TextBox2, ListBox listBox1)
        {
            int indice, contador;

            contador = 0;
            listBox1.Items.Clear();

            mPosicionCasilleroVacio = BuscarFichaVacia(ListaBotones);
            mListaDatosMovimientos.Add(mPosicionCasilleroVacio);
            listBox1.Items.Add(mListaDatosMovimientos[contador].ToString());

            ////// Versión 2
            contador = 1;
            do
            {
                Random ObjRnd = new Random();

                mPosicionCasilleroVacio = BuscarFichaVacia(ListaBotones);

                if (mPosicionCasilleroVacio == mG0[0])
                {
                    indice = ObjRnd.Next(0, 2);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG0[1];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG0[2];
                    }
                }
                if (mPosicionCasilleroVacio == mG1[0])
                {
                    indice = ObjRnd.Next(0, 3);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG1[3];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG1[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG1[1];
                    }
                }
                if (mPosicionCasilleroVacio == mG2[0])
                {
                    indice = ObjRnd.Next(0, 3);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG2[1];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG2[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG2[3];
                    }
                }
                if (mPosicionCasilleroVacio == mG3[0])
                {
                    indice = ObjRnd.Next(0, 2);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG3[2];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG3[1];
                    }
                }
                if (mPosicionCasilleroVacio == mG4[0])
                {
                    indice = ObjRnd.Next(0, 3);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG4[1];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG4[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG4[3];
                    }
                }
                if (mPosicionCasilleroVacio == mG5[0])
                {
                    indice = ObjRnd.Next(0, 4);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG5[4];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG5[3];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG5[2];
                    }
                    if (indice == 3)
                    {
                        mPosicionCasilleroOcupado = mG5[1];
                    }
                }
                if (mPosicionCasilleroVacio == mG6[0])
                {
                    indice = ObjRnd.Next(0, 4);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG6[1];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG6[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG6[3];
                    }
                    if (indice == 3)
                    {
                        mPosicionCasilleroOcupado = mG6[4];
                    }
                }
                if (mPosicionCasilleroVacio == mG7[0])
                {
                    indice = ObjRnd.Next(0, 3);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG7[3];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG7[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG7[1];
                    }
                }
                if (mPosicionCasilleroVacio == mG8[0])
                {
                    indice = ObjRnd.Next(0, 3);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG8[1];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG8[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG8[3];
                    }
                }
                if (mPosicionCasilleroVacio == mG9[0])
                {
                    indice = ObjRnd.Next(0, 4);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG9[4];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG9[3];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG9[2];
                    }
                    if (indice == 3)
                    {
                        mPosicionCasilleroOcupado = mG9[1];
                    }
                }
                if (mPosicionCasilleroVacio == mG10[0])
                {
                    indice = ObjRnd.Next(0, 4);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG10[1];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG10[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG10[3];
                    }
                    if (indice == 3)
                    {
                        mPosicionCasilleroOcupado = mG10[4];
                    }
                }
                if (mPosicionCasilleroVacio == mG11[0])
                {
                    indice = ObjRnd.Next(0, 3);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG11[3];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG11[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG11[1];
                    }
                }
                if (mPosicionCasilleroVacio == mG12[0])
                {
                    indice = ObjRnd.Next(0, 2);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG12[1];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG12[2];
                    }
                }
                if (mPosicionCasilleroVacio == mG13[0])
                {
                    indice = ObjRnd.Next(0, 3);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG13[3];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG13[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG13[1];
                    }
                }
                if (mPosicionCasilleroVacio == mG14[0])
                {
                    indice = ObjRnd.Next(0, 3);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG14[1];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG14[2];
                    }
                    if (indice == 2)
                    {
                        mPosicionCasilleroOcupado = mG14[3];
                    }
                }
                if (mPosicionCasilleroVacio == mG15[0])
                {
                    indice = ObjRnd.Next(0, 2);
                    if (indice == 0)
                    {
                        mPosicionCasilleroOcupado = mG15[2];
                    }
                    if (indice == 1)
                    {
                        mPosicionCasilleroOcupado = mG15[1];
                    }
                }
                //////////////////////

                mListaDatosMovimientos.Add(mPosicionCasilleroOcupado);
                listBox1.Items.Add(mListaDatosMovimientos[contador].ToString());
                TextBox1.Text = mPosicionCasilleroOcupado.ToString();
                TextBox2.Text = mPosicionCasilleroVacio.ToString();

                IntercambioDatosFichas(ListaBotones);
                contador++;
            } while (contador <= mNumeroMovimientosPC);
        }

        public void GenerarDatosArmarRompecabezas_IA(ListBox ObjListBox)
        {
            InvertirListaDatosMovimientos(ObjListBox);
        }

        public void ControlTiempoArmarRompecabezas_IA(List<Button> ListaBotones, ListBox ObjListBox, System.Windows.Forms.Timer tmrCronometro)
        {
            if (mContador < mListaDatosMovimientos.Count)
            {
                ObjListBox.Items.Add(mListaDatosMovimientos[mContador].ToString());
                mPosicionCasilleroVacio = BuscarFichaVacia(ListaBotones);
                mPosicionCasilleroOcupado = mListaDatosMovimientos[mContador];

                IntercambioDatosFichas(ListaBotones);
                mContador++;
            }

            if (mContador == mListaDatosMovimientos.Count)
            {
                ObjTiempo.PararCronometro(tmrCronometro);
            }
        }

        #endregion
    }
}
