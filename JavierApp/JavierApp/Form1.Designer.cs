
namespace JavierApp
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbFiltros = new System.Windows.Forms.TextBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.rtbFiltros = new System.Windows.Forms.RichTextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione";
            // 
            // tbFiltros
            // 
            this.tbFiltros.Location = new System.Drawing.Point(270, 26);
            this.tbFiltros.Name = "tbFiltros";
            this.tbFiltros.Size = new System.Drawing.Size(514, 22);
            this.tbFiltros.TabIndex = 4;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(790, 60);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(109, 27);
            this.btFiltrar.TabIndex = 7;
            this.btFiltrar.Text = "Enviar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valores";
            // 
            // cbTipoFiltro
            // 
            this.cbTipoFiltro.FormattingEnabled = true;
            this.cbTipoFiltro.Items.AddRange(new object[] {
            "Usuarios",
            "Perfiles",
            "Transacciones",
            "Grupos"});
            this.cbTipoFiltro.Location = new System.Drawing.Point(96, 25);
            this.cbTipoFiltro.Name = "cbTipoFiltro";
            this.cbTipoFiltro.Size = new System.Drawing.Size(168, 24);
            this.cbTipoFiltro.TabIndex = 10;
            this.cbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbTipoFiltro_SelectedIndexChanged);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(790, 25);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(109, 27);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // rtbFiltros
            // 
            this.rtbFiltros.Location = new System.Drawing.Point(20, 156);
            this.rtbFiltros.Name = "rtbFiltros";
            this.rtbFiltros.Size = new System.Drawing.Size(764, 268);
            this.rtbFiltros.TabIndex = 12;
            this.rtbFiltros.Text = "";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(790, 93);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(109, 27);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(790, 434);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(108, 27);
            this.btSalir.TabIndex = 14;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 479);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.rtbFiltros);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.cbTipoFiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.tbFiltros);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Consulta Tabla Expandida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFiltros;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoFiltro;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.RichTextBox rtbFiltros;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalir;
    }
}

