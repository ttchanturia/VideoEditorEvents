using System;

namespace VideoEditorEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Movie1" };
            VideoEncoder videoEncoder = new VideoEncoder();
            MailService mailService = new MailService();
            MessageService messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
