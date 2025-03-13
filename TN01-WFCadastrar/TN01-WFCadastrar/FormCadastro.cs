using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroEndereco
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            cbxUf.SelectedIndex = 0;

        }
        public void Alerta(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Erro(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Sucesso(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(mtbCep.Text))
            {
                Erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtLogradouro.Text))
            {
                Erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtNumero.Text) && chkSemNumero.Checked == false)
            {
                Erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                Erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                Erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(cbxUf.SelectedItem?.ToString()))
            {
                Erro("Campo Vazio");
                return;
            }
            Endereco end = new Endereco();
            end.Logradouro = txtLogradouro.Text;
            end.Cep = mtbCep.Text;
            //Se o sem numero está marcado, então fica vazio o texto do Numero.
            end.Numero = chkSemNumero.Checked ? "S/N" : txtNumero.Text;

            end.Nome = txtNomeCompleto.Text;
            end.Bairro = txtBairro.Text;
            end.Cidade = txtCidade.Text;
            end.Uf = cbxUf.SelectedItem.ToString();
            end.Complemento = txtComplemento.Text;
            end.SemNumero = chkSemNumero.Checked;

            string mensagem = @$"
                Nome: {end.Nome}
                Cep: {end.Cep}
                Logradouro: {end.Logradouro}
                Numero: {end.Numero}
                Bairro: {end.Bairro}
                Cidade: {end.Cidade}
                Estado: {end.Uf}
                Complemento: {end.Complemento}               
             ";

            //Adicionando na Lista de Endereços
            Endereco.ListaEnderecos.Add(end);

            Sucesso(mensagem);

        }

        private void chkSemNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSemNumero.Checked == true)
            {
                txtNumero.Enabled = false;
            }
            else
            {
                txtNumero.Enabled = true;
            }
        }
    }
}