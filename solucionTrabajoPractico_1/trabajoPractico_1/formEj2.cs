using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoPractico_1
{
    public partial class formEj2 : Form
    {
        public formEj2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text.Trim().Length != 0) && (txtApellido.Text.Trim().Length != 0))
            {
                string auxNombreApellido = armarNombreYApellido(txtNombre.Text,txtApellido.Text); //junto el nombre y apellido sin espacios sobrantes

                if (lboxElementos.Items.Count == 0) //Si la lista de elementos esta vacia lo agrego
                    lboxElementos.Items.Add(auxNombreApellido.ToUpper());
                else
                {
                    Boolean existe = false;
                    foreach (string aux in lboxElementos.Items)
                    {
                        if (String.Equals(auxNombreApellido, aux))
                        {
                            existe = true;
                            MessageBox.Show("El Elemento ya existe en la lista");
                            break;
                        }
                    }
                    if (existe == false)
                    {
                        lboxElementos.Items.Add(auxNombreApellido);
                    }       
                }
                txtNombre.Text = "";
                txtApellido.Text = "";
            }
            else
                MessageBox.Show("INGRESE DATOS CORRECTAMENTE");   
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lboxElementos.Items.Remove(lboxElementos.SelectedItem);
        }

        private string armarNombreYApellido(string nombre, string apellido)
        {
            string nombreApellido;
            nombre = nombre.Trim();
            nombreCorrecto(ref nombre);
            apellido=apellido.Trim();
            nombreCorrecto(ref apellido);
            nombreApellido = nombre + " " + apellido;
            nombreApellido = nombreApellido.ToUpper();
            return nombreApellido;
        }
        private void nombreCorrecto(ref string nombre)
        {
            string nombreSinEspacio = "";
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] != ' ')
                    nombreSinEspacio += nombre[i];
                else
                    if (nombre[i] == ' ' && nombre[i + 1] != ' ')
                    nombreSinEspacio += nombre[i];
            }
            nombre = nombreSinEspacio;
        }
    }  
}