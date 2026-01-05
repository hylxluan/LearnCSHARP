using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace LyriumPlayerV3.Services
{
    internal class AudioPlayerService
    {
        public bool IsPlaying { get; private set; }
        public string MusicaAtual { get; private set; }

        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        


        public AudioPlayerService()
        {
            IsPlaying = false;
            MusicaAtual = string.Empty;
        }

        public void TocarReproducao(string songFilePath)
        {
            try 
            {
                PararReproducao();
                waveOutDevice = new WaveOutEvent();
                audioFileReader = new AudioFileReader(songFilePath);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                IsPlaying = true;
                MusicaAtual = songFilePath;

            } catch (Exception ex)
            {
                throw new Exception($"Erro ao tocar música: {ex.Message}", ex);
            }
        }

        public void PararReproducao()
        {
            if (waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }

            IsPlaying = false;
            MusicaAtual = string.Empty;
        }


        public void PausarReproducao()
        {
            if (waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                waveOutDevice.Pause();
                IsPlaying = false;
            }
        }

        public void RetomarReproducao()
        {
            if (IsPlaying == false && waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Paused)
            {
                waveOutDevice.Play();
                IsPlaying = true;
            }
        }
    }
}
