using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//referencia System.Drawing
using System.Drawing;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cUtilitarios
    {
        /* ===========================Ingreso de solo numeros y solo letras========*/
        //ingresar solo numeros
        public void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        //ingresar solo letras
        public void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        //Devuelve false cuando abriste mas de una ventana
        public bool verificarventanaabierta(string windowName)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.Equals(windowName))
                {
                    Application.OpenForms[i].BringToFront();
                    return false;
                }
            }
            return true;
        }

        public string GenerarNumero(int N)
        {
            String[] Unidad = { "", "PRIMERA", "SEGUNDA", "TERCERA",
            "CUARTA", "QUINTA", "SEXTA", "SEPTIMA", "OCTAVA",
            "NOVENA" };
            String[] Decena = { "", "DECIMA", "VIGESIMA", "TRIGESIMA",
            "CUADRAGESIMA", "QUINCUAGESIMA", "SEXAGESIMA",
            "SEPTUAGESIMA", "OCTOGESIMA", "NONAGESIMA" };
            String[] Centena = {"", "centesimo", "ducentesimo",
            "tricentesimo", " cuadringentesimo", " quingentesimo",
            " sexcentesimo", " septingentesimo", " octingentesimo",
            " noningentesimo"};

            string Num = "";
            int u = N % 10;
            int d = (N / 10) % 10;
            int c = N / 100;
            if (N >= 100)
            {
                Num = Centena[c] + " " + Decena[d] + " " + Unidad[u];
            }
            else
            {
                if (N >= 10)
                {
                    Num = Decena[d] + " " + Unidad[u];
                }
                else
                {
                    Num = Unidad[N];
                }
            }
            return Num;
        }

        public string GenerarNumeroMasculino(int N)
        {
            String[] Unidad = { "", "PRIMER", "SEGUNDO", "TERCER",
            "CUARTO", "QUINTO", "SEXTO", "SEPTIMO", "OCTAVO",
            "NOVENO" };
            String[] Decena = { "", "DECIMO", "VIGESIMO", "TRIGESIMO",
            "CUADRAGESIMO", "QUINCUAGESIMO", "SEXAGESIMO",
            "SEPTUAGESIMO", "OCTOGESIMO", "NONAGESIMO" };
            String[] Centena = {"", "centesimo", "ducentesimo",
            "tricentesimo", " cuadringentesimo", " quingentesimo",
            " sexcentesimo", " septingentesimo", " octingentesimo",
            " noningentesimo"};

            string Num = "";
            int u = N % 10;
            int d = (N / 10) % 10;
            int c = N / 100;
            if (N >= 100)
            {
                Num = Centena[c] + " " + Decena[d] + " " + Unidad[u];
            }
            else
            {
                if (N >= 10)
                {
                    Num = Decena[d] + " " + Unidad[u];
                }
                else
                {
                    Num = Unidad[N];
                }
            }
            return Num;
        }

    }
}
