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
        public string currentSongFilePath { get; private set; }



    }
}
