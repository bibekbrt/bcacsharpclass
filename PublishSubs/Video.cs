using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PublishSubs
{
    public delegate void OnVideoUploaded();
    public class Video
    {
        public event OnVideoUploaded onVideoUploaded;
        public string VideoName { get; set; }

        public Video(string videoName)
        {
            this.VideoName = videoName;
        }

        public void UploadVideo()
        {
            Console.WriteLine("uploading Videos");
            Thread.Sleep(9000);
            Console.WriteLine("Video uploaded");
            onVideoUploaded();//invoke
        }
    }
}
