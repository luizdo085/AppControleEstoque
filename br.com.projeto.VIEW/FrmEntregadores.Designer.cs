namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmEntregadores
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
            tabentregadores = new TabControl();
            tabPage1 = new TabPage();
            lblrg = new Label();
            txtrg = new MaskedTextBox();
            btnbuscar = new Button();
            cmbestado = new ComboBox();
            label2 = new Label();
            txtcodigo = new TextBox();
            label14 = new Label();
            txtnome = new TextBox();
            txtcidade = new TextBox();
            label3 = new Label();
            label13 = new Label();
            lblcpf = new Label();
            txtbairro = new TextBox();
            txtcpf = new MaskedTextBox();
            label12 = new Label();
            txtemail = new TextBox();
            txtcomplemento = new TextBox();
            label5 = new Label();
            label11 = new Label();
            txtcelular = new MaskedTextBox();
            txtnumero = new TextBox();
            label6 = new Label();
            label10 = new Label();
            txttelefone = new MaskedTextBox();
            txtendereco = new TextBox();
            label9 = new Label();
            label7 = new Label();
            txtcep = new MaskedTextBox();
            label8 = new Label();
            tabConsulta = new TabPage();
            tabelaEntregadores = new DataGridView();
            btnpesquisar = new Button();
            label15 = new Label();
            txtpesquisa = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btneditar = new Button();
            btnnovo = new Button();
            btnsalvar = new Button();
            btnexcluir = new Button();
            tabentregadores.SuspendLayout();
            tabPage1.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaEntregadores).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabentregadores
            // 
            tabentregadores.Appearance = TabAppearance.Buttons;
            tabentregadores.Controls.Add(tabPage1);
            tabentregadores.Controls.Add(tabConsulta);
            tabentregadores.Cursor = Cursors.Hand;
            tabentregadores.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabentregadores.Location = new Point(13, 153);
            tabentregadores.Margin = new Padding(3, 4, 3, 4);
            tabentregadores.Name = "tabentregadores";
            tabentregadores.SelectedIndex = 0;
            tabentregadores.Size = new Size(1013, 359);
            tabentregadores.TabIndex = 28;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblrg);
            tabPage1.Controls.Add(txtrg);
            tabPage1.Controls.Add(btnbuscar);
            tabPage1.Controls.Add(cmbestado);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtcodigo);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(txtnome);
            tabPage1.Controls.Add(txtcidade);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(lblcpf);
            tabPage1.Controls.Add(txtbairro);
            tabPage1.Controls.Add(txtcpf);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(txtemail);
            tabPage1.Controls.Add(txtcomplemento);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(txtcelular);
            tabPage1.Controls.Add(txtnumero);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txttelefone);
            tabPage1.Controls.Add(txtendereco);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtcep);
            tabPage1.Controls.Add(label8);
            tabPage1.ImeMode = ImeMode.Disable;
            tabPage1.Location = new Point(4, 35);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1005, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblrg
            // 
            lblrg.AutoSize = true;
            lblrg.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblrg.ForeColor = Color.Navy;
            lblrg.Location = new Point(818, 73);
            lblrg.Name = "lblrg";
            lblrg.Size = new Size(46, 23);
            lblrg.TabIndex = 33;
            lblrg.Text = "RG:";
            // 
            // txtrg
            // 
            txtrg.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtrg.Location = new Point(865, 69);
            txtrg.Margin = new Padding(3, 4, 3, 4);
            txtrg.Mask = "99.999.999-0";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(119, 30);
            txtrg.TabIndex = 34;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Navy;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(259, 155);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(129, 35);
            btnbuscar.TabIndex = 32;
            btnbuscar.Text = "PESQUISAR";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // cmbestado
            // 
            cmbestado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbestado.FormattingEnabled = true;
            cmbestado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbestado.Location = new Point(875, 236);
            cmbestado.Margin = new Padding(3, 4, 3, 4);
            cmbestado.Name = "cmbestado";
            cmbestado.Size = new Size(109, 31);
            cmbestado.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(10, 31);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // txtcodigo
            // 
            txtcodigo.Enabled = false;
            txtcodigo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcodigo.Location = new Point(87, 27);
            txtcodigo.Margin = new Padding(3, 4, 3, 4);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(115, 30);
            txtcodigo.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(798, 240);
            label14.Name = "label14";
            label14.Size = new Size(78, 23);
            label14.TabIndex = 25;
            label14.Text = "Estado:";
            // 
            // txtnome
            // 
            txtnome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnome.Location = new Point(87, 69);
            txtnome.Margin = new Padding(3, 4, 3, 4);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(501, 30);
            txtnome.TabIndex = 4;
            // 
            // txtcidade
            // 
            txtcidade.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcidade.Location = new Point(675, 236);
            txtcidade.Margin = new Padding(3, 4, 3, 4);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(115, 30);
            txtcidade.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(22, 73);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 3;
            label3.Text = "Nome:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(599, 241);
            label13.Name = "label13";
            label13.Size = new Size(78, 23);
            label13.TabIndex = 23;
            label13.Text = "Cidade:";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblcpf.ForeColor = Color.Navy;
            lblcpf.Location = new Point(603, 73);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(55, 23);
            lblcpf.TabIndex = 5;
            lblcpf.Text = "CPF:";
            // 
            // txtbairro
            // 
            txtbairro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbairro.Location = new Point(446, 236);
            txtbairro.Margin = new Padding(3, 4, 3, 4);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(142, 30);
            txtbairro.TabIndex = 22;
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcpf.Location = new Point(657, 69);
            txtcpf.Margin = new Padding(3, 4, 3, 4);
            txtcpf.Mask = "###.###.###-##";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(141, 30);
            txtcpf.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(382, 240);
            label12.Name = "label12";
            label12.Size = new Size(69, 23);
            label12.TabIndex = 21;
            label12.Text = "Bairro:";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(552, 112);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(433, 30);
            txtemail.TabIndex = 12;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcomplemento.Location = new Point(137, 236);
            txtcomplemento.Margin = new Padding(3, 4, 3, 4);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(237, 30);
            txtcomplemento.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(235, 116);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 7;
            label5.Text = "Celular:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(10, 240);
            label11.Name = "label11";
            label11.Size = new Size(137, 23);
            label11.TabIndex = 19;
            label11.Text = "Complemento:";
            // 
            // txtcelular
            // 
            txtcelular.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcelular.Location = new Point(312, 112);
            txtcelular.Margin = new Padding(3, 4, 3, 4);
            txtcelular.Mask = "(##) #####-####";
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(149, 30);
            txtcelular.TabIndex = 8;
            // 
            // txtnumero
            // 
            txtnumero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnumero.Location = new Point(656, 193);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(134, 30);
            txtnumero.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(3, 116);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 9;
            label6.Text = "Telefone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(576, 200);
            label10.Name = "label10";
            label10.Size = new Size(85, 23);
            label10.TabIndex = 17;
            label10.Text = "Número:";
            // 
            // txttelefone
            // 
            txttelefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefone.Location = new Point(87, 112);
            txttelefone.Margin = new Padding(3, 4, 3, 4);
            txttelefone.Mask = "(##) ####-####";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(140, 30);
            txttelefone.TabIndex = 10;
            // 
            // txtendereco
            // 
            txtendereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtendereco.Location = new Point(137, 193);
            txtendereco.Margin = new Padding(3, 4, 3, 4);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(428, 30);
            txtendereco.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(42, 197);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 15;
            label9.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(480, 116);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 11;
            label7.Text = "E-mail:";
            // 
            // txtcep
            // 
            txtcep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcep.Location = new Point(137, 155);
            txtcep.Margin = new Padding(3, 4, 3, 4);
            txtcep.Mask = "#####-###";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(115, 30);
            txtcep.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(81, 160);
            label8.Name = "label8";
            label8.Size = new Size(56, 23);
            label8.TabIndex = 13;
            label8.Text = "CEP:";
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(tabelaEntregadores);
            tabConsulta.Controls.Add(btnpesquisar);
            tabConsulta.Controls.Add(label15);
            tabConsulta.Controls.Add(txtpesquisa);
            tabConsulta.Location = new Point(4, 35);
            tabConsulta.Margin = new Padding(3, 4, 3, 4);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3, 4, 3, 4);
            tabConsulta.Size = new Size(1005, 320);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // tabelaEntregadores
            // 
            tabelaEntregadores.AllowUserToAddRows = false;
            tabelaEntregadores.AllowUserToDeleteRows = false;
            tabelaEntregadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaEntregadores.Location = new Point(10, 72);
            tabelaEntregadores.Margin = new Padding(3, 4, 3, 4);
            tabelaEntregadores.Name = "tabelaEntregadores";
            tabelaEntregadores.ReadOnly = true;
            tabelaEntregadores.RowHeadersWidth = 51;
            tabelaEntregadores.RowTemplate.Height = 25;
            tabelaEntregadores.Size = new Size(986, 241);
            tabelaEntregadores.TabIndex = 33;
            tabelaEntregadores.CellClick += tabelaEntregadores_CellClick;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.Navy;
            btnpesquisar.BackgroundImageLayout = ImageLayout.Stretch;
            btnpesquisar.FlatAppearance.BorderSize = 0;
            btnpesquisar.FlatStyle = FlatStyle.Flat;
            btnpesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnpesquisar.ForeColor = Color.White;
            btnpesquisar.Location = new Point(663, 24);
            btnpesquisar.Margin = new Padding(3, 4, 3, 4);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(109, 40);
            btnpesquisar.TabIndex = 32;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = false;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Navy;
            label15.Location = new Point(41, 32);
            label15.Name = "label15";
            label15.Size = new Size(67, 23);
            label15.TabIndex = 3;
            label15.Text = "Nome:";
            // 
            // txtpesquisa
            // 
            txtpesquisa.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpesquisa.Location = new Point(110, 28);
            txtpesquisa.Margin = new Padding(3, 4, 3, 4);
            txtpesquisa.Name = "txtpesquisa";
            txtpesquisa.Size = new Size(546, 30);
            txtpesquisa.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login_certo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 123);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(326, 39);
            label1.Name = "label1";
            label1.Size = new Size(396, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Entregadores";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(btneditar);
            panel2.Controls.Add(btnnovo);
            panel2.Controls.Add(btnsalvar);
            panel2.Controls.Add(btnexcluir);
            panel2.Location = new Point(-11, 536);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1061, 53);
            panel2.TabIndex = 33;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Navy;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btneditar.ForeColor = Color.White;
            btneditar.Location = new Point(638, 7);
            btneditar.Margin = new Padding(3, 4, 3, 4);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(109, 40);
            btneditar.TabIndex = 31;
            btneditar.Text = "EDITAR";
            btneditar.UseVisualStyleBackColor = false;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.Navy;
            btnnovo.FlatAppearance.BorderColor = Color.White;
            btnnovo.FlatStyle = FlatStyle.Flat;
            btnnovo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnnovo.ForeColor = Color.White;
            btnnovo.Location = new Point(291, 7);
            btnnovo.Margin = new Padding(3, 4, 3, 4);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(109, 40);
            btnnovo.TabIndex = 28;
            btnnovo.Text = "NOVO";
            btnnovo.UseVisualStyleBackColor = false;
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = Color.Navy;
            btnsalvar.FlatStyle = FlatStyle.Flat;
            btnsalvar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsalvar.ForeColor = Color.White;
            btnsalvar.Location = new Point(407, 7);
            btnsalvar.Margin = new Padding(3, 4, 3, 4);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(109, 40);
            btnsalvar.TabIndex = 29;
            btnsalvar.Text = "SALVAR";
            btnsalvar.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.Navy;
            btnexcluir.FlatStyle = FlatStyle.Flat;
            btnexcluir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnexcluir.ForeColor = Color.White;
            btnexcluir.Location = new Point(522, 7);
            btnexcluir.Margin = new Padding(3, 4, 3, 4);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(109, 40);
            btnexcluir.TabIndex = 30;
            btnexcluir.Text = "EXCLUIR";
            btnexcluir.UseVisualStyleBackColor = false;
            // 
            // FrmEntregadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabentregadores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmEntregadores";
            Text = "FrmEntregadores";
            Load += FrmEntregadores_Load;
            tabentregadores.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabConsulta.ResumeLayout(false);
            tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaEntregadores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public TabControl tabentregadores;
        private TabPage tabPage1;
        private Button btnbuscar;
        private ComboBox cmbestado;
        private Label label2;
        private TextBox txtcodigo;
        private Label label14;
        private TextBox txtnome;
        private TextBox txtcidade;
        private Label label3;
        private Label label13;
        private TextBox txtbairro;
        private Label label12;
        private TextBox txtemail;
        private TextBox txtcomplemento;
        private Label label5;
        private Label label11;
        private MaskedTextBox txtcelular;
        private TextBox txtnumero;
        private Label label6;
        private Label label10;
        private MaskedTextBox txttelefone;
        private TextBox txtendereco;
        private Label label9;
        private Label label7;
        private MaskedTextBox txtcep;
        private Label label8;
        public TabPage tabConsulta;
        private DataGridView tabelaEntregadores;
        private Button btnpesquisar;
        private Label label15;
        private TextBox txtpesquisa;
        private Panel panel1;
        private Label label1;
        public MaskedTextBox txtcpf;
        public MaskedTextBox txtrg;
        public Label lblcpf;
        public Label lblrg;
        private Panel panel2;
        private Button btneditar;
        private Button btnnovo;
        private Button btnsalvar;
        public Button btnexcluir;
    }
}