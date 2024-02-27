namespace AsmaHADS
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click_1(object sender, EventArgs e)

        {
            erpIngreso.SetError(txtUsuario, null);
            erpIngreso.SetError(txtContrase�a, null);
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpIngreso.SetError(txtUsuario, "Por favor Ingrese el usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtContrase�a.Text))
            {
                erpIngreso.SetError(txtContrase�a, "Por favor Ingrese la contrase�a");
                return;
            }

            INegocioUsuario negocio = new NegocioUsuario(new RepositorioSeguridad());
            if (negocio.ValidarUsuario(txtUsuario.Text, txtContrase�a.Text))
            {
                var principal = new MDIPrincipal();
                principal.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Las credenciales de ingreso no son v�lidas. Por favor verifique.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}