using System;
using System.IO;
using System.Reflection;
using NAudio.Wave;

namespace Pong.Behavior
{
    public class BackgroundMusic
    {
        private static readonly string ExecutablePath =
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase.Remove(0, 8));

        public string SongToPlay { get; set; }

        public BackgroundMusic()
        {
            SongToPlay = ExecutablePath + "\\Sounds\\backgroundMusic.wav";
        }

        public void Play()
        {
            var waveReader = new WaveFileReader(SongToPlay);
            var output = new DirectSoundOut();
            output.Init(new WaveChannel32(waveReader));
            output.Play();
        }
    }
}

