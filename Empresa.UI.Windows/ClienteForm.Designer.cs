﻿
namespace Empresa.UI.Windows
{
    partial class ClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.confirmarInclusaoButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.confirmarAlterarButton = new System.Windows.Forms.Button();
            this.confirmarExcluirButton = new System.Windows.Forms.Button();
            this.conteudoPanel = new System.Windows.Forms.Panel();
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.fichaPanel = new System.Windows.Forms.Panel();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.conteudoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.fichaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 61);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.novoButton);
            this.flowLayoutPanel1.Controls.Add(this.alterarButton);
            this.flowLayoutPanel1.Controls.Add(this.excluirButton);
            this.flowLayoutPanel1.Controls.Add(this.sairButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarInclusaoButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarAlterarButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarExcluirButton);
            this.flowLayoutPanel1.Controls.Add(this.voltarButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(705, 61);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(13, 18);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 0;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(94, 18);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 1;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(175, 18);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // confirmarInclusaoButton
            // 
            this.confirmarInclusaoButton.Location = new System.Drawing.Point(337, 18);
            this.confirmarInclusaoButton.Name = "confirmarInclusaoButton";
            this.confirmarInclusaoButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarInclusaoButton.TabIndex = 3;
            this.confirmarInclusaoButton.Text = "Gravar";
            this.confirmarInclusaoButton.UseVisualStyleBackColor = true;
            this.confirmarInclusaoButton.Click += new System.EventHandler(this.confirmarInclusaoButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(256, 18);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 4;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // confirmarAlterarButton
            // 
            this.confirmarAlterarButton.Location = new System.Drawing.Point(418, 18);
            this.confirmarAlterarButton.Name = "confirmarAlterarButton";
            this.confirmarAlterarButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarAlterarButton.TabIndex = 5;
            this.confirmarAlterarButton.Text = "Alterar";
            this.confirmarAlterarButton.UseVisualStyleBackColor = true;
            this.confirmarAlterarButton.Click += new System.EventHandler(this.confirmarAlterarButton_Click);
            // 
            // confirmarExcluirButton
            // 
            this.confirmarExcluirButton.Location = new System.Drawing.Point(499, 18);
            this.confirmarExcluirButton.Name = "confirmarExcluirButton";
            this.confirmarExcluirButton.Size = new System.Drawing.Size(115, 23);
            this.confirmarExcluirButton.TabIndex = 6;
            this.confirmarExcluirButton.Text = "Confirmar Exclusão";
            this.confirmarExcluirButton.UseVisualStyleBackColor = true;
            this.confirmarExcluirButton.Click += new System.EventHandler(this.confirmarExcluirButton_Click);
            // 
            // conteudoPanel
            // 
            this.conteudoPanel.Controls.Add(this.fichaPanel);
            this.conteudoPanel.Controls.Add(this.listaDataGridView);
            this.conteudoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteudoPanel.Location = new System.Drawing.Point(0, 0);
            this.conteudoPanel.Name = "conteudoPanel";
            this.conteudoPanel.Padding = new System.Windows.Forms.Padding(10);
            this.conteudoPanel.Size = new System.Drawing.Size(705, 349);
            this.conteudoPanel.TabIndex = 1;
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Location = new System.Drawing.Point(418, 64);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.Size = new System.Drawing.Size(274, 245);
            this.listaDataGridView.TabIndex = 0;
            // 
            // fichaPanel
            // 
            this.fichaPanel.Controls.Add(this.telefoneTextBox);
            this.fichaPanel.Controls.Add(this.label4);
            this.fichaPanel.Controls.Add(this.emailTextBox);
            this.fichaPanel.Controls.Add(this.label3);
            this.fichaPanel.Controls.Add(this.nomeTextBox);
            this.fichaPanel.Controls.Add(this.label2);
            this.fichaPanel.Controls.Add(this.idTextBox);
            this.fichaPanel.Controls.Add(this.label1);
            this.fichaPanel.Location = new System.Drawing.Point(24, 64);
            this.fichaPanel.Name = "fichaPanel";
            this.fichaPanel.Size = new System.Drawing.Size(388, 245);
            this.fichaPanel.TabIndex = 1;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(73, 168);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(304, 20);
            this.telefoneTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefone:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(73, 132);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(304, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(73, 92);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(304, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(73, 56);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(41, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id:";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(620, 18);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 7;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 410);
            this.Controls.Add(this.conteudoPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ClienteForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.conteudoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.fichaPanel.ResumeLayout(false);
            this.fichaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button confirmarInclusaoButton;
        private System.Windows.Forms.Button confirmarAlterarButton;
        private System.Windows.Forms.Button confirmarExcluirButton;
        private System.Windows.Forms.Panel conteudoPanel;
        private System.Windows.Forms.Panel fichaPanel;
        private System.Windows.Forms.DataGridView listaDataGridView;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voltarButton;
    }
}