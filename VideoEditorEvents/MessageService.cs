using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEditorEvents
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message...");
        }
    }
}
