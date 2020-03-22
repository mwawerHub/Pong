using NAudio.Wave;
using Pong.Audio;
using System.IO;
using System.Reflection;

namespace Pong.Behavior
{
    public class BackgroundMusic
    {
        private static readonly string ExecutablePath =
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase.Remove(0, 8));

        public string SongToPlay { get; set; }

        public BackgroundMusic(){
            SongToPlay = ExecutablePath + "\\Sounds\\backgroundMusic.wav";
        }

        public void Play(){
            var reader = new WaveFileReader(SongToPlay);
            var MediaPlayer = new DirectSoundOut();
            var loop = new LoopStream(reader);
            MediaPlayer.Init(new WaveChannel32(loop));
            MediaPlayer.Play();
        }
    }
}

