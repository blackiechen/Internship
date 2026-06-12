namespace Recreativo
{
    partial class NovoUti
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.ckbPin = new System.Windows.Forms.CheckBox();
            this.mtbPin = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.mtbConfirmar = new System.Windows.Forms.MaskedTextBox();
            this.ckbConfirmar = new System.Windows.Forms.CheckBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEscalao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tipo de Acesso:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(76, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(306, 20);
            this.txtUser.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Utilizador:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(307, 93);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 41);
            this.btnInserir.TabIndex = 52;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // ckbPin
            // 
            this.ckbPin.AutoSize = true;
            this.ckbPin.Location = new System.Drawing.Point(183, 81);
            this.ckbPin.Name = "ckbPin";
            this.ckbPin.Size = new System.Drawing.Size(15, 14);
            this.ckbPin.TabIndex = 50;
            this.ckbPin.UseVisualStyleBackColor = true;
            this.ckbPin.CheckedChanged += new System.EventHandler(this.ckbPin_CheckedChanged);
            // 
            // mtbPin
            // 
            this.mtbPin.Location = new System.Drawing.Point(48, 78);
            this.mtbPin.Mask = "0000";
            this.mtbPin.Name = "mtbPin";
            this.mtbPin.Size = new System.Drawing.Size(129, 20);
            this.mtbPin.TabIndex = 48;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 20);
            this.txtNome.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Pin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nome:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Confirmar Pin:";
            // 
            // mtbConfirmar
            // 
            this.mtbConfirmar.Location = new System.Drawing.Point(95, 104);
            this.mtbConfirmar.Mask = "0000";
            this.mtbConfirmar.Name = "mtbConfirmar";
            this.mtbConfirmar.Size = new System.Drawing.Size(82, 20);
            this.mtbConfirmar.TabIndex = 59;
            // 
            // ckbConfirmar
            // 
            this.ckbConfirmar.AutoSize = true;
            this.ckbConfirmar.Location = new System.Drawing.Point(183, 107);
            this.ckbConfirmar.Name = "ckbConfirmar";
            this.ckbConfirmar.Size = new System.Drawing.Size(15, 14);
            this.ckbConfirmar.TabIndex = 60;
            this.ckbConfirmar.UseVisualStyleBackColor = true;
            this.ckbConfirmar.CheckedChanged += new System.EventHandler(this.ckbConfirmar_CheckedChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(107, 146);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(156, 21);
            this.cbTipo.TabIndex = 61;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Escalão:";
            // 
            // cbEscalao
            // 
            this.cbEscalao.FormattingEnabled = true;
            this.cbEscalao.Location = new System.Drawing.Point(71, 175);
            this.cbEscalao.Name = "cbEscalao";
            this.cbEscalao.Size = new System.Drawing.Size(63, 21);
            this.cbEscalao.TabIndex = 63;
            // 
            // NovoUti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 233);
            this.Controls.Add(this.cbEscalao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.ckbConfirmar);
            this.Controls.Add(this.mtbConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.ckbPin);
            this.Controls.Add(this.mtbPin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "NovoUti";
            this.Text = "NovoUti";
            this.Load += new System.EventHandler(this.NovoUti_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.CheckBox ckbPin;
        private System.Windows.Forms.MaskedTextBox mtbPin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbConfirmar;
        private System.Windows.Forms.MaskedTextBox mtbConfirmar;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEscalao;
    }
}