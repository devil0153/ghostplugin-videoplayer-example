using Ghost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VideoPlayer
{
    public class VideoExtension : IEmbeddedViewExtension
    {
        public HubBase Hub { get; private set; }

        public bool IsClickThrough => true;

        public FrameworkElement GetView()
        {
            return ((VideoHub)this.Hub).Media;
        }

        public void Initialize(IExtensionConfig config)
        {
            this.Hub = new VideoHub();
        }
        
        public void OnConnected()
        {

        }

        public void OnDisconnect()
        {

        }

        public void Dispose()
        {
        }
    }
}
