namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmFornecedores
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
            panel1 = new Panel();
            label1 = new Label();
            tabfornecedores = new TabControl();
            tabPage1 = new TabPage();
            btnbuscar = new Button();
            cmbestado = new ComboBox();
            label2 = new Label();
            txtcodigo = new TextBox();
            label14 = new Label();
            txtnome = new TextBox();
            txtcidade = new TextBox();
            label3 = new Label();
            label13 = new Label();
            label4 = new Label();
            txtbairro = new TextBox();
            txtcnpj = new MaskedTextBox();
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
            tabelafornecedores = new DataGridView();
            btnpesquisar = new Button();
            label15 = new Label();
            txtpesquisa = new TextBox();
            panel2 = new Panel();
            btneditar = new Button();
            btnnovo = new Button();
            btnsalvar = new Button();
            btnexcluir = new Button();
            panel1.SuspendLayout();
            tabfornecedores.SuspendLayout();
            tabPage1.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelafornecedores).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login_certo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 92);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 32);
            label1.Name = "label1";
            label1.Size = new Size(323, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Fornecedores";
            // 
            // tabfornecedores
            // 
            tabfornecedores.Appearance = TabAppearance.Buttons;
            tabfornecedores.Controls.Add(tabPage1);
            tabfornecedores.Controls.Add(tabConsulta);
            tabfornecedores.Cursor = Cursors.Hand;
            tabfornecedores.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabfornecedores.Location = new Point(12, 112);
            tabfornecedores.Name = "tabfornecedores";
            tabfornecedores.SelectedIndex = 0;
            tabfornecedores.Size = new Size(886, 269);
            tabfornecedores.TabIndex = 28;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnbuscar);
            tabPage1.Controls.Add(cmbestado);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtcodigo);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(txtnome);
            tabPage1.Controls.Add(txtcidade);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtbairro);
            tabPage1.Controls.Add(txtcnpj);
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
            tabPage1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(878, 235);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Navy;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(227, 116);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(113, 26);
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
            cmbestado.Location = new Point(766, 175);
            cmbestado.Name = "cmbestado";
            cmbestado.Size = new Size(96, 26);
            cmbestado.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(9, 26);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // txtcodigo
            // 
            txtcodigo.Enabled = false;
            txtcodigo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcodigo.Location = new Point(76, 20);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(101, 26);
            txtcodigo.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(701, 183);
            label14.Name = "label14";
            label14.Size = new Size(62, 18);
            label14.TabIndex = 25;
            label14.Text = "Estado:";
            // 
            // txtnome
            // 
            txtnome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnome.Location = new Point(76, 52);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(375, 26);
            txtnome.TabIndex = 4;
            // 
            // txtcidade
            // 
            txtcidade.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcidade.Location = new Point(591, 177);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(101, 26);
            txtcidade.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(19, 55);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 3;
            label3.Text = "Nome:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(524, 183);
            label13.Name = "label13";
            label13.Size = new Size(64, 18);
            label13.TabIndex = 23;
            label13.Text = "Cidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(470, 55);
            label4.Name = "label4";
            label4.Size = new Size(54, 18);
            label4.TabIndex = 5;
            label4.Text = "CNPJ:";
            // 
            // txtbairro
            // 
            txtbairro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbairro.Location = new Point(390, 177);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(125, 26);
            txtbairro.TabIndex = 22;
            // 
            // txtcnpj
            // 
            txtcnpj.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcnpj.Location = new Point(530, 52);
            txtcnpj.Mask = "##.###.###/####-##";
            txtcnpj.Name = "txtcnpj";
            txtcnpj.Size = new Size(152, 26);
            txtcnpj.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(337, 183);
            label12.Name = "label12";
            label12.Size = new Size(55, 18);
            label12.TabIndex = 21;
            label12.Text = "Bairro:";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(483, 84);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(379, 26);
            txtemail.TabIndex = 12;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcomplemento.Location = new Point(120, 177);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(208, 26);
            txtcomplemento.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(208, 90);
            label5.Name = "label5";
            label5.Size = new Size(61, 18);
            label5.TabIndex = 7;
            label5.Text = "Celular:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(18, 183);
            label11.Name = "label11";
            label11.Size = new Size(110, 18);
            label11.TabIndex = 19;
            label11.Text = "Complemento:";
            // 
            // txtcelular
            // 
            txtcelular.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcelular.Location = new Point(273, 84);
            txtcelular.Mask = "(##) #####-####";
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(131, 26);
            txtcelular.TabIndex = 8;
            // 
            // txtnumero
            // 
            txtnumero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnumero.Location = new Point(574, 145);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(118, 26);
            txtnumero.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(3, 90);
            label6.Name = "label6";
            label6.Size = new Size(70, 18);
            label6.TabIndex = 9;
            label6.Text = "Telefone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(504, 150);
            label10.Name = "label10";
            label10.Size = new Size(67, 18);
            label10.TabIndex = 17;
            label10.Text = "Número:";
            // 
            // txttelefone
            // 
            txttelefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefone.Location = new Point(76, 84);
            txttelefone.Mask = "(##) ####-####";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(123, 26);
            txttelefone.TabIndex = 10;
            // 
            // txtendereco
            // 
            txtendereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtendereco.Location = new Point(120, 145);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(375, 26);
            txtendereco.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(37, 150);
            label9.Name = "label9";
            label9.Size = new Size(80, 18);
            label9.TabIndex = 15;
            label9.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(423, 90);
            label7.Name = "label7";
            label7.Size = new Size(57, 18);
            label7.TabIndex = 11;
            label7.Text = "E-mail:";
            // 
            // txtcep
            // 
            txtcep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcep.Location = new Point(120, 116);
            txtcep.Mask = "#####-###";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(101, 26);
            txtcep.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(71, 124);
            label8.Name = "label8";
            label8.Size = new Size(46, 18);
            label8.TabIndex = 13;
            label8.Text = "CEP:";
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(tabelafornecedores);
            tabConsulta.Controls.Add(btnpesquisar);
            tabConsulta.Controls.Add(label15);
            tabConsulta.Controls.Add(txtpesquisa);
            tabConsulta.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabConsulta.Location = new Point(4, 30);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3, 3, 3, 3);
            tabConsulta.Size = new Size(878, 235);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // tabelafornecedores
            // 
            tabelafornecedores.AllowUserToAddRows = false;
            tabelafornecedores.AllowUserToDeleteRows = false;
            tabelafornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelafornecedores.Location = new Point(9, 54);
            tabelafornecedores.Name = "tabelafornecedores";
            tabelafornecedores.ReadOnly = true;
            tabelafornecedores.RowHeadersWidth = 51;
            tabelafornecedores.RowTemplate.Height = 25;
            tabelafornecedores.Size = new Size(863, 181);
            tabelafornecedores.TabIndex = 33;
            tabelafornecedores.CellClick += tabelafornecedores_CellClick;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.Navy;
            btnpesquisar.BackgroundImageLayout = ImageLayout.Stretch;
            btnpesquisar.FlatStyle = FlatStyle.Flat;
            btnpesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnpesquisar.ForeColor = Color.White;
            btnpesquisar.Location = new Point(580, 18);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(95, 30);
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
            label15.Location = new Point(36, 27);
            label15.Name = "label15";
            label15.Size = new Size(54, 18);
            label15.TabIndex = 3;
            label15.Text = "Nome:";
            // 
            // txtpesquisa
            // 
            txtpesquisa.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpesquisa.Location = new Point(96, 21);
            txtpesquisa.Name = "txtpesquisa";
            txtpesquisa.Size = new Size(478, 26);
            txtpesquisa.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(btneditar);
            panel2.Controls.Add(btnnovo);
            panel2.Controls.Add(btnsalvar);
            panel2.Controls.Add(btnexcluir);
            panel2.Location = new Point(-3, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 40);
            panel2.TabIndex = 33;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Navy;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btneditar.ForeColor = Color.White;
            btneditar.Location = new Point(558, 5);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(95, 30);
            btneditar.TabIndex = 31;
            btneditar.Text = "EDITAR";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click_1;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.Navy;
            btnnovo.FlatAppearance.BorderColor = Color.White;
            btnnovo.FlatStyle = FlatStyle.Flat;
            btnnovo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnnovo.ForeColor = Color.White;
            btnnovo.Location = new Point(255, 5);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(95, 30);
            btnnovo.TabIndex = 28;
            btnnovo.Text = "NOVO";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += btnnovo_Click_1;
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = Color.Navy;
            btnsalvar.FlatStyle = FlatStyle.Flat;
            btnsalvar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsalvar.ForeColor = Color.White;
            btnsalvar.Location = new Point(356, 5);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(95, 30);
            btnsalvar.TabIndex = 29;
            btnsalvar.Text = "SALVAR";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += btnsalvar_Click_1;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.Navy;
            btnexcluir.FlatStyle = FlatStyle.Flat;
            btnexcluir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnexcluir.ForeColor = Color.White;
            btnexcluir.Location = new Point(457, 5);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(95, 30);
            btnexcluir.TabIndex = 30;
            btnexcluir.Text = "EXCLUIR";
            btnexcluir.UseVisualStyleBackColor = false;
            btnexcluir.Click += btnexcluir_Click_1;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(panel2);
            Controls.Add(tabfornecedores);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmFornecedores";
            Text = "Cadastro Fornecedores";
            Load += FrmFornecedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabfornecedores.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabConsulta.ResumeLayout(false);
            tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelafornecedores).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
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
        private Label label4;
        private TextBox txtbairro;
        private MaskedTextBox txtcnpj;
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
        private DataGridView tabelafornecedores;
        private Button btnpesquisar;
        private Label label15;
        private TextBox txtpesquisa;
        public TabControl tabfornecedores;
        public TabPage tabConsulta;
        private Panel panel2;
        private Button btneditar;
        private Button btnnovo;
        private Button btnsalvar;
        public Button btnexcluir;
    }
}