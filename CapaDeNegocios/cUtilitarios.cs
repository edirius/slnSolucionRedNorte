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

    }
}
