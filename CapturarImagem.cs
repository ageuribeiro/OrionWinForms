using AForge.Video;
using AForge.Video.DirectShow;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrionWinForms;

namespace OrionWinForms
{
    public partial class CapturarImagem : Form
    {
        //Declara variaveis
        FilterInfoCollection _filterInfoCollection;
        VideoCaptureDevice _videoCaptureDevice;

        public CapturarImagem()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Busca todas as cameras que estão conectadas ao computador
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //Percorre a lista de cameras encontrada e associa ao combobox. e pega apenas a propriedade nome para mostrar no combobox
            foreach (FilterInfo filterInfo in _filterInfoCollection) comboBoxCameras.Items.Add(filterInfo.Name);

            //Lista todas as cameras encontradas 
            comboBoxCameras.SelectedIndex = 0;
            _videoCaptureDevice = new VideoCaptureDevice();
        }

        private void BtnIniciarCamera_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[comboBoxCameras.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            pictureBoxImageCam.Image = (Bitmap)e.Frame.Clone();
        }

        private void BtnCaptureImagem_Click(object sender, EventArgs e)
        {
            //Verifica o nome da imagem e cria o diretório com o nome da imagem
            VerificarNomeDaImagem();
            try
            {
                //Limpar a area de transferência
                Clipboard.Clear();

                //Copia a imagem para a área de tranferência
                Clipboard.SetImage(pictureBoxImageCam.Image);
                pictureBoxImageCamCaptured.Image = Clipboard.GetImage();

                //Limpa a area de tranferencia
                Clipboard.Clear();
                var nomeDoMembro = txtNomeDaImagem.Text;
                var path = @"c:\AppOrion\Dados\Membros\" + nomeDoMembro + "\\"+nomeDoMembro+".jpg";
                using (Bitmap bmb = (Bitmap)pictureBoxImageCam.Image.Clone())
                {
                    bmb.Save(path, bmb.RawFormat);
                }
                   

                MessageBox.Show("Captura executada com sucesso!", "Captura de Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro na captura da Imagem",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
            
        }

        private bool VerificarNomeDaImagem()
        {
            //Verifica se o campo de nome da imagem está preenchido
            if (txtNomeDaImagem.Text == "")
            {
                //Se o campo nome da imagem estive em branco solicita ao usuário que preencha o campo
                MessageBox.Show("Digite o nome da Imagem antes de Salvar");
                txtNomeDaImagem.Focus();
                return false;
            }
            return true;
        }

        private void BtnStopCam_Click(object sender, EventArgs e)
        {
            Finalizar();
        }

        private void CapturarImagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Finalizar();
        }
        private void Finalizar()
        {
            if (!(_videoCaptureDevice == null))
                if (_videoCaptureDevice.IsRunning)
                {
                    _videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                    _videoCaptureDevice.SignalToStop();
                    _videoCaptureDevice = null;
                }
     
        }


    }
}
