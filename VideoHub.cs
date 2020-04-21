using Ghost;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace VideoPlayer
{
    public class VideoHub : HubBase
    {
        public MediaElement Media { get; private set; }
        
        public VideoHub()
        {
            Media = new MediaElement();
            Media.LoadedBehavior = MediaState.Manual;
            Media.UnloadedBehavior = MediaState.Manual;
            Media.MediaEnded += MediaElement_MediaEnded;
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            this.Client.playCompleted();
        }

        public void Play(string url)
        {
            if (!String.IsNullOrEmpty(url))
            {
                this.Media.Source = new Uri(url);
            }
            this.Media.Play();
        }

        public void Pause()
        {
            this.Media.Pause();
        }

        public void Stop()
        {
            this.Media.Stop();
        }
    }
}
