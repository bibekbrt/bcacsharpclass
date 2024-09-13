using System;

namespace PublishSubs
{
    class Program
    {
        static void Main(string[] args)
        {
            Video objvideo = new Video("Learing c sharp tutorial");

            EmailServices email = new EmailServices();
            SMSService sms = new SMSService();

            objvideo.UploadVideo();

            objvideo.onVideoUploaded += email.SendEmail;
            objvideo.onVideoUploaded += sms.SendSms;





            Console.ReadKey();
        }
    }
}
