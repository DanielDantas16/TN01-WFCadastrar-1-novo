namespace WFCadastroEndereco
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            lblCep = new Label();
            lblLinha = new Label();
            mtbCep = new MaskedTextBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblUf = new Label();
            cbxUf = new ComboBox();
            chkSemNumero = new CheckBox();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(21, 23);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(21, 41);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(436, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(354, 391);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 39);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(21, 114);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "Cep";
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(21, 72);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(438, 1);
            lblLinha.TabIndex = 11;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(25, 138);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(100, 23);
            mtbCep.TabIndex = 13;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(21, 179);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 14;
            lblLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(25, 197);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(241, 23);
            txtLogradouro.TabIndex = 15;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(25, 249);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(147, 23);
            txtComplemento.TabIndex = 17;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(21, 231);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 16;
            lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(275, 179);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 18;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(275, 197);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(61, 23);
            txtNumero.TabIndex = 19;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(188, 249);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(269, 23);
            txtBairro.TabIndex = 21;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(184, 231);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 20;
            lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(25, 309);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(301, 23);
            txtCidade.TabIndex = 23;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(21, 291);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 22;
            lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(336, 291);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 24;
            lblUf.Text = "UF";
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(336, 309);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(121, 23);
            cbxUf.TabIndex = 25;
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(358, 199);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(101, 19);
            chkSemNumero.TabIndex = 26;
            chkSemNumero.Text = "Sem Número?";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 456);
            Controls.Add(chkSemNumero);
            Controls.Add(cbxUf);
            Controls.Add(lblUf);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(mtbCep);
            Controls.Add(lblLinha);
            Controls.Add(lblCep);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private Label lblCep;
        private Label lblLinha;
        private MaskedTextBox mtbCep;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblUf;
        private ComboBox cbxUf;
        private CheckBox chkSemNumero;
    }
}