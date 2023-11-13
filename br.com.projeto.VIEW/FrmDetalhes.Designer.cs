namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmDetalhes
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
            groupBox1 = new GroupBox();
            txtfuncionario = new TextBox();
            label8 = new Label();
            txtentrega_retirada = new TextBox();
            txtdata = new TextBox();
            label7 = new Label();
            txtforma_pagamento = new TextBox();
            label6 = new Label();
            txtobs = new TextBox();
            txttotalvenda = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtcliente = new TextBox();
            label2 = new Label();
            tabelaitens = new DataGridView();
            btnexcluir = new Button();
            txtobsexclui = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaitens).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login_certo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 110);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(473, 56);
            label1.TabIndex = 0;
            label1.Text = "Detalhes de vendas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtfuncionario);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtentrega_retirada);
            groupBox1.Controls.Add(txtdata);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtforma_pagamento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtobs);
            groupBox1.Controls.Add(txttotalvenda);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtcliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 183);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da venda";
            // 
            // txtfuncionario
            // 
            txtfuncionario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtfuncionario.Location = new Point(102, 56);
            txtfuncionario.Name = "txtfuncionario";
            txtfuncionario.ReadOnly = true;
            txtfuncionario.Size = new Size(255, 26);
            txtfuncionario.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(6, 59);
            label8.Name = "label8";
            label8.Size = new Size(94, 18);
            label8.TabIndex = 69;
            label8.Text = "Funcionario:";
            // 
            // txtentrega_retirada
            // 
            txtentrega_retirada.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtentrega_retirada.Location = new Point(665, 56);
            txtentrega_retirada.Name = "txtentrega_retirada";
            txtentrega_retirada.ReadOnly = true;
            txtentrega_retirada.Size = new Size(105, 26);
            txtentrega_retirada.TabIndex = 68;
            // 
            // txtdata
            // 
            txtdata.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdata.Location = new Point(416, 56);
            txtdata.Name = "txtdata";
            txtdata.ReadOnly = true;
            txtdata.Size = new Size(89, 26);
            txtdata.TabIndex = 62;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(513, 59);
            label7.Name = "label7";
            label7.Size = new Size(146, 18);
            label7.TabIndex = 67;
            label7.Text = "Entrega ou retirada:";
            // 
            // txtforma_pagamento
            // 
            txtforma_pagamento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtforma_pagamento.Location = new Point(568, 24);
            txtforma_pagamento.Name = "txtforma_pagamento";
            txtforma_pagamento.ReadOnly = true;
            txtforma_pagamento.Size = new Size(202, 26);
            txtforma_pagamento.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(399, 27);
            label6.Name = "label6";
            label6.Size = new Size(163, 18);
            label6.TabIndex = 65;
            label6.Text = "Forma de pagamento:";
            // 
            // txtobs
            // 
            txtobs.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtobs.Location = new Point(63, 120);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.ReadOnly = true;
            txtobs.Size = new Size(707, 48);
            txtobs.TabIndex = 62;
            // 
            // txttotalvenda
            // 
            txttotalvenda.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalvenda.Location = new Point(653, 88);
            txttotalvenda.Name = "txttotalvenda";
            txttotalvenda.ReadOnly = true;
            txttotalvenda.Size = new Size(117, 26);
            txttotalvenda.TabIndex = 64;
            txttotalvenda.TextChanged += txttotalvenda_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(8, 123);
            label5.Name = "label5";
            label5.Size = new Size(45, 18);
            label5.TabIndex = 61;
            label5.Text = "Obs.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(535, 91);
            label4.Name = "label4";
            label4.Size = new Size(112, 18);
            label4.TabIndex = 63;
            label4.Text = "Total da venda:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(364, 59);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 61;
            label3.Text = "Data:";
            // 
            // txtcliente
            // 
            txtcliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcliente.Location = new Point(63, 24);
            txtcliente.Name = "txtcliente";
            txtcliente.ReadOnly = true;
            txtcliente.Size = new Size(330, 26);
            txtcliente.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 54;
            label2.Text = "Cliente:";
            label2.Click += label2_Click;
            // 
            // tabelaitens
            // 
            tabelaitens.AllowUserToAddRows = false;
            tabelaitens.AllowUserToDeleteRows = false;
            tabelaitens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaitens.Location = new Point(12, 306);
            tabelaitens.Name = "tabelaitens";
            tabelaitens.ReadOnly = true;
            tabelaitens.RowTemplate.Height = 25;
            tabelaitens.Size = new Size(787, 217);
            tabelaitens.TabIndex = 7;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.Navy;
            btnexcluir.FlatStyle = FlatStyle.Flat;
            btnexcluir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnexcluir.ForeColor = Color.White;
            btnexcluir.Location = new Point(630, 529);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(169, 30);
            btnexcluir.TabIndex = 31;
            btnexcluir.Text = "CANCELAR VENDA";
            btnexcluir.UseVisualStyleBackColor = false;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // txtobsexclui
            // 
            txtobsexclui.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtobsexclui.Location = new Point(175, 529);
            txtobsexclui.Multiline = true;
            txtobsexclui.Name = "txtobsexclui";
            txtobsexclui.Size = new Size(449, 30);
            txtobsexclui.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(12, 535);
            label9.Name = "label9";
            label9.Size = new Size(157, 18);
            label9.TabIndex = 64;
            label9.Text = "Por que vai cancelar.:";
            // 
            // FrmDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 567);
            Controls.Add(label9);
            Controls.Add(txtobsexclui);
            Controls.Add(btnexcluir);
            Controls.Add(tabelaitens);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FrmDetalhes";
            Text = "Detalhes da venda";
            Load += FrmDetalhes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaitens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView tabelaitens;
        public TextBox txtcliente;
        public TextBox txtobs;
        public TextBox txttotalvenda;
        public TextBox txtdata;
        public TextBox txtforma_pagamento;
        private Label label6;
        public TextBox txtentrega_retirada;
        private Label label7;
        public TextBox txtfuncionario;
        private Label label8;
        public Button btnexcluir;
        public TextBox txtobsexclui;
        private Label label9;
    }
}