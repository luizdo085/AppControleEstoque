namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmHistorico
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
            btnPesquisar = new Button();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tabelahistorico = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelahistorico).BeginInit();
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
            panel1.Size = new Size(1117, 110);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(194, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(480, 56);
            label1.TabIndex = 0;
            label1.Text = "Histórico de vendas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Controls.Add(dtFim);
            groupBox1.Controls.Add(dtInicio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 103);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Navy;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(608, 42);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 30);
            btnPesquisar.TabIndex = 59;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dtFim
            // 
            dtFim.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(444, 42);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(125, 26);
            dtFim.TabIndex = 58;
            // 
            // dtInicio
            // 
            dtInicio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(209, 42);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(125, 26);
            dtInicio.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(361, 45);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 56;
            label3.Text = "Data Fim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(117, 45);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 54;
            label2.Text = "Data Inicio:";
            // 
            // tabelahistorico
            // 
            tabelahistorico.AllowUserToAddRows = false;
            tabelahistorico.AllowUserToDeleteRows = false;
            tabelahistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelahistorico.Location = new Point(12, 229);
            tabelahistorico.Name = "tabelahistorico";
            tabelahistorico.ReadOnly = true;
            tabelahistorico.RowTemplate.Height = 25;
            tabelahistorico.Size = new Size(861, 209);
            tabelahistorico.TabIndex = 7;
            tabelahistorico.CellClick += tabelahistorico_CellClick_1;
            // 
            // FrmHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 450);
            Controls.Add(tabelahistorico);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FrmHistorico";
            Text = "Histórico de vendas";
            Load += FrmHistorico_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelahistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dtInicio;
        private Label label3;
        private Label label2;
        private DateTimePicker dtFim;
        private Button btnPesquisar;
        private DataGridView tabelahistorico;
    }
}