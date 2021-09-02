
namespace SalaDeJuegos
{
    partial class FrmAdivinaNumero
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
            this.txtNumeroIngresado = new System.Windows.Forms.TextBox();
            this.btnGenerarRandom = new System.Windows.Forms.Button();
            this.chkIntentos = new System.Windows.Forms.CheckBox();
            this.grpNivel = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.grpNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeroIngresado
            // 
            this.txtNumeroIngresado.Location = new System.Drawing.Point(107, 117);
            this.txtNumeroIngresado.Name = "txtNumeroIngresado";
            this.txtNumeroIngresado.Size = new System.Drawing.Size(222, 20);
            this.txtNumeroIngresado.TabIndex = 0;
            // 
            // btnGenerarRandom
            // 
            this.btnGenerarRandom.Location = new System.Drawing.Point(214, 143);
            this.btnGenerarRandom.Name = "btnGenerarRandom";
            this.btnGenerarRandom.Size = new System.Drawing.Size(115, 81);
            this.btnGenerarRandom.TabIndex = 1;
            this.btnGenerarRandom.Text = "Generar Random";
            this.btnGenerarRandom.UseVisualStyleBackColor = true;
            this.btnGenerarRandom.Visible = false;
            this.btnGenerarRandom.Click += new System.EventHandler(this.btnGenerarRandom_Click);
            // 
            // chkIntentos
            // 
            this.chkIntentos.AutoSize = true;
            this.chkIntentos.Checked = true;
            this.chkIntentos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntentos.Location = new System.Drawing.Point(154, 12);
            this.chkIntentos.Name = "chkIntentos";
            this.chkIntentos.Size = new System.Drawing.Size(135, 17);
            this.chkIntentos.TabIndex = 2;
            this.chkIntentos.Text = "Contar hasta 5 intentos";
            this.chkIntentos.UseVisualStyleBackColor = true;
            this.chkIntentos.CheckedChanged += new System.EventHandler(this.chkIntentos_CheckedChanged);
            // 
            // grpNivel
            // 
            this.grpNivel.Controls.Add(this.radioButton3);
            this.grpNivel.Controls.Add(this.radioButton2);
            this.grpNivel.Controls.Add(this.radioButton1);
            this.grpNivel.Location = new System.Drawing.Point(107, 45);
            this.grpNivel.Name = "grpNivel";
            this.grpNivel.Size = new System.Drawing.Size(222, 58);
            this.grpNivel.TabIndex = 3;
            this.grpNivel.TabStop = false;
            this.grpNivel.Text = "Nivel";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(116, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "20";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(61, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "10";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(107, 143);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(98, 81);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // FrmAdivinaNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 268);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.grpNivel);
            this.Controls.Add(this.chkIntentos);
            this.Controls.Add(this.btnGenerarRandom);
            this.Controls.Add(this.txtNumeroIngresado);
            this.Name = "FrmAdivinaNumero";
            this.Text = "FrmAdivinaNumero";
            this.Load += new System.EventHandler(this.FrmAdivinaNumero_Load);
            this.grpNivel.ResumeLayout(false);
            this.grpNivel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroIngresado;
        private System.Windows.Forms.Button btnGenerarRandom;
        private System.Windows.Forms.CheckBox chkIntentos;
        private System.Windows.Forms.GroupBox grpNivel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnIniciar;
    }
}