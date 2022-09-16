using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.Db;
using Empresa.Models;

namespace Empresa.UI.Windows
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;
            novoButton.Visible = true;
            alterarButton.Visible = true;
            excluirButton.Visible = true;
            sairButton.Visible = true;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarInclusaoButton.Visible = false;
            voltarButton.Visible = false;

            var db = new ClienteDb();
            listaDataGridView.DataSource = db.Listar();
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //selecionando a linha inteira
            listaDataGridView.ReadOnly = true;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //as colunas irão completar o grid automaticamente
            listaDataGridView.RowHeadersVisible = false; // oculta a primeira coluna que aparece no grid com uma seta
            listaDataGridView.EnableHeadersVisualStyles = true;
            listaDataGridView.Columns["Id"].Width = 50;

        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();
        }

        private void ExibirFicha()
        {
            fichaPanel.Visible = true;
            fichaPanel.Dock = DockStyle.Fill;
            listaDataGridView.Visible = false;

            novoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarInclusaoButton.Visible = true;
            voltarButton.Visible = true;
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void confirmarInclusaoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            ClienteDb clienteDb = new ClienteDb();
            clienteDb.Incluir(cliente);

            MessageBox.Show("Cliente inserido com sucesso!");
            ExibirGrid();
            LimparCampos();
            
        }

        private void LimparCampos()
        {
            idTextBox.Text = "";
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            telefoneTextBox.Text = "";
        }
    }
}
