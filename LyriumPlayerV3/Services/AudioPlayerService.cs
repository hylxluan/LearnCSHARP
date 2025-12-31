using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;


namespace LyriumPlayerV3.Services
{
    internal class AudioPlayerService
    {
        public bool isPlaying { get; private set; }
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        public string MusicaAtual { get; private set; }


        public AudioPlayerService()
        {
            isPlaying = false;
            MusicaAtual = string.Empty;
        }

        public void TocarFilaReproducao(string songFilePath)
        {
            try 
            {
                waveOutDevice = new WaveOutEvent();
                audioFileReader = new AudioFileReader(songFilePath);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                isPlaying = true;
                MusicaAtual = songFilePath;

            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo de áudio: " + ex.Message);
            }

        }

    }
}
