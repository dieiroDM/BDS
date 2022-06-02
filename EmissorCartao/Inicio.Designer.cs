
namespace EmissorCartao
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 227);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE EMISSÃO \r\nDE \r\nCARTÕES DO ESTUDANTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(21, 308);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(244, 180);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Cartões";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEmitir
            // 
            this.btnEmitir.Location = new System.Drawing.Point(271, 308);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(244, 180);
            this.btnEmitir.TabIndex = 1;
            this.btnEmitir.Text = "Emitir Cartão";
            this.btnEmitir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmitir.UseVisualStyleBackColor = true;
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(521, 308);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(244, 180);
            this.btnAlunos.TabIndex = 1;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 523);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.Text = "SECE v1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Button btnAlunos;
    }
}

