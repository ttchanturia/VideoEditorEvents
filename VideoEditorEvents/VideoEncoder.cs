using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VideoEditorEvents
{
    class VideoEncoder
    {

        //public delegate void VideEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideEncodedEventHandler VideoEncoded;

        //OR simply

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}
