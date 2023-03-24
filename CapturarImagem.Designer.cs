
namespace OrionWinForms
{
    partial class CapturarImagem
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
            this.pictureBoxImageCam = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageCamCaptured = new System.Windows.Forms.PictureBox();
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.lblEscolherCam = new System.Windows.Forms.Label();
            this.BtnIniciarCamera = new System.Windows.Forms.Button();
            this.BtnStopCam = new System.Windows.Forms.Button();
            this.BtnCaptureImagem = new System.Windows.Forms.Button();
            this.txtNomeDaImagem = new System.Windows.Forms.TextBox();
            this.lblNomeDaImagem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageCamCaptured)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImageCam
            // 
            this.pictureBoxImageCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageCam.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImageCam.Name = "pictureBoxImageCam";
            this.pictureBoxImageCam.Size = new System.Drawing.Size(265, 353);
            this.pictureBoxImageCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageCam.TabIndex = 0;
            this.pictureBoxImageCam.TabStop = false;
            // 
            // pictureBoxImageCamCaptured
            // 
            this.pictureBoxImageCamCaptured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageCamCaptured.Location = new System.Drawing.Point(283, 12);
            this.pictureBoxImageCamCaptured.Name = "pictureBoxImageCamCaptured";
            this.pictureBoxImageCamCaptured.Size = new System.Drawing.Size(265, 353);
            this.pictureBoxImageCamCaptured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageCamCaptured.TabIndex = 1;
            this.pictureBoxImageCamCaptured.TabStop = false;
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(13, 404);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(264, 28);
            this.comboBoxCameras.TabIndex = 2;
            // 
            // lblEscolherCam
            // 
            this.lblEscolherCam.AutoSize = true;
            this.lblEscolherCam.Location = new System.Drawing.Point(12, 381);
            this.lblEscolherCam.Name = "lblEscolherCam";
            this.lblEscolherCam.Size = new System.Drawing.Size(135, 20);
            this.lblEscolherCam.TabIndex = 3;
            this.lblEscolherCam.Text = "Escolha a WebCam";
            // 
            // BtnIniciarCamera
            // 
            this.BtnIniciarCamera.Location = new System.Drawing.Point(13, 438);
            this.BtnIniciarCamera.Name = "BtnIniciarCamera";
            this.BtnIniciarCamera.Size = new System.Drawing.Size(115, 29);
            this.BtnIniciarCamera.TabIndex = 4;
            this.BtnIniciarCamera.Text = "Start Cam";
            this.BtnIniciarCamera.UseVisualStyleBackColor = true;
            this.BtnIniciarCamera.Click += new System.EventHandler(this.BtnIniciarCamera_Click);
            // 
            // BtnStopCam
            // 
            this.BtnStopCam.Location = new System.Drawing.Point(163, 438);
            this.BtnStopCam.Name = "BtnStopCam";
            this.BtnStopCam.Size = new System.Drawing.Size(114, 29);
            this.BtnStopCam.TabIndex = 5;
            this.BtnStopCam.Text = "Stop Cam";
            this.BtnStopCam.UseVisualStyleBackColor = true;
            this.BtnStopCam.Click += new System.EventHandler(this.BtnStopCam_Click);
            // 
            // BtnCaptureImagem
            // 
            this.BtnCaptureImagem.Location = new System.Drawing.Point(399, 437);
            this.BtnCaptureImagem.Name = "BtnCaptureImagem";
            this.BtnCaptureImagem.Size = new System.Drawing.Size(149, 29);
            this.BtnCaptureImagem.TabIndex = 6;
            this.BtnCaptureImagem.Text = "Capturar Imagem";
            this.BtnCaptureImagem.UseVisualStyleBackColor = true;
            this.BtnCaptureImagem.Click += new System.EventHandler(this.BtnCaptureImagem_Click);
            // 
            // txtNomeDaImagem
            // 
            this.txtNomeDaImagem.Location = new System.Drawing.Point(283, 404);
            this.txtNomeDaImagem.Name = "txtNomeDaImagem";
            this.txtNomeDaImagem.Size = new System.Drawing.Size(265, 27);
            this.txtNomeDaImagem.TabIndex = 7;
            // 
            // lblNomeDaImagem
            // 
            this.lblNomeDaImagem.AutoSize = true;
            this.lblNomeDaImagem.Location = new System.Drawing.Point(283, 381);
            this.lblNomeDaImagem.Name = "lblNomeDaImagem";
            this.lblNomeDaImagem.Size = new System.Drawing.Size(130, 20);
            this.lblNomeDaImagem.TabIndex = 8;
            this.lblNomeDaImagem.Text = "Nome da Imagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(297, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "* nome da image = nome do membro";
            // 
            // CapturarImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomeDaImagem);
            this.Controls.Add(this.txtNomeDaImagem);
            this.Controls.Add(this.BtnCaptureImagem);
            this.Controls.Add(this.BtnStopCam);
            this.Controls.Add(this.BtnIniciarCamera);
            this.Controls.Add(this.lblEscolherCam);
            this.Controls.Add(this.comboBoxCameras);
            this.Controls.Add(this.pictureBoxImageCamCaptured);
            this.Controls.Add(this.pictureBoxImageCam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapturarImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCam - Captura de Imagem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapturarImagem_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageCamCaptured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImageCam;
        private System.Windows.Forms.PictureBox pictureBoxImageCamCaptured;
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.Label lblEscolherCam;
        private System.Windows.Forms.Button BtnIniciarCamera;
        private System.Windows.Forms.Button BtnStopCam;
        private System.Windows.Forms.Button BtnCaptureImagem;
        private System.Windows.Forms.TextBox txtNomeDaImagem;
        private System.Windows.Forms.Label lblNomeDaImagem;
        private System.Windows.Forms.Label label1;
    }
}