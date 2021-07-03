namespace Projeto_Ambientes_visuais
{
    partial class AlterarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCliente));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCelular = new System.Windows.Forms.DataGridView();
            this.Id_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.Id_Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoEnde = new System.Windows.Forms.Button();
            this.btnExcluirEnde = new System.Windows.Forms.Button();
            this.btnExcluirCel = new System.Windows.Forms.Button();
            this.btnNovoCel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAlterarEndereco = new System.Windows.Forms.Button();
            this.btnAlterarCelular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(250, 234);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 41);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Confirmar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(12, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 41);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alterar Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Cadastro";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(33, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Email";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(73, 106);
            this.txtRG.Mask = "00,000,000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(88, 20);
            this.txtRG.TabIndex = 12;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(74, 82);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(88, 20);
            this.txtCPF.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // dgvCelular
            // 
            this.dgvCelular.AllowUserToAddRows = false;
            this.dgvCelular.AllowUserToDeleteRows = false;
            this.dgvCelular.AllowUserToResizeColumns = false;
            this.dgvCelular.AllowUserToResizeRows = false;
            this.dgvCelular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCelular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCelular.BackgroundColor = System.Drawing.Color.White;
            this.dgvCelular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCelular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Numero,
            this.Celular,
            this.Id_cliente});
            this.dgvCelular.Location = new System.Drawing.Point(397, 212);
            this.dgvCelular.Name = "dgvCelular";
            this.dgvCelular.ReadOnly = true;
            this.dgvCelular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCelular.Size = new System.Drawing.Size(274, 72);
            this.dgvCelular.TabIndex = 13;
            // 
            // Id_Numero
            // 
            this.Id_Numero.DataPropertyName = "id";
            this.Id_Numero.HeaderText = "Id_Numero";
            this.Id_Numero.Name = "Id_Numero";
            this.Id_Numero.ReadOnly = true;
            this.Id_Numero.Width = 84;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "numero";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 64;
            // 
            // Id_cliente
            // 
            this.Id_cliente.DataPropertyName = "idcli";
            this.Id_cliente.HeaderText = "Id cliente";
            this.Id_cliente.Name = "Id_cliente";
            this.Id_cliente.ReadOnly = true;
            this.Id_cliente.Width = 75;
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.AllowUserToResizeColumns = false;
            this.dgvEndereco.AllowUserToResizeRows = false;
            this.dgvEndereco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEndereco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEndereco.BackgroundColor = System.Drawing.Color.White;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Endereco,
            this.Logradouro,
            this.Cep,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.Estado,
            this.Id_cli});
            this.dgvEndereco.Location = new System.Drawing.Point(397, 75);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEndereco.Size = new System.Drawing.Size(538, 72);
            this.dgvEndereco.TabIndex = 12;
            // 
            // Id_Endereco
            // 
            this.Id_Endereco.DataPropertyName = "id";
            this.Id_Endereco.HeaderText = "Id_Endereco";
            this.Id_Endereco.Name = "Id_Endereco";
            this.Id_Endereco.ReadOnly = true;
            this.Id_Endereco.Width = 93;
            // 
            // Logradouro
            // 
            this.Logradouro.DataPropertyName = "logradouro";
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.ReadOnly = true;
            this.Logradouro.Width = 86;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "cep";
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Width = 51;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 69;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 59;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 65;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // Id_cli
            // 
            this.Id_cli.DataPropertyName = "idcli";
            this.Id_cli.HeaderText = "Id cliente";
            this.Id_cli.Name = "Id_cli";
            this.Id_cli.ReadOnly = true;
            this.Id_cli.Width = 75;
            // 
            // btnNovoEnde
            // 
            this.btnNovoEnde.Location = new System.Drawing.Point(397, 152);
            this.btnNovoEnde.Name = "btnNovoEnde";
            this.btnNovoEnde.Size = new System.Drawing.Size(134, 23);
            this.btnNovoEnde.TabIndex = 14;
            this.btnNovoEnde.Text = "Novo Endereco";
            this.btnNovoEnde.UseVisualStyleBackColor = true;
            this.btnNovoEnde.Click += new System.EventHandler(this.btnNovoEnde_Click);
            // 
            // btnExcluirEnde
            // 
            this.btnExcluirEnde.Location = new System.Drawing.Point(677, 153);
            this.btnExcluirEnde.Name = "btnExcluirEnde";
            this.btnExcluirEnde.Size = new System.Drawing.Size(134, 23);
            this.btnExcluirEnde.TabIndex = 15;
            this.btnExcluirEnde.Text = "Excluir Endereço";
            this.btnExcluirEnde.UseVisualStyleBackColor = true;
            this.btnExcluirEnde.Click += new System.EventHandler(this.btnExcluirEnde_Click);
            // 
            // btnExcluirCel
            // 
            this.btnExcluirCel.Location = new System.Drawing.Point(677, 290);
            this.btnExcluirCel.Name = "btnExcluirCel";
            this.btnExcluirCel.Size = new System.Drawing.Size(134, 23);
            this.btnExcluirCel.TabIndex = 17;
            this.btnExcluirCel.Text = "Excluir Celular";
            this.btnExcluirCel.UseVisualStyleBackColor = true;
            this.btnExcluirCel.Click += new System.EventHandler(this.btnExcluirCel_Click);
            // 
            // btnNovoCel
            // 
            this.btnNovoCel.Location = new System.Drawing.Point(397, 290);
            this.btnNovoCel.Name = "btnNovoCel";
            this.btnNovoCel.Size = new System.Drawing.Size(134, 23);
            this.btnNovoCel.TabIndex = 16;
            this.btnNovoCel.Text = "Novo Celular";
            this.btnNovoCel.UseVisualStyleBackColor = true;
            this.btnNovoCel.Click += new System.EventHandler(this.btnNovoCel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(393, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Celulares";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(393, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Endereços";
            // 
            // btnAlterarEndereco
            // 
            this.btnAlterarEndereco.Location = new System.Drawing.Point(537, 152);
            this.btnAlterarEndereco.Name = "btnAlterarEndereco";
            this.btnAlterarEndereco.Size = new System.Drawing.Size(134, 23);
            this.btnAlterarEndereco.TabIndex = 20;
            this.btnAlterarEndereco.Text = "Alterar Endereço";
            this.btnAlterarEndereco.UseVisualStyleBackColor = true;
            this.btnAlterarEndereco.Click += new System.EventHandler(this.btnAlterarEndereco_Click);
            // 
            // btnAlterarCelular
            // 
            this.btnAlterarCelular.Location = new System.Drawing.Point(537, 290);
            this.btnAlterarCelular.Name = "btnAlterarCelular";
            this.btnAlterarCelular.Size = new System.Drawing.Size(134, 23);
            this.btnAlterarCelular.TabIndex = 21;
            this.btnAlterarCelular.Text = "Alterar Celular";
            this.btnAlterarCelular.UseVisualStyleBackColor = true;
            this.btnAlterarCelular.Click += new System.EventHandler(this.btnAlterarCelular_Click);
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(956, 335);
            this.Controls.Add(this.btnAlterarCelular);
            this.Controls.Add(this.btnAlterarEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExcluirCel);
            this.Controls.Add(this.btnNovoCel);
            this.Controls.Add(this.btnExcluirEnde);
            this.Controls.Add(this.btnNovoEnde);
            this.Controls.Add(this.dgvCelular);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarCliente";
            this.Activated += new System.EventHandler(this.AlterarCliente_Activated);
            this.Load += new System.EventHandler(this.AlterarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCelular;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.Button btnNovoEnde;
        private System.Windows.Forms.Button btnExcluirEnde;
        private System.Windows.Forms.Button btnExcluirCel;
        private System.Windows.Forms.Button btnNovoCel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cli;
        private System.Windows.Forms.Button btnAlterarEndereco;
        private System.Windows.Forms.Button btnAlterarCelular;
    }
}