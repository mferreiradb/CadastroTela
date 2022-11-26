namespace TelaCadastro
{
    partial class fmrCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxCasaPropria = new System.Windows.Forms.CheckBox();
            this.checkBoxVeiculo = new System.Windows.Forms.CheckBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonOutro = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.listBoxCadastros = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(54, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(54, 83);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(176, 25);
            this.lblNascimento.TabIndex = 1;
            this.lblNascimento.Text = "Data Nascimento";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(54, 130);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(122, 25);
            this.lblEstadoCivil.TabIndex = 2;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(54, 180);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(94, 25);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(296, 27);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(410, 33);
            this.txtBoxNome.TabIndex = 4;
            this.txtBoxNome.TextChanged += new System.EventHandler(this.txtBoxNome_TextChanged);
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerNascimento.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(296, 77);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(410, 33);
            this.dateTimePickerNascimento.TabIndex = 5;
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEstadoCivil.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(296, 127);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(288, 33);
            this.comboBoxEstadoCivil.TabIndex = 6;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(839, 88);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(296, 177);
            this.txtTelefone.Mask = "(00) 0 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(288, 33);
            this.txtTelefone.TabIndex = 8;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // checkBoxCasaPropria
            // 
            this.checkBoxCasaPropria.AutoSize = true;
            this.checkBoxCasaPropria.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCasaPropria.Location = new System.Drawing.Point(296, 243);
            this.checkBoxCasaPropria.Name = "checkBoxCasaPropria";
            this.checkBoxCasaPropria.Size = new System.Drawing.Size(142, 19);
            this.checkBoxCasaPropria.TabIndex = 9;
            this.checkBoxCasaPropria.Text = "Possui Casa Própria";
            this.checkBoxCasaPropria.UseVisualStyleBackColor = true;
            // 
            // checkBoxVeiculo
            // 
            this.checkBoxVeiculo.AutoSize = true;
            this.checkBoxVeiculo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVeiculo.Location = new System.Drawing.Point(474, 243);
            this.checkBoxVeiculo.Name = "checkBoxVeiculo";
            this.checkBoxVeiculo.Size = new System.Drawing.Size(110, 19);
            this.checkBoxVeiculo.TabIndex = 10;
            this.checkBoxVeiculo.Text = "Possui Veículo";
            this.checkBoxVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.BackColor = System.Drawing.Color.White;
            this.groupBoxSexo.Controls.Add(this.radioButtonOutro);
            this.groupBoxSexo.Controls.Add(this.radioButtonFeminino);
            this.groupBoxSexo.Controls.Add(this.radioButtonMasculino);
            this.groupBoxSexo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSexo.Location = new System.Drawing.Point(296, 302);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(288, 100);
            this.groupBoxSexo.TabIndex = 11;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // radioButtonOutro
            // 
            this.radioButtonOutro.AutoSize = true;
            this.radioButtonOutro.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOutro.Location = new System.Drawing.Point(208, 41);
            this.radioButtonOutro.Name = "radioButtonOutro";
            this.radioButtonOutro.Size = new System.Drawing.Size(57, 19);
            this.radioButtonOutro.TabIndex = 2;
            this.radioButtonOutro.TabStop = true;
            this.radioButtonOutro.Text = "Outro";
            this.radioButtonOutro.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFeminino.Location = new System.Drawing.Point(113, 41);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(77, 19);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasculino.Location = new System.Drawing.Point(12, 41);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(84, 19);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // listBoxCadastros
            // 
            this.listBoxCadastros.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.listBoxCadastros.FormattingEnabled = true;
            this.listBoxCadastros.ItemHeight = 25;
            this.listBoxCadastros.Location = new System.Drawing.Point(-2, 492);
            this.listBoxCadastros.Name = "listBoxCadastros";
            this.listBoxCadastros.Size = new System.Drawing.Size(802, 179);
            this.listBoxCadastros.TabIndex = 12;
            this.listBoxCadastros.SelectedIndexChanged += new System.EventHandler(this.listBoxCadastros_SelectedIndexChanged);
            this.listBoxCadastros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCadastros_MouseDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(50, 243);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 33);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(50, 298);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 33);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(50, 353);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 33);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonCancelar.Location = new System.Drawing.Point(50, 408);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(126, 33);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // fmrCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.listBoxCadastros);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.checkBoxVeiculo);
            this.Controls.Add(this.checkBoxCasaPropria);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBoxEstadoCivil);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 713);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 713);
            this.Name = "fmrCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.CheckBox checkBoxCasaPropria;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonOutro;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.CheckBox checkBoxVeiculo;
        private System.Windows.Forms.ListBox listBoxCadastros;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}

