using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria4
{
    public partial class Form2 : Form
    {
        private ClienteService _clientesService;

        public Form2()
        {
            InitializeComponent();
            _clientesService = new ClienteService();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombreCliente.Text))
            {
                errorProvider1.SetError(textNombreCliente, "El nombre no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(textNombreCliente, string.Empty);
            }
            ValidateForm();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textNumCliente.Text.Length < 8)
            {
                errorProvider1.SetError(textNumCliente, "El numero debe tener 8 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textNumCliente, string.Empty);
            }
            ValidateForm();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textDireccionCliente.Text))
            {
                errorProvider1.SetError(textDireccionCliente, "La direccion no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(textDireccionCliente, string.Empty);
            }
            ValidateForm();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var cliente = new Cliente(textNombreCliente.Text, textIDCliente.Text, textNumCliente.Text, textDireccionCliente.Text)
                {
                    Nombre = textNombreCliente.Text,
                    Id = textIDCliente.Text,
                    Numeros = textNumCliente.Text,
                    Direccion = textDireccionCliente.Text
                };
                _clientesService.addClientes(cliente);
                MessageBox.Show("Cliente guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente " + ex.Message);
            }

        }
        private void ValidateForm()
        {
            bool isFormValid = !string.IsNullOrWhiteSpace(textNombreCliente.Text) &&
                               !string.IsNullOrWhiteSpace(textIDCliente.Text) &&
                               textNumCliente.Text.Length == 8;

            btnGuardarCliente.Enabled = isFormValid;
        }
    }
}
