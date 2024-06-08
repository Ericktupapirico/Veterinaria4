

using System.Windows.Forms;

namespace Veterinaria4

{
    public partial class Form1 : Form
    {

        private VeterinarioService _veterinarioService;
       

        public Form1()
        {
            InitializeComponent();
            _veterinarioService = new VeterinarioService();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var veterinario = new Veterinario(textNombreVeterinario.Text, textContraseñaVeterinario.Text)
                {
                    Nombre = textNombreVeterinario.Text,
                    Contraseña = textContraseñaVeterinario.Text
                };
                _veterinarioService.AddVeterinario(veterinario);
                MessageBox.Show("Veterinario guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el veterinario: " + ex.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textContraseñaVeterinario.Text.Length < 6)
            {
                errorProvider1.SetError(textContraseñaVeterinario, "La contraseña debe tener al menos 6 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textContraseñaVeterinario, string.Empty);
            }
            ValidateForm();

        }

        private void textNombreVeterinario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombreVeterinario.Text))
            {
                errorProvider1.SetError(textNombreVeterinario, "El nombre no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(textNombreVeterinario, string.Empty);
            }
            ValidateForm();
        }
        private void ValidateForm()
        {
            bool isFormValid = !string.IsNullOrWhiteSpace(textNombreVeterinario.Text) &&
                               !string.IsNullOrWhiteSpace(textContraseñaVeterinario.Text) &&
                               textContraseñaVeterinario.Text.Length >= 6;

            btnGuardarVeterinario.Enabled = isFormValid;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
