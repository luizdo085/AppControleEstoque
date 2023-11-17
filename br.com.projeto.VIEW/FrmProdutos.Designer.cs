namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmProdutos
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
            btneditar = new Button();
            btnexcluir = new Button();
            btnsalvar = new Button();
            btnnovo = new Button();
            tabCadastrar = new TabPage();
            lblFornecedores = new Label();
            cmbfornecedores = new ComboBox();
            txtpreco = new TextBox();
            txtcodigo = new TextBox();
            txtdescricao = new TextBox();
            txtqtd = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabPage2 = new TabPage();
            tabelaprodutos = new DataGridView();
            btnpesquisar = new Button();
            label15 = new Label();
            txtpesquisa = new TextBox();
            tabprodutos = new TabControl();
            panel1.SuspendLayout();
            tabCadastrar.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaprodutos).BeginInit();
            tabprodutos.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1061, 123);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(387, 37);
            label1.Name = "label1";
            label1.Size = new Size(359, 40);
            label1.TabIndex = 0;
            label1.Text = "Estoque de Produtos";
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Navy;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btneditar.ForeColor = Color.White;
            btneditar.Location = new Point(425, 532);
            btneditar.Margin = new Padding(3, 4, 3, 4);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(109, 40);
            btneditar.TabIndex = 35;
            btneditar.Text = "EDITAR";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.Navy;
            btnexcluir.FlatStyle = FlatStyle.Flat;
            btnexcluir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnexcluir.ForeColor = Color.White;
            btnexcluir.Location = new Point(656, 532);
            btnexcluir.Margin = new Padding(3, 4, 3, 4);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(109, 40);
            btnexcluir.TabIndex = 34;
            btnexcluir.Text = "EXCLUIR";
            btnexcluir.UseVisualStyleBackColor = false;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = Color.Navy;
            btnsalvar.FlatStyle = FlatStyle.Flat;
            btnsalvar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsalvar.ForeColor = Color.White;
            btnsalvar.Location = new Point(541, 532);
            btnsalvar.Margin = new Padding(3, 4, 3, 4);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(109, 40);
            btnsalvar.TabIndex = 33;
            btnsalvar.Text = "SALVAR";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.Navy;
            btnnovo.FlatStyle = FlatStyle.Flat;
            btnnovo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnnovo.ForeColor = Color.White;
            btnnovo.Location = new Point(310, 532);
            btnnovo.Margin = new Padding(3, 4, 3, 4);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(109, 40);
            btnnovo.TabIndex = 32;
            btnnovo.Text = "NOVO";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += btnnovo_Click;
            // 
            // tabCadastrar
            // 
            tabCadastrar.Controls.Add(lblFornecedores);
            tabCadastrar.Controls.Add(cmbfornecedores);
            tabCadastrar.Controls.Add(txtpreco);
            tabCadastrar.Controls.Add(txtcodigo);
            tabCadastrar.Controls.Add(txtdescricao);
            tabCadastrar.Controls.Add(txtqtd);
            tabCadastrar.Controls.Add(label8);
            tabCadastrar.Controls.Add(label9);
            tabCadastrar.Controls.Add(label10);
            tabCadastrar.Controls.Add(label11);
            tabCadastrar.Location = new Point(4, 35);
            tabCadastrar.Margin = new Padding(3, 4, 3, 4);
            tabCadastrar.Name = "tabCadastrar";
            tabCadastrar.Padding = new Padding(3, 4, 3, 4);
            tabCadastrar.Size = new Size(1005, 320);
            tabCadastrar.TabIndex = 2;
            tabCadastrar.Text = "Cadastro de Produtos";
            tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblFornecedores
            // 
            lblFornecedores.AutoSize = true;
            lblFornecedores.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFornecedores.ForeColor = Color.Navy;
            lblFornecedores.Location = new Point(29, 195);
            lblFornecedores.Name = "lblFornecedores";
            lblFornecedores.Size = new Size(138, 23);
            lblFornecedores.TabIndex = 16;
            lblFornecedores.Text = "Fornecedores:";
            // 
            // cmbfornecedores
            // 
            cmbfornecedores.FormattingEnabled = true;
            cmbfornecedores.Location = new Point(158, 191);
            cmbfornecedores.Margin = new Padding(3, 4, 3, 4);
            cmbfornecedores.Name = "cmbfornecedores";
            cmbfornecedores.Size = new Size(317, 31);
            cmbfornecedores.TabIndex = 15;
            // 
            // txtpreco
            // 
            txtpreco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpreco.Location = new Point(696, 77);
            txtpreco.Margin = new Padding(3, 4, 3, 4);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(124, 30);
            txtpreco.TabIndex = 14;
            // 
            // txtcodigo
            // 
            txtcodigo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcodigo.Location = new Point(158, 24);
            txtcodigo.Margin = new Padding(3, 4, 3, 4);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.ReadOnly = true;
            txtcodigo.Size = new Size(97, 30);
            txtcodigo.TabIndex = 2;
            // 
            // txtdescricao
            // 
            txtdescricao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdescricao.Location = new Point(158, 77);
            txtdescricao.Margin = new Padding(3, 4, 3, 4);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(428, 30);
            txtdescricao.TabIndex = 4;
            // 
            // txtqtd
            // 
            txtqtd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtqtd.Location = new Point(158, 136);
            txtqtd.Margin = new Padding(3, 4, 3, 4);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(115, 30);
            txtqtd.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(593, 81);
            label8.Name = "label8";
            label8.Size = new Size(107, 23);
            label8.TabIndex = 13;
            label8.Text = "Preço(R$):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(81, 28);
            label9.Name = "label9";
            label9.Size = new Size(78, 23);
            label9.TabIndex = 1;
            label9.Text = "Código:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(58, 81);
            label10.Name = "label10";
            label10.Size = new Size(104, 23);
            label10.TabIndex = 3;
            label10.Text = "Descrição:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(41, 140);
            label11.Name = "label11";
            label11.Size = new Size(127, 23);
            label11.TabIndex = 11;
            label11.Text = "Qtd Estoque:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabelaprodutos);
            tabPage2.Controls.Add(btnpesquisar);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(txtpesquisa);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1005, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Estoque";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaprodutos
            // 
            tabelaprodutos.AllowUserToAddRows = false;
            tabelaprodutos.AllowUserToDeleteRows = false;
            tabelaprodutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaprodutos.Location = new Point(10, 72);
            tabelaprodutos.Margin = new Padding(3, 4, 3, 4);
            tabelaprodutos.Name = "tabelaprodutos";
            tabelaprodutos.ReadOnly = true;
            tabelaprodutos.RowHeadersWidth = 51;
            tabelaprodutos.RowTemplate.Height = 25;
            tabelaprodutos.Size = new Size(986, 241);
            tabelaprodutos.TabIndex = 33;
            tabelaprodutos.CellClick += tabelaprodutos_CellClick;
            tabelaprodutos.CellContentClick += tabelaprodutos_CellContentClick;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.Navy;
            btnpesquisar.BackgroundImageLayout = ImageLayout.Stretch;
            btnpesquisar.FlatStyle = FlatStyle.Flat;
            btnpesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnpesquisar.ForeColor = Color.White;
            btnpesquisar.Location = new Point(673, 21);
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
            label15.Location = new Point(41, 36);
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
            txtpesquisa.TextChanged += txtpesquisa_TextChanged;
            // 
            // tabprodutos
            // 
            tabprodutos.Appearance = TabAppearance.Buttons;
            tabprodutos.Controls.Add(tabPage2);
            tabprodutos.Controls.Add(tabCadastrar);
            tabprodutos.Cursor = Cursors.Hand;
            tabprodutos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabprodutos.Location = new Point(14, 148);
            tabprodutos.Margin = new Padding(3, 4, 3, 4);
            tabprodutos.Name = "tabprodutos";
            tabprodutos.SelectedIndex = 0;
            tabprodutos.Size = new Size(1013, 359);
            tabprodutos.TabIndex = 28;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 600);
            Controls.Add(btneditar);
            Controls.Add(btnexcluir);
            Controls.Add(btnsalvar);
            Controls.Add(btnnovo);
            Controls.Add(tabprodutos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmProdutos";
            Text = "Estoque de Produtos";
            Load += FrmProdutos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabCadastrar.ResumeLayout(false);
            tabCadastrar.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaprodutos).EndInit();
            tabprodutos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabPage tabPage1;
        private TextBox txtcodigo;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TabPage tabPage2;
        private DataGridView tabelaprodutos;
        private Button btnpesquisar;
        private Label label15;
        private TextBox txtpesquisa;
        public TabPage tabCadastrar;
        public TabControl tabprodutos;
        public Button btneditar;
        public Button btnexcluir;
        public Button btnsalvar;
        public ComboBox cmbfornecedores;
        public TextBox txtpreco;
        public TextBox txtdescricao;
        public Button btnnovo;
        public Label lblFornecedores;
        public TextBox txtqtd;
    }
}