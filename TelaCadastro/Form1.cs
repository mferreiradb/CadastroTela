using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCadastro
{
    public partial class fmrCadastro : Form
    {
        List<Pessoa> pessoas;
        public fmrCadastro()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboBoxEstadoCivil.Items.Add("Casado");
            comboBoxEstadoCivil.Items.Add("Solteiro");
            comboBoxEstadoCivil.Items.Add("União Estável");

            comboBoxEstadoCivil.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idList = listBoxCadastros.SelectedIndex;
            pessoas.RemoveAt(idList);
            Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int id = -1;

            foreach(Pessoa p in pessoas)
            {
                if (p.Nome == txtBoxNome.Text)
                {
                    id = pessoas.IndexOf(p);
                }
            }

            if (txtBoxNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome");
                txtBoxNome.Focus();
                return;
            }

            if (txtTelefone.Text == "" )
            {
                MessageBox.Show("Preencha o campo Telefone");
                txtTelefone.Focus();
                return;
            }

            char sexo;

            if (radioButtonMasculino.Checked == true)
            {
                sexo = 'M';
            } else if (radioButtonFeminino.Checked == true)
            {
                sexo = 'F';
            } else
            {
                sexo = 'O';
            }

            Pessoa pessoa = new Pessoa();
            pessoa.Nome= txtBoxNome.Text;
            pessoa.Sexo= sexo;
            pessoa.DataNascimento = dateTimePickerNascimento.Text;
            pessoa.Telefone = txtTelefone.Text;
            pessoa.EstadoCivil = comboBoxEstadoCivil.SelectedItem.ToString();
            pessoa.CasaPropria = checkBoxCasaPropria.Checked;
            pessoa.Veiculo = checkBoxVeiculo.Checked;

            if (id < 0)
            {
                pessoas.Add(pessoa);
            } else
            {
                pessoas[id] = pessoa;
            }

            //MessageBox.Show(txtTelefone.Text);

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNome.Clear();
            dateTimePickerNascimento.Text = "";
            comboBoxEstadoCivil.SelectedIndex = 1;
            txtTelefone.Clear();
            checkBoxCasaPropria.Checked = false;
            checkBoxVeiculo.Checked = false;
            radioButtonMasculino.Checked = true;
            radioButtonFeminino.Checked = false;
            radioButtonOutro.Checked = false;
            txtBoxNome.Focus();

        }
        private void Listar() 
        {
            listBoxCadastros.Items.Clear();

            foreach (Pessoa pessoa in pessoas)
            {
                listBoxCadastros.Items.Add(pessoa.Nome);
                listBoxCadastros.Items.Add("Telefone: "+pessoa.Telefone);
            }
        }

        private void listBoxCadastros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCadastros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = listBoxCadastros.SelectedIndex;
            Pessoa pCad = pessoas[indice];

            txtBoxNome.Text= pCad.Nome;
            dateTimePickerNascimento.Text = pCad.DataNascimento;
            comboBoxEstadoCivil.SelectedItem = pCad.EstadoCivil;
            txtTelefone.Text = pCad.Telefone;
            checkBoxCasaPropria.Checked = pCad.CasaPropria;
            checkBoxVeiculo.Checked = pCad.Veiculo;

            switch (pCad.Sexo)
            {
                case 'F':
                    radioButtonFeminino.Checked = true;
                    break;
                case 'M':
                    radioButtonMasculino.Checked = true;
                    break;
                case 'O':
                    radioButtonOutro.Checked = true;
                    break;
            }

            txtBoxNome.Focus();
        }
    }
}
