using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("raphael") && txtSenha.Text.Equals("123"))
                {
                    var mainView = new Main();
                    mainView.Show(); // mostra a tela nova

                    this.Hide(); // esconte this (arquivo que estou no caso login)

                }
                else
                {
                    MessageBox.Show("Login Inválido!",
                                    "Desculpe",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Desculpe",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_Enter(Object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.LightYellow;
        }

        private void txtSenha_Enter(Object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.LightYellow;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }
    }
}
