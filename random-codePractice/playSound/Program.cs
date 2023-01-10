using System;
using System.Media;  

namespace Program
{
    class PlayMusic
    {
        public static void Main(string[] args)
        {
            // Make an instance of the SoundPlayer Class
            SoundPlayer musicPlayer = new SoundPlayer();

            musicPlayer.SoundLocation  = AppDomain.CurrentDomain.BaseDirectory + ".\\Pixel_Music.mp3";
            musicPlayer.Play();
        }
    }
}