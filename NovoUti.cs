using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataEntity;
using DataAcess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recreativo
{
    public partial class NovoUti : Form
    {
        public NovoUti()
        {
            InitializeComponent();
        }

        private void NovoUti_Load_1(object sender, EventArgs e)
        {
            mtbPin.UseSystemPasswordChar = true;
            mtbConfirmar.UseSystemPasswordChar = true;

            var dataSource1 = new List<TipoAcesso>();
            dataSource1.Add(new TipoAcesso() { acesso = "Treinador", valor = 1 });
            dataSource1.Add(new TipoAcesso() { acesso = "Departamento Médico", valor = 2 });
            dataSource1.Add(new TipoAcesso() { acesso = "Psicosocial", valor = 3 });
            dataSource1.Add(new TipoAcesso() { acesso = "Diretor", valor = 4 });
            dataSource1.Add(new TipoAcesso() { acesso = "Vice-Presidente", valor = 5 });

            var dataSource2 = new List<Escalao>();
            dataSource2.Add(new Escalao() { escalao = "Traquinas", valor = 1 });
            dataSource2.Add(new Escalao() { escalao = "Benjamins", valor = 2 });
            dataSource2.Add(new Escalao() { escalao = "Infantis", valor = 3 });
            dataSource2.Add(new Escalao() { escalao = "Iniciados", valor = 4 });
            dataSource2.Add(new Escalao() { escalao = "Juvenis", valor = 5 });
            dataSource2.Add(new Escalao() { escalao = "Juniores", valor = 6 });

            this.cbTipo.DataSource = dataSource1;
            this.cbTipo.DisplayMember = "acesso";
            this.cbTipo.ValueMember = "valor";

            this.cbEscalao.DataSource = dataSource2;
            this.cbEscalao.DisplayMember = "escalao";
            this.cbEscalao.ValueMember = "valor";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int qtdNome = UtilizadorDAL.ContarUtilizadoresNome(txtUser.Text);

                if (qtdNome != 0)
                {
                    MessageBox.Show("Nome de utilizador já existente!");
                    txtUser.ResetText();

                }
                else
                {
                    Login login = new Login(txtUser.Text, txtNome.Text, int.Parse(mtbPin.Text), Convert.ToInt32(cbTipo.SelectedValue), Convert.ToInt32(cbEscalao.SelectedValue));

                    UtilizadorDAL.InserirUtilizador(login);

                    Close();
                }
            }
        }

        private bool validar()
        {
            bool erro = true;
            errorProvider1.Clear();

            if (txtUser.Text == "")
            {
                erro = false;
                errorProvider1.SetError(txtUser, "Preenchimento Obrigatorio");

            }
            if (txtNome.Text == "")
            {
                erro = false;
                errorProvider1.SetError(txtNome, "Preenchimento Obrigatorio");

            }
            if (!mtbPin.MaskCompleted)
            {
                erro = false;
                errorProvider1.SetError(mtbPin, "Preenchimento obrigatorio");
            }
            if (!mtbConfirmar.MaskCompleted)
            {
                erro = false;
                errorProvider1.SetError(mtbConfirmar, "Preenchimento obrigatorio");
            }
            else if (mtbPin.Text != mtbConfirmar.Text)
            {
                erro = false;
                errorProvider1.SetError(mtbConfirmar, "Pass diferente!");
            }

            return erro;
        }

        private void ckbPin_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPin.Checked)
            {
                mtbPin.UseSystemPasswordChar = false;
            }
            else
            {
                mtbPin.UseSystemPasswordChar = true;
            }
        }

        private void ckbConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbConfirmar.Checked)
            {
                mtbConfirmar.UseSystemPasswordChar = false;
            }
            else
            {
                mtbConfirmar.UseSystemPasswordChar = true;
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = cbTipo.SelectedIndex;
            if (valor == 0)
            {
                cbEscalao.Enabled = true;
            }
            else
            {
                cbEscalao.Enabled = false;
            }
        }
    }
}
