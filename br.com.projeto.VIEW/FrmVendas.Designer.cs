namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmVendas
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            rbtnentrega = new RadioButton();
            rbtnretirada = new RadioButton();
            cmbestado = new ComboBox();
            label1 = new Label();
            txtdata = new MaskedTextBox();
            label14 = new Label();
            txtnome = new TextBox();
            label13 = new Label();
            txtnumero = new TextBox();
            label3 = new Label();
            txtcidade = new TextBox();
            label12 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            txtbairro = new TextBox();
            txtendereco = new TextBox();
            txtcpf = new MaskedTextBox();
            groupBox2 = new GroupBox();
            txtpreco = new TextBox();
            btnremoveritem = new Button();
            txtcodigo = new TextBox();
            btnadditem = new Button();
            txtdescricao = new TextBox();
            label5 = new Label();
            txtqtd = new TextBox();
            label11 = new Label();
            label8 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txttotal = new TextBox();
            label7 = new Label();
            btnpagamento = new Button();
            btncancelarvenda = new Button();
            tabelaprodutos = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtfuncionario = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaprodutos).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login_certo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-52, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1523, 92);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(473, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(380, 56);
            label2.TabIndex = 1;
            label2.Text = "Tela de Vendas ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnentrega);
            groupBox1.Controls.Add(rbtnretirada);
            groupBox1.Controls.Add(cmbestado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtdata);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtnome);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtnumero);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtcidade);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtbairro);
            groupBox1.Controls.Add(txtendereco);
            groupBox1.Controls.Add(txtcpf);
            groupBox1.Location = new Point(38, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 202);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // rbtnentrega
            // 
            rbtnentrega.AutoSize = true;
            rbtnentrega.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnentrega.ForeColor = Color.Navy;
            rbtnentrega.Location = new Point(156, 80);
            rbtnentrega.Name = "rbtnentrega";
            rbtnentrega.Size = new Size(81, 22);
            rbtnentrega.TabIndex = 57;
            rbtnentrega.TabStop = true;
            rbtnentrega.Text = "Entrega";
            rbtnentrega.UseVisualStyleBackColor = true;
            rbtnentrega.CheckedChanged += rbtnentrega_CheckedChanged;
            rbtnentrega.Click += rbtnentrega_Click;
            // 
            // rbtnretirada
            // 
            rbtnretirada.AutoSize = true;
            rbtnretirada.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnretirada.ForeColor = Color.Navy;
            rbtnretirada.Location = new Point(64, 80);
            rbtnretirada.Name = "rbtnretirada";
            rbtnretirada.Size = new Size(86, 22);
            rbtnretirada.TabIndex = 56;
            rbtnretirada.TabStop = true;
            rbtnretirada.Text = "Retirada";
            rbtnretirada.UseVisualStyleBackColor = true;
            rbtnretirada.Click += rbtnretirada_Click;
            // 
            // cmbestado
            // 
            cmbestado.Enabled = false;
            cmbestado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbestado.FormattingEnabled = true;
            cmbestado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbestado.Location = new Point(443, 139);
            cmbestado.Name = "cmbestado";
            cmbestado.Size = new Size(65, 26);
            cmbestado.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 52;
            label1.Text = "Data:";
            // 
            // txtdata
            // 
            txtdata.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdata.Location = new Point(64, 16);
            txtdata.Mask = "00/00/0000";
            txtdata.Name = "txtdata";
            txtdata.ReadOnly = true;
            txtdata.Size = new Size(89, 26);
            txtdata.TabIndex = 53;
            txtdata.ValidatingType = typeof(DateTime);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(375, 142);
            label14.Name = "label14";
            label14.Size = new Size(62, 18);
            label14.TabIndex = 54;
            label14.Text = "Estado:";
            // 
            // txtnome
            // 
            txtnome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnome.Location = new Point(250, 48);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(258, 26);
            txtnome.TabIndex = 43;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(190, 142);
            label13.Name = "label13";
            label13.Size = new Size(64, 18);
            label13.TabIndex = 52;
            label13.Text = "Cidade:";
            // 
            // txtnumero
            // 
            txtnumero.Enabled = false;
            txtnumero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnumero.Location = new Point(443, 103);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(65, 26);
            txtnumero.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(190, 51);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 42;
            label3.Text = "Nome:";
            // 
            // txtcidade
            // 
            txtcidade.Enabled = false;
            txtcidade.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcidade.Location = new Point(254, 139);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(107, 26);
            txtcidade.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(8, 142);
            label12.Name = "label12";
            label12.Size = new Size(55, 18);
            label12.TabIndex = 50;
            label12.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(7, 108);
            label9.Name = "label9";
            label9.Size = new Size(80, 18);
            label9.TabIndex = 46;
            label9.Text = "Endereço:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(370, 105);
            label10.Name = "label10";
            label10.Size = new Size(67, 18);
            label10.TabIndex = 48;
            label10.Text = "Número:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(13, 51);
            label4.Name = "label4";
            label4.Size = new Size(45, 18);
            label4.TabIndex = 44;
            label4.Text = "CPF:";
            // 
            // txtbairro
            // 
            txtbairro.Enabled = false;
            txtbairro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbairro.Location = new Point(64, 139);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(125, 26);
            txtbairro.TabIndex = 51;
            // 
            // txtendereco
            // 
            txtendereco.Enabled = false;
            txtendereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtendereco.Location = new Point(93, 106);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(268, 26);
            txtendereco.TabIndex = 47;
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcpf.Location = new Point(64, 48);
            txtcpf.Mask = "###.###.###-##";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(124, 26);
            txtcpf.TabIndex = 45;
            txtcpf.KeyPress += txtcpf_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtpreco);
            groupBox2.Controls.Add(btnremoveritem);
            groupBox2.Controls.Add(txtcodigo);
            groupBox2.Controls.Add(btnadditem);
            groupBox2.Controls.Add(txtdescricao);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtqtd);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(38, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(514, 202);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            // 
            // txtpreco
            // 
            txtpreco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpreco.Location = new Point(112, 109);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(192, 26);
            txtpreco.TabIndex = 50;
            // 
            // btnremoveritem
            // 
            btnremoveritem.BackColor = Color.Navy;
            btnremoveritem.FlatStyle = FlatStyle.Flat;
            btnremoveritem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnremoveritem.ForeColor = Color.White;
            btnremoveritem.Location = new Point(356, 166);
            btnremoveritem.Name = "btnremoveritem";
            btnremoveritem.Size = new Size(121, 30);
            btnremoveritem.TabIndex = 31;
            btnremoveritem.Text = "Remover Item";
            btnremoveritem.UseVisualStyleBackColor = false;
            btnremoveritem.Click += btnremoveritem_Click;
            // 
            // txtcodigo
            // 
            txtcodigo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcodigo.Location = new Point(112, 27);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(85, 26);
            txtcodigo.TabIndex = 44;
            txtcodigo.KeyPress += txtcodigo_KeyPress;
            // 
            // btnadditem
            // 
            btnadditem.BackColor = Color.Navy;
            btnadditem.FlatStyle = FlatStyle.Flat;
            btnadditem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnadditem.ForeColor = Color.White;
            btnadditem.Location = new Point(229, 166);
            btnadditem.Name = "btnadditem";
            btnadditem.Size = new Size(121, 30);
            btnadditem.TabIndex = 29;
            btnadditem.Text = "Adicionar Item";
            btnadditem.UseVisualStyleBackColor = false;
            btnadditem.Click += btnadditem_Click;
            // 
            // txtdescricao
            // 
            txtdescricao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdescricao.Location = new Point(112, 67);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(365, 26);
            txtdescricao.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(45, 33);
            label5.Name = "label5";
            label5.Size = new Size(64, 18);
            label5.TabIndex = 43;
            label5.Text = "Código:";
            // 
            // txtqtd
            // 
            txtqtd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtqtd.Location = new Point(367, 109);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(109, 26);
            txtqtd.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(320, 112);
            label11.Name = "label11";
            label11.Size = new Size(41, 18);
            label11.TabIndex = 47;
            label11.Text = "Qtd.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(25, 112);
            label8.Name = "label8";
            label8.Size = new Size(84, 18);
            label8.TabIndex = 49;
            label8.Text = "Preço(R$):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(25, 73);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 45;
            label6.Text = "Descrição:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txttotal);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(655, 548);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(540, 56);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotal.Location = new Point(123, 22);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(375, 26);
            txttotal.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(43, 25);
            label7.Name = "label7";
            label7.Size = new Size(74, 18);
            label7.TabIndex = 51;
            label7.Text = "Total(R$):";
            // 
            // btnpagamento
            // 
            btnpagamento.BackColor = Color.Navy;
            btnpagamento.FlatStyle = FlatStyle.Flat;
            btnpagamento.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnpagamento.ForeColor = Color.White;
            btnpagamento.Location = new Point(655, 610);
            btnpagamento.Name = "btnpagamento";
            btnpagamento.Size = new Size(286, 47);
            btnpagamento.TabIndex = 40;
            btnpagamento.Text = "Pagamento";
            btnpagamento.UseVisualStyleBackColor = false;
            btnpagamento.Click += btnpagamento_Click;
            // 
            // btncancelarvenda
            // 
            btncancelarvenda.BackColor = Color.Navy;
            btncancelarvenda.FlatStyle = FlatStyle.Flat;
            btncancelarvenda.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelarvenda.ForeColor = Color.White;
            btncancelarvenda.Location = new Point(947, 610);
            btncancelarvenda.Name = "btncancelarvenda";
            btncancelarvenda.Size = new Size(248, 47);
            btncancelarvenda.TabIndex = 41;
            btncancelarvenda.Text = "Cancelar Venda";
            btncancelarvenda.UseVisualStyleBackColor = false;
            btncancelarvenda.Click += btncancelarvenda_Click;
            // 
            // tabelaprodutos
            // 
            tabelaprodutos.AllowUserToAddRows = false;
            tabelaprodutos.AllowUserToDeleteRows = false;
            tabelaprodutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaprodutos.Location = new Point(613, 125);
            tabelaprodutos.Name = "tabelaprodutos";
            tabelaprodutos.ReadOnly = true;
            tabelaprodutos.RowTemplate.Height = 25;
            tabelaprodutos.Size = new Size(622, 419);
            tabelaprodutos.TabIndex = 42;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtfuncionario });
            statusStrip1.Location = new Point(0, 670);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1247, 22);
            statusStrip1.TabIndex = 43;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(78, 17);
            toolStripStatusLabel1.Text = "Funcionario:";
            // 
            // txtfuncionario
            // 
            txtfuncionario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtfuncionario.Name = "txtfuncionario";
            txtfuncionario.Size = new Size(70, 17);
            txtfuncionario.Text = "Nome_Fun";
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 692);
            Controls.Add(statusStrip1);
            Controls.Add(tabelaprodutos);
            Controls.Add(btncancelarvenda);
            Controls.Add(btnpagamento);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FrmVendas";
            Text = "Tela de Vendas";
            WindowState = FormWindowState.Maximized;
            Load += FrmVendas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaprodutos).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnpagamento;
        private Button btncancelarvenda;
        private Button btnadditem;
        private Button btnremoveritem;
        private Label label1;
        private MaskedTextBox txtdata;
        private TextBox txtnome;
        private Label label3;
        private Label label12;
        private Label label9;
        private Label label4;
        private TextBox txtbairro;
        private TextBox txtendereco;
        private MaskedTextBox txtcpf;
        private ComboBox cmbestado;
        private TextBox txtnumero;
        private Label label13;
        private Label label14;
        private TextBox txtcidade;
        private Label label10;
        private RadioButton rbtnentrega;
        private RadioButton rbtnretirada;
        private DataGridView tabelaprodutos;
        private TextBox txtpreco;
        private TextBox txtcodigo;
        private TextBox txtdescricao;
        private Label label5;
        private TextBox txtqtd;
        private Label label11;
        private Label label8;
        private Label label6;
        private TextBox txttotal;
        private Label label7;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        public ToolStripStatusLabel txtfuncionario;
    }
}