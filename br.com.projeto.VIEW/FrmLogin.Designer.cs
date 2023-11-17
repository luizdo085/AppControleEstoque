namespace AppGASeAGUA
{
    partial class FrmLogin
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
            txtemail = new TextBox();
            txtsenha = new TextBox();
            btnentrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 109);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 0;
            label1.Text = "TELA DE LOGIN";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.MidnightBlue;
            txtemail.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = Color.White;
            txtemail.Location = new Point(71, 181);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(373, 38);
            txtemail.TabIndex = 1;
            txtemail.Text = "Digite seu e-mail";
            txtemail.Click += txtemail_Click;
            // 
            // txtsenha
            // 
            txtsenha.BackColor = Color.MidnightBlue;
            txtsenha.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtsenha.ForeColor = Color.White;
            txtsenha.Location = new Point(71, 244);
            txtsenha.Margin = new Padding(3, 4, 3, 4);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(373, 38);
            txtsenha.TabIndex = 2;
            txtsenha.Text = "Digite sua senha";
            txtsenha.Click += txtsenha_Click;
            // 
            // btnentrar
            // 
            btnentrar.BackColor = Color.Red;
            btnentrar.FlatStyle = FlatStyle.Flat;
            btnentrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnentrar.Location = new Point(200, 327);
            btnentrar.Margin = new Padding(3, 4, 3, 4);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(119, 48);
            btnentrar.TabIndex = 3;
            btnentrar.Text = "ENTRAR";
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btnentrar);
            Controls.Add(txtsenha);
            Controls.Add(txtemail);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmLogin";
            Text = "Seja bem-vindo ao sistema";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtemail;
        private TextBox txtsenha;
        private Button btnentrar;
        private Label label2;
    }
}