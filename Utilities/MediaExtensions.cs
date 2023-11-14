using System;

namespace HalcyonCore.Utilities
{
    public static class MediaExtensions
    {
        public static System.Media.SoundPlayer MusicPlayer(this String url)
        {
            using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
            {
                player.SoundLocation = url;
                return player;
            }
        }

        public static System.Media.SoundPlayer MusicPlayerFromResource(this String ResUrl)
        {
            System.Reflection.Assembly assem = System.Reflection.Assembly.GetExecutingAssembly();
            using (System.IO.Stream result = assem.GetManifestResourceStream(ResUrl))
            {
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(result))
                {

                    return player;
                }
            }
        }
    }
}
