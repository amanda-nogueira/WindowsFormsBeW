using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBeW
{
    public partial class Login : Form
    {
        //Instância do objeto
        User usuario = new User();
        Principal princ = new Principal();
        public Login()
        {
            InitializeComponent();
            usuario.SetNome("Neymar");
            usuario.SetUser("Ney");
            usuario.SetSenha("2022");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((usuario.GetUser() == textBox1.Text) && (usuario.GetSenha() == textBox2.Text))
            {
                MessageBox.Show(usuario.GetNome() + "\nAcesso permitido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Acesso negado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            princ.Show();
        }
    }
}
