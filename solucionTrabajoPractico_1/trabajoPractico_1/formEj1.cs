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
    public partial class formEj1 : Form
    {
        public formEj1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length != 0)
            {
                string auxNombreApellido = armarNombreYApellido(txtNombre.Text); //junto el nombre y apellido sin espacios sobrantes

                if (lboxIngreso.Items.Count == 0) //Si la lista de elementos esta vacia lo agrego
                    lboxIngreso.Items.Add(auxNombreApellido.ToUpper());
                else
                {
                    bool existe = false;
                    foreach (string aux in lboxIngreso.Items)
                    {
                        if (String.Equals(auxNombreApellido, aux))
                        {
                            existe = true;
                            MessageBox.Show("El Elemento ya existe en la lista");
                            break;
                        }
                    }
                    if (existe == false)
                        lboxIngreso.Items.Add(auxNombreApellido);
                }
                txtNombre.Text = "";
            }
            else
                MessageBox.Show("INGRESE DATOS CORRECTAMENTE");
        }

        private void btnIngresoUno_Click(object sender, EventArgs e)
        {
            if (lboxIngreso.SelectedIndex==-1)
                MessageBox.Show("Seleccione un elemento");
            else
            {
                if (lboxGuardado.Items.Count == 0)
                {
                    lboxGuardado.Items.Add(lboxIngreso.SelectedItem.ToString());
                }
                else
                {
                    Boolean existe = false;
                    foreach (string aux in lboxGuardado.Items)
                    {
                        if (String.Equals(lboxIngreso.SelectedItem.ToString(), aux))
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (existe != true)
                        lboxGuardado.Items.Add(lboxIngreso.SelectedItem);
                    else
                        MessageBox.Show("No se puede agregar, el elemento ya existe");
                }
            }
        }

        private void btnIngresoTodos_Click(object sender, EventArgs e)
        {
            lboxGuardado.Items.Clear();
            if (lboxIngreso.Items.Count!=0)
            {
                for(int i = 0; i < lboxIngreso.Items.Count; i++)
                {
                    lboxGuardado.Items.Add(lboxIngreso.Items[i].ToString());
                }
            }
            /*
            if (lboxIngreso.SelectedIndex == -1)
                MessageBox.Show("Seleccione al menos un elemento");
            else
            {
                eliminarElementosGuardados();
                foreach(string aux in lboxIngreso.SelectedItems)
                {

                }
            }*/
            //lboxGuardado.Items.Add(lboxIngreso.SelectedItems);
        }

        private string armarNombreYApellido(string nombre)
        {
            string nombreApellido;
            nombre = nombre.Trim();
            nombreCorrecto(ref nombre);
            nombreApellido = nombre.ToUpper();
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
