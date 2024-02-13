using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidade;
using Sistema.Model;

namespace Sistema.View
{
    public partial class FrmCadUsuario : Form
    {
        UsuarioEnt ObjTabela = new UsuarioEnt(); 
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            iniciarOpc();
        }
        private string opc = "";
        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;

                case "Salvar":
                    try
                    {
                        ObjTabela.Nome = txtNome.Text;
                        ObjTabela.Senha = txtUsuario.Text;
                        ObjTabela.Usuario = txtSenha.Text;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar !... ");
                        throw;
                        int X = UsuarioModel.Inserir(ObjTabela);
                    }
                    break;

                case "Excluir":
                    break;
                
                case "Editar":
                    break; 
            }
        }
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            iniciarOpc();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            iniciarOpc();
        }
    }
}
