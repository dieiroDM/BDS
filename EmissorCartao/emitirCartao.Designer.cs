
namespace EmissorCartao
{
    partial class emitirCartao
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
            this.gbEmitirCartao = new System.Windows.Forms.GroupBox();
            this.btnUploadFoto = new System.Windows.Forms.Button();
            this.lbDataV = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTerminarCard = new System.Windows.Forms.Button();
            this.lbDataE = new System.Windows.Forms.Label();
            this.lbNMatricula = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbNomeAluno = new System.Windows.Forms.Label();
            this.picFotoAluno = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.txtPalavrachave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEmitirCartao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEmitirCartao
            // 
            this.gbEmitirCartao.Controls.Add(this.btnUploadFoto);
            this.gbEmitirCartao.Controls.Add(this.lbDataV);
            this.gbEmitirCartao.Controls.Add(this.button1);
            this.gbEmitirCartao.Controls.Add(this.btnTerminarCard);
            this.gbEmitirCartao.Controls.Add(this.lbDataE);
            this.gbEmitirCartao.Controls.Add(this.lbNMatricula);
            this.gbEmitirCartao.Controls.Add(this.lbCurso);
            this.gbEmitirCartao.Controls.Add(this.lbNomeAluno);
            this.gbEmitirCartao.Controls.Add(this.picFotoAluno);
            this.gbEmitirCartao.Controls.Add(this.pictureBox1);
            this.gbEmitirCartao.Location = new System.Drawing.Point(3, 43);
            this.gbEmitirCartao.Name = "gbEmitirCartao";
            this.gbEmitirCartao.Size = new System.Drawing.Size(773, 465);
            this.gbEmitirCartao.TabIndex = 0;
            this.gbEmitirCartao.TabStop = false;
            this.gbEmitirCartao.Text = "Emitir Cartão";
            this.gbEmitirCartao.Visible = false;
            // 
            // btnUploadFoto
            // 
            this.btnUploadFoto.Location = new System.Drawing.Point(227, 152);
            this.btnUploadFoto.Name = "btnUploadFoto";
            this.btnUploadFoto.Size = new System.Drawing.Size(102, 23);
            this.btnUploadFoto.TabIndex = 6;
            this.btnUploadFoto.Text = "Carregar Foto";
            this.btnUploadFoto.UseVisualStyleBackColor = true;
            this.btnUploadFoto.Click += new System.EventHandler(this.btnUploadFoto_Click);
            // 
            // lbDataV
            // 
            this.lbDataV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.lbDataV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataV.Location = new System.Drawing.Point(430, 351);
            this.lbDataV.Name = "lbDataV";
            this.lbDataV.Size = new System.Drawing.Size(149, 20);
            this.lbDataV.TabIndex = 5;
            this.lbDataV.Text = "dd-MM-YYYY";
            this.lbDataV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTerminarCard
            // 
            this.btnTerminarCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarCard.Location = new System.Drawing.Point(552, 393);
            this.btnTerminarCard.Name = "btnTerminarCard";
            this.btnTerminarCard.Size = new System.Drawing.Size(148, 40);
            this.btnTerminarCard.TabIndex = 3;
            this.btnTerminarCard.Text = "Terminar";
            this.btnTerminarCard.UseVisualStyleBackColor = true;
            this.btnTerminarCard.Click += new System.EventHandler(this.btnTerminarCard_Click);
            // 
            // lbDataE
            // 
            this.lbDataE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.lbDataE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataE.Location = new System.Drawing.Point(134, 351);
            this.lbDataE.Name = "lbDataE";
            this.lbDataE.Size = new System.Drawing.Size(149, 20);
            this.lbDataE.TabIndex = 2;
            this.lbDataE.Text = "dd-MM-YYYY";
            this.lbDataE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNMatricula
            // 
            this.lbNMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.lbNMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNMatricula.Location = new System.Drawing.Point(221, 262);
            this.lbNMatricula.Name = "lbNMatricula";
            this.lbNMatricula.Size = new System.Drawing.Size(291, 27);
            this.lbNMatricula.TabIndex = 2;
            this.lbNMatricula.Text = "000000";
            // 
            // lbCurso
            // 
            this.lbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.lbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurso.Location = new System.Drawing.Point(153, 298);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(426, 20);
            this.lbCurso.TabIndex = 2;
            this.lbCurso.Text = "--------------";
            // 
            // lbNomeAluno
            // 
            this.lbNomeAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.lbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAluno.Location = new System.Drawing.Point(153, 227);
            this.lbNomeAluno.Name = "lbNomeAluno";
            this.lbNomeAluno.Size = new System.Drawing.Size(537, 26);
            this.lbNomeAluno.TabIndex = 2;
            this.lbNomeAluno.Text = "Nome de Teste isso";
            // 
            // picFotoAluno
            // 
            this.picFotoAluno.BackColor = System.Drawing.Color.Transparent;
            this.picFotoAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFotoAluno.Location = new System.Drawing.Point(77, 75);
            this.picFotoAluno.Name = "picFotoAluno";
            this.picFotoAluno.Size = new System.Drawing.Size(144, 142);
            this.picFotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoAluno.TabIndex = 0;
            this.picFotoAluno.TabStop = false;
            this.picFotoAluno.Click += new System.EventHandler(this.picFotoAluno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmissorCartao.Properties.Resources.cartao;
            this.pictureBox1.Location = new System.Drawing.Point(72, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgAlunos
            // 
            this.dgAlunos.AllowUserToAddRows = false;
            this.dgAlunos.AllowUserToDeleteRows = false;
            this.dgAlunos.AllowUserToResizeColumns = false;
            this.dgAlunos.AllowUserToResizeRows = false;
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgAlunos.Location = new System.Drawing.Point(15, 111);
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.ReadOnly = true;
            this.dgAlunos.RowHeadersVisible = false;
            this.dgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlunos.Size = new System.Drawing.Size(755, 450);
            this.dgAlunos.TabIndex = 1;
            this.dgAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlunos_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "aluno_nome";
            this.Column1.HeaderText = "NOME";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BI";
            this.Column2.HeaderText = "BI";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "n_Matricula";
            this.Column3.HeaderText = "MATRÍCULA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "curso";
            this.Column4.HeaderText = "CURSO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nivel";
            this.Column5.HeaderText = "NÍVEL ACAD.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(655, 567);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Próximo  >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarLista.Location = new System.Drawing.Point(12, 567);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(99, 38);
            this.btnAtualizarLista.TabIndex = 3;
            this.btnAtualizarLista.Text = "Actualizar";
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(35)))));
            this.lb_title.Location = new System.Drawing.Point(120, 2);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(549, 53);
            this.lb_title.TabIndex = 5;
            this.lb_title.Text = "SELECIONAR O ALUNO";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPalavrachave
            // 
            this.txtPalavrachave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavrachave.Location = new System.Drawing.Point(15, 79);
            this.txtPalavrachave.Name = "txtPalavrachave";
            this.txtPalavrachave.Size = new System.Drawing.Size(752, 26);
            this.txtPalavrachave.TabIndex = 6;
            this.txtPalavrachave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavrachave_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar Aluno (Nome / BI)";
            // 
            // emitirCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 617);
            this.Controls.Add(this.gbEmitirCartao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalavrachave);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgAlunos);
            this.Name = "emitirCartao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emitirCartao";
            this.Load += new System.EventHandler(this.emitirCartao_Load);
            this.gbEmitirCartao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmitirCartao;
        private System.Windows.Forms.DataGridView dgAlunos;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picFotoAluno;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbDataE;
        private System.Windows.Forms.Label lbNMatricula;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbNomeAluno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTerminarCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lbDataV;
        private System.Windows.Forms.TextBox txtPalavrachave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUploadFoto;
    }
}