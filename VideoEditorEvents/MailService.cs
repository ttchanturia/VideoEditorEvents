using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEditorEvents
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending a mail...");
        }
    }
}
