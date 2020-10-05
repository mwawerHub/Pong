using NAudio.Wave;

namespace Pong.Audio
{
    public class LoopStream : WaveStream
    {
        private WaveStream sourceStream;

        public bool EnableLooping { get; set; }

        public LoopStream(WaveStream sourceStream) {
            this.sourceStream = sourceStream;
            EnableLooping = true;
        }

        public override WaveFormat WaveFormat
        {
            get { return sourceStream.WaveFormat; }
        }

        public override long Length
        {
            get { return sourceStream.Length; }
        }

        public override long Position
        {
            get { return sourceStream.Position; }
            set { sourceStream.Position = value; }
        }

        public override int Read(byte[] buffer, int offset, int count) {
            int totalBytesRead = 0;

            while (totalBytesRead < count) {
                int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
                if (bytesRead == 0) {
                    if (sourceStream.Position == 0 || !EnableLooping) {
                        break;
                    }
                    sourceStream.Position = 0;
                }
                totalBytesRead += bytesRead;
            }
            return totalBytesRead;
        }
    }
}