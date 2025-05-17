using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_simple_enlazada
{
    public partial class Form1 : Form
    {
        Lista milista = new Lista();// Instancia de la lista enlazada para manejar los datos
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario (botones, cajas de texto, etc)
        }
        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                milista.AgregarInicio(txtNombre.Text); //llamar metodo AgregarInicio
                listBox1.Items.Clear(); // Limpiar la lista visual
                MostrarLista(milista.cabeza); //llamar metodo mostrar lista
                txtNombre.Clear(); // Limpiar el textbox
                ActualizarContador(); //Actualizar el contador
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre.");
            }
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                milista.AgregarFinal(txtNombre.Text); //Llamar metodo Agregar final
                listBox1.Items.Clear();
                MostrarLista(milista.cabeza);
                txtNombre.Clear();
                ActualizarContador(); //Actualizar el contador
            }
            else
            {
                MessageBox.Show("Ingrese el nombre");

            }
        }

        private void btnDespues_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtPosicion.Text);
            if (num >= 0)
            {
                milista.InsertarDespues(num, txtNombre.Text);
                listBox1.Items.Clear();
                MostrarLista(milista.cabeza);
                txtNombre.Clear();
                txtPosicion.Clear();
                ActualizarContador(); //Actualizar el contador
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            if (txtPosicion.Text != "")
            {
                int pos = int.Parse(txtPosicion.Text); // Convertir posición ingresada
                string nombre = milista.Obtener(pos);  // Obtener nombre en esa posición
                listBox2.Items.Clear();
                listBox2.Items.Add(nombre != null ? $"Posición {pos}: {nombre}" : "Posición no encontrada");
                txtPosicion.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese la posición.");
            }
        }
        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            milista.EliminarInicio(); // Eliminar primer nodo
            listBox1.Items.Clear();
            MostrarLista(milista.cabeza);
            ActualizarContador();
        }

        private void btnEliminarFinal_Click(object sender, EventArgs e)
        {
            milista.EliminarFinal();    
            listBox1.Items.Clear();
            MostrarLista(milista.cabeza);
            ActualizarContador();
        }
        private void btnEliminarPosicion_Click(object sender, EventArgs e)
        {
            milista.EliminarEnPosicionParticular(int.Parse(txtPosicion.Text));
            listBox1.Items.Clear();
            MostrarLista(milista.cabeza);
            ActualizarContador();

        }
        private void ActualizarContador()
        {
            lblContador.Text = "" + milista.LongitudDeLista().ToString();
        }
        private void MostrarLista(Nodo nodo) //se utiliza la rescursidad de manera que se va mostrando el nodo y luego llama a la siguiente posicion
        {
            if (nodo != null) // Verifica si el nodo no es nulo
            {
                listBox1.Items.Add(nodo.Nombre); // Agregar nombre a la lista visual
                MostrarLista(nodo.siguiente); 
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
