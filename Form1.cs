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

namespace Recreativo
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            mtbPin.UseSystemPasswordChar = true;
            txtuser.ResetText();
            mtbPin.ResetText();
        }

        private bool Validar()
        {
            bool erro = false;
            int qtdUsers = UtilizadorDAL.ContarUtilizadoresNome(txtuser.Text);
            errorProvider1.Clear();

            if (txtuser.Text == "")
            {
                erro = true;
                errorProvider1.SetError(txtuser, "Preenchimento obrigatório");
            }
            else if (mtbPin.Text == "")
            {
                erro = true;
                errorProvider1.SetError(mtbPin, "Preenchimento obrigatório");
            }
            else if (mtbPin.Text != "" && txtuser.Text != "")
            {
                if (qtdUsers == 0)
                {
                    erro = true;
                    txtuser.ResetText();
                    errorProvider1.SetError(txtuser, "Username não existente");
                }
                else
                {
                    int qtdUserPass = UtilizadorDAL.ContarUtilizadoresNomePin(txtuser.Text, int.Parse(mtbPin.Text));
                    if (qtdUserPass == 0)
                    {
                        erro = true;
                        mtbPin.ResetText();
                        errorProvider1.SetError(mtbPin, "Pass inválida.");
                    }
                }
            }
            return erro;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                int tipo = UtilizadorDAL.ConsultarTipo(txtuser.Text);
                switch (tipo)
                {
                    case 1:
                        this.Hide();
                        Frmtreinador menu1 = new Frmtreinador();
                        this.Visible = false;
                        menu1.ShowDialog();
                        txtuser.ResetText();
                        mtbPin.ResetText();
                        break;
                    case 2:
                        this.Hide();
                        FrmDepartamento menu2 = new FrmDepartamento();
                        this.Visible = false;
                        menu2.ShowDialog();
                        txtuser.ResetText();
                        mtbPin.ResetText();
                        break;
                    case 3:
                        this.Hide();
                        FrmPsicosocial menu3 = new FrmPsicosocial();
                        this.Visible = false;
                        menu3.ShowDialog();
                        txtuser.ResetText();
                        mtbPin.ResetText();
                        break;
                    case 4:
                        this.Hide();
                        FrmDiretor menu4 = new FrmDiretor();
                        this.Visible = false;
                        menu4.ShowDialog();
                        txtuser.ResetText();
                        mtbPin.ResetText();
                        break;
                    case 5:
                        this.Hide();
                        FrmVicePresidente menu5 = new FrmVicePresidente();
                        this.Visible = false;
                        menu5.ShowDialog();
                        txtuser.ResetText();
                        mtbPin.ResetText();
                        break;
                }
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            NovoUti novo = new NovoUti();
            novo.ShowDialog();

            txtuser.ResetText();
            mtbPin.ResetText();
        }
    }
}
