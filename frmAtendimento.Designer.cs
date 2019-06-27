namespace PetShop_MVC_
{
    partial class frmAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtendimento));
            this.grbBuscas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaPeriodo = new System.Windows.Forms.Button();
            this.btnBuscaPet = new System.Windows.Forms.Button();
            this.btnBuscaFunc = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodAtend = new System.Windows.Forms.TextBox();
            this.txtCodServ = new System.Windows.Forms.TextBox();
            this.txtCodPet = new System.Windows.Forms.TextBox();
            this.txtCodFun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbBuscas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBuscas
            // 
            this.grbBuscas.Controls.Add(this.label2);
            this.grbBuscas.Controls.Add(this.label1);
            this.grbBuscas.Controls.Add(this.dtpFim);
            this.grbBuscas.Controls.Add(this.dtpInicio);
            this.grbBuscas.Controls.Add(this.btnBuscaPeriodo);
            this.grbBuscas.Controls.Add(this.btnBuscaPet);
            this.grbBuscas.Controls.Add(this.btnBuscaFunc);
            this.grbBuscas.Location = new System.Drawing.Point(28, 186);
            this.grbBuscas.Name = "grbBuscas";
            this.grbBuscas.Size = new System.Drawing.Size(424, 123);
            this.grbBuscas.TabIndex = 0;
            this.grbBuscas.TabStop = false;
            this.grbBuscas.Text = "Buscar Por:";
            this.grbBuscas.Enter += new System.EventHandler(this.grbBuscas_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Fim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Início:";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(303, 48);
            this.dtpFim.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpFim.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(81, 20);
            this.dtpFim.TabIndex = 4;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(303, 13);
            this.dtpInicio.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(81, 20);
            this.dtpInicio.TabIndex = 3;
            this.dtpInicio.Value = new System.DateTime(2019, 6, 8, 23, 17, 34, 0);
            // 
            // btnBuscaPeriodo
            // 
            this.btnBuscaPeriodo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaPeriodo.Image = global::PetShop_MVC_.Properties.Resources.icons8_calendário_27_24;
            this.btnBuscaPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaPeriodo.Location = new System.Drawing.Point(318, 74);
            this.btnBuscaPeriodo.Name = "btnBuscaPeriodo";
            this.btnBuscaPeriodo.Size = new System.Drawing.Size(66, 39);
            this.btnBuscaPeriodo.TabIndex = 2;
            this.btnBuscaPeriodo.Text = "Data";
            this.btnBuscaPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaPeriodo.UseVisualStyleBackColor = true;
            this.btnBuscaPeriodo.Click += new System.EventHandler(this.btnBuscaPeriodo_Click);
            // 
            // btnBuscaPet
            // 
            this.btnBuscaPet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaPet.Image = global::PetShop_MVC_.Properties.Resources.icons8_pegada_de_gato_26;
            this.btnBuscaPet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaPet.Location = new System.Drawing.Point(139, 48);
            this.btnBuscaPet.Name = "btnBuscaPet";
            this.btnBuscaPet.Size = new System.Drawing.Size(72, 42);
            this.btnBuscaPet.TabIndex = 1;
            this.btnBuscaPet.Text = "Pet";
            this.btnBuscaPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaPet.UseVisualStyleBackColor = true;
            this.btnBuscaPet.Click += new System.EventHandler(this.btnBuscaPet_Click);
            // 
            // btnBuscaFunc
            // 
            this.btnBuscaFunc.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaFunc.Image = global::PetShop_MVC_.Properties.Resources.icons8_pessoa_do_sexo_masculino_30;
            this.btnBuscaFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaFunc.Location = new System.Drawing.Point(16, 48);
            this.btnBuscaFunc.Name = "btnBuscaFunc";
            this.btnBuscaFunc.Size = new System.Drawing.Size(103, 42);
            this.btnBuscaFunc.TabIndex = 0;
            this.btnBuscaFunc.Text = "Funcionário";
            this.btnBuscaFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaFunc.UseVisualStyleBackColor = true;
            this.btnBuscaFunc.Click += new System.EventHandler(this.btnBuscaFunc_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(477, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(463, 297);
            this.dgvDados.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Pet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Código Serviço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Código Funcionário:\r\n\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Código Atendimento:";
            // 
            // txtCodAtend
            // 
            this.txtCodAtend.Location = new System.Drawing.Point(149, 12);
            this.txtCodAtend.Name = "txtCodAtend";
            this.txtCodAtend.Size = new System.Drawing.Size(56, 20);
            this.txtCodAtend.TabIndex = 3;
            // 
            // txtCodServ
            // 
            this.txtCodServ.Location = new System.Drawing.Point(149, 41);
            this.txtCodServ.Name = "txtCodServ";
            this.txtCodServ.Size = new System.Drawing.Size(56, 20);
            this.txtCodServ.TabIndex = 4;
            // 
            // txtCodPet
            // 
            this.txtCodPet.Location = new System.Drawing.Point(149, 67);
            this.txtCodPet.Name = "txtCodPet";
            this.txtCodPet.Size = new System.Drawing.Size(56, 20);
            this.txtCodPet.TabIndex = 5;
            // 
            // txtCodFun
            // 
            this.txtCodFun.Location = new System.Drawing.Point(149, 100);
            this.txtCodFun.Name = "txtCodFun";
            this.txtCodFun.Size = new System.Drawing.Size(56, 20);
            this.txtCodFun.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data/Hora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Situação:";
            // 
            // dtpDataHora
            // 
            this.dtpDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHora.Location = new System.Drawing.Point(149, 126);
            this.dtpDataHora.Name = "dtpDataHora";
            this.dtpDataHora.Size = new System.Drawing.Size(155, 20);
            this.dtpDataHora.TabIndex = 9;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DisplayMember = "Pago";
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "PAGO",
            "PENDENTE"});
            this.cmbSituacao.Location = new System.Drawing.Point(149, 157);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(90, 21);
            this.cmbSituacao.TabIndex = 10;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Image = global::PetShop_MVC_.Properties.Resources.save;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastro.Location = new System.Drawing.Point(271, 26);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 72);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PetShop_MVC_.Properties.Resources.buscar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(363, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(952, 331);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.dtpDataHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodFun);
            this.Controls.Add(this.txtCodPet);
            this.Controls.Add(this.txtCodServ);
            this.Controls.Add(this.txtCodAtend);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.grbBuscas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.frmAtendimento_Load);
            this.grbBuscas.ResumeLayout(false);
            this.grbBuscas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBuscas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnBuscaPeriodo;
        private System.Windows.Forms.Button btnBuscaPet;
        private System.Windows.Forms.Button btnBuscaFunc;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodAtend;
        private System.Windows.Forms.TextBox txtCodServ;
        private System.Windows.Forms.TextBox txtCodPet;
        private System.Windows.Forms.TextBox txtCodFun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataHora;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastro;
    }
}