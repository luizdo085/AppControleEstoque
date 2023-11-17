namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmPagamentos
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
            label1 = new Label();
            panel1 = new Panel();
            txtdinheiro = new TextBox();
            label8 = new Label();
            txtcartao = new TextBox();
            label2 = new Label();
            txttroco = new TextBox();
            label3 = new Label();
            txttotal = new TextBox();
            label4 = new Label();
            btnfinalizar = new Button();
            label5 = new Label();
            txtobs = new TextBox();
            ImprimeVenda = new System.Drawing.Printing.PrintDocument();
            btnimpimir = new Button();
            printDialog1 = new PrintDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(158, 32);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 70);
            label1.TabIndex = 0;
            label1.Text = "Pagamentos";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login_certo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 147);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // txtdinheiro
            // 
            txtdinheiro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdinheiro.Location = new Point(129, 180);
            txtdinheiro.Margin = new Padding(3, 4, 3, 4);
            txtdinheiro.Name = "txtdinheiro";
            txtdinheiro.Size = new Size(229, 30);
            txtdinheiro.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(7, 184);
            label8.Name = "label8";
            label8.Size = new Size(126, 23);
            label8.TabIndex = 23;
            label8.Text = "Dinheiro(R$):";
            label8.Click += label8_Click;
            // 
            // txtcartao
            // 
            txtcartao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcartao.Location = new Point(129, 233);
            txtcartao.Margin = new Padding(3, 4, 3, 4);
            txtcartao.Name = "txtcartao";
            txtcartao.Size = new Size(229, 30);
            txtcartao.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(54, 237);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 25;
            label2.Text = "Cartão:";
            label2.Click += label2_Click;
            // 
            // txttroco
            // 
            txttroco.BackColor = SystemColors.Window;
            txttroco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttroco.Location = new Point(129, 288);
            txttroco.Margin = new Padding(3, 4, 3, 4);
            txttroco.Name = "txttroco";
            txttroco.ReadOnly = true;
            txttroco.Size = new Size(229, 30);
            txttroco.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(64, 292);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 27;
            label3.Text = "Troco:";
            label3.Click += label3_Click;
            // 
            // txttotal
            // 
            txttotal.BackColor = SystemColors.Window;
            txttotal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotal.Location = new Point(129, 364);
            txttotal.Margin = new Padding(3, 4, 3, 4);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(229, 30);
            txttotal.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(72, 368);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 29;
            label4.Text = "Total:";
            label4.Click += label4_Click;
            // 
            // btnfinalizar
            // 
            btnfinalizar.BackColor = Color.Navy;
            btnfinalizar.FlatStyle = FlatStyle.Flat;
            btnfinalizar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnfinalizar.ForeColor = Color.White;
            btnfinalizar.Location = new Point(15, 441);
            btnfinalizar.Margin = new Padding(3, 4, 3, 4);
            btnfinalizar.Name = "btnfinalizar";
            btnfinalizar.Size = new Size(354, 63);
            btnfinalizar.TabIndex = 39;
            btnfinalizar.Text = "Finalizar Venda";
            btnfinalizar.UseVisualStyleBackColor = false;
            btnfinalizar.Click += btnfinalizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(377, 184);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 40;
            label5.Text = "Obs.:";
            label5.Click += label5_Click;
            // 
            // txtobs
            // 
            txtobs.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtobs.Location = new Point(435, 180);
            txtobs.Margin = new Padding(3, 4, 3, 4);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new Size(229, 323);
            txtobs.TabIndex = 41;
            // 
            // ImprimeVenda
            // 
            ImprimeVenda.PrintPage += ImprimeVenda_PrintPage;
            // 
            // btnimpimir
            // 
            btnimpimir.Location = new Point(249, 512);
            btnimpimir.Margin = new Padding(3, 4, 3, 4);
            btnimpimir.Name = "btnimpimir";
            btnimpimir.Size = new Size(86, 31);
            btnimpimir.TabIndex = 42;
            btnimpimir.Text = "Imprimir";
            btnimpimir.UseVisualStyleBackColor = true;
            btnimpimir.Click += btnimpimir_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // FrmPagamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 557);
            Controls.Add(btnimpimir);
            Controls.Add(txtobs);
            Controls.Add(label5);
            Controls.Add(btnfinalizar);
            Controls.Add(txttotal);
            Controls.Add(label4);
            Controls.Add(txttroco);
            Controls.Add(label3);
            Controls.Add(txtcartao);
            Controls.Add(label2);
            Controls.Add(txtdinheiro);
            Controls.Add(label8);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPagamentos";
            Text = "Tela Pagamentos";
            Load += FrmPagamentos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtdinheiro;
        private Label label8;
        private TextBox txtcartao;
        private Label label2;
        private TextBox txttroco;
        private Label label3;
        private Label label4;
        private Button btnfinalizar;
        public TextBox txttotal;
        private Label label5;
        private TextBox txtobs;
        private System.Drawing.Printing.PrintDocument ImprimeVenda;
        private Button btnimpimir;
        private PrintDialog printDialog1;
    }
}