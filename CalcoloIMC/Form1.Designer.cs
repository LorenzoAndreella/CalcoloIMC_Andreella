namespace CalcoloIMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCognNome = new TextBox();
            txtPeso = new TextBox();
            txtAltezza = new TextBox();
            btnAdd = new Button();
            rdbIMC = new RadioButton();
            rdbMedia = new RadioButton();
            rdbModa = new RadioButton();
            rdbMediana = new RadioButton();
            rdbVarianza = new RadioButton();
            rdbMediaSottoGruppo = new RadioButton();
            btnEsegui = new Button();
            lstPersone = new ListBox();
            lblCognNom = new Label();
            lblPeso = new Label();
            lblAltezza = new Label();
            lblRisposta = new Label();
            txtRisposta = new TextBox();
            SuspendLayout();
            // 
            // txtCognNome
            // 
            txtCognNome.Location = new Point(12, 20);
            txtCognNome.Name = "txtCognNome";
            txtCognNome.Size = new Size(100, 23);
            txtCognNome.TabIndex = 0;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(264, 20);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 1;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // txtAltezza
            // 
            txtAltezza.Location = new Point(472, 20);
            txtAltezza.Name = "txtAltezza";
            txtAltezza.Size = new Size(100, 23);
            txtAltezza.TabIndex = 2;
            txtAltezza.KeyPress += txtAltezza_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(713, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rdbIMC
            // 
            rdbIMC.AutoSize = true;
            rdbIMC.Location = new Point(12, 336);
            rdbIMC.Name = "rdbIMC";
            rdbIMC.Size = new Size(157, 19);
            rdbIMC.TabIndex = 4;
            rdbIMC.TabStop = true;
            rdbIMC.Text = "CALCOLO IMC SINGOLO";
            rdbIMC.UseVisualStyleBackColor = true;
            // 
            // rdbMedia
            // 
            rdbMedia.AutoSize = true;
            rdbMedia.Location = new Point(175, 336);
            rdbMedia.Name = "rdbMedia";
            rdbMedia.Size = new Size(86, 19);
            rdbMedia.TabIndex = 5;
            rdbMedia.TabStop = true;
            rdbMedia.Text = "MEDIA IMC";
            rdbMedia.UseVisualStyleBackColor = true;
            // 
            // rdbModa
            // 
            rdbModa.AutoSize = true;
            rdbModa.Location = new Point(274, 336);
            rdbModa.Name = "rdbModa";
            rdbModa.Size = new Size(86, 19);
            rdbModa.TabIndex = 6;
            rdbModa.TabStop = true;
            rdbModa.Text = "MODA IMC";
            rdbModa.UseVisualStyleBackColor = true;
            // 
            // rdbMediana
            // 
            rdbMediana.AutoSize = true;
            rdbMediana.Location = new Point(367, 336);
            rdbMediana.Name = "rdbMediana";
            rdbMediana.Size = new Size(103, 19);
            rdbMediana.TabIndex = 7;
            rdbMediana.TabStop = true;
            rdbMediana.Text = "MEDIANA IMC";
            rdbMediana.UseVisualStyleBackColor = true;
            // 
            // rdbVarianza
            // 
            rdbVarianza.AutoSize = true;
            rdbVarianza.Location = new Point(476, 336);
            rdbVarianza.Name = "rdbVarianza";
            rdbVarianza.Size = new Size(106, 19);
            rdbVarianza.TabIndex = 8;
            rdbVarianza.TabStop = true;
            rdbVarianza.Text = "VARIANZA IMC";
            rdbVarianza.UseVisualStyleBackColor = true;
            // 
            // rdbMediaSottoGruppo
            // 
            rdbMediaSottoGruppo.AutoSize = true;
            rdbMediaSottoGruppo.Location = new Point(578, 336);
            rdbMediaSottoGruppo.Name = "rdbMediaSottoGruppo";
            rdbMediaSottoGruppo.Size = new Size(149, 19);
            rdbMediaSottoGruppo.TabIndex = 9;
            rdbMediaSottoGruppo.TabStop = true;
            rdbMediaSottoGruppo.Text = "MEDIA SOTTO GRUPPO";
            rdbMediaSottoGruppo.UseVisualStyleBackColor = true;
            // 
            // btnEsegui
            // 
            btnEsegui.Location = new Point(726, 334);
            btnEsegui.Name = "btnEsegui";
            btnEsegui.Size = new Size(75, 23);
            btnEsegui.TabIndex = 10;
            btnEsegui.Text = "ESEGUI";
            btnEsegui.UseVisualStyleBackColor = true;
            btnEsegui.Click += btnEsegui_Click;
            // 
            // lstPersone
            // 
            lstPersone.FormattingEnabled = true;
            lstPersone.Location = new Point(12, 71);
            lstPersone.Name = "lstPersone";
            lstPersone.Size = new Size(765, 259);
            lstPersone.TabIndex = 11;
            // 
            // lblCognNom
            // 
            lblCognNom.AutoSize = true;
            lblCognNom.Location = new Point(12, 2);
            lblCognNom.Name = "lblCognNom";
            lblCognNom.Size = new Size(96, 15);
            lblCognNom.TabIndex = 12;
            lblCognNom.Text = "Cognome Nome";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(264, 2);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(70, 15);
            lblPeso.TabIndex = 13;
            lblPeso.Text = "Peso (in Kg)";
            // 
            // lblAltezza
            // 
            lblAltezza.AutoSize = true;
            lblAltezza.Location = new Point(472, 2);
            lblAltezza.Name = "lblAltezza";
            lblAltezza.Size = new Size(85, 15);
            lblAltezza.TabIndex = 14;
            lblAltezza.Text = "Altezza (in cm)";
            // 
            // lblRisposta
            // 
            lblRisposta.AutoSize = true;
            lblRisposta.Location = new Point(12, 367);
            lblRisposta.Name = "lblRisposta";
            lblRisposta.Size = new Size(59, 15);
            lblRisposta.TabIndex = 15;
            lblRisposta.Text = "Risultato: ";
            // 
            // txtRisposta
            // 
            txtRisposta.Location = new Point(89, 364);
            txtRisposta.Name = "txtRisposta";
            txtRisposta.ReadOnly = true;
            txtRisposta.Size = new Size(609, 23);
            txtRisposta.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRisposta);
            Controls.Add(lblRisposta);
            Controls.Add(lblAltezza);
            Controls.Add(lblPeso);
            Controls.Add(lblCognNom);
            Controls.Add(lstPersone);
            Controls.Add(btnEsegui);
            Controls.Add(rdbMediaSottoGruppo);
            Controls.Add(rdbVarianza);
            Controls.Add(rdbMediana);
            Controls.Add(rdbModa);
            Controls.Add(rdbMedia);
            Controls.Add(rdbIMC);
            Controls.Add(btnAdd);
            Controls.Add(txtAltezza);
            Controls.Add(txtPeso);
            Controls.Add(txtCognNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCognNome;
        private TextBox txtPeso;
        private TextBox txtAltezza;
        private Button btnAdd;
        private RadioButton rdbIMC;
        private RadioButton rdbMedia;
        private RadioButton rdbModa;
        private RadioButton rdbMediana;
        private RadioButton rdbVarianza;
        private RadioButton rdbMediaSottoGruppo;
        private Button btnEsegui;
        private ListBox lstPersone;
        private Label lblCognNom;
        private Label lblPeso;
        private Label lblAltezza;
        private Label lblRisposta;
        private TextBox txtRisposta;
    }
}
