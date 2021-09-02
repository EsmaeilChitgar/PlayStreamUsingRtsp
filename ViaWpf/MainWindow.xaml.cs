using AxAXVLC;
using System.Windows;

namespace ViaWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AxVLCPlugin2 vlc;

        public MainWindow()
        {
            InitializeComponent();

            vlc = new AxVLCPlugin2();
            windowsFormsHost.Child = vlc;
        }

        private void btnPlayLocalFile_Click(object sender, RoutedEventArgs e)
        {
            string localFile = @"file:///C:\MyVideo.mp4";
            int id = vlc.playlist.add(localFile);
            vlc.playlist.playItem(id);
        }

        private void btnPlayRtspStream_Click(object sender, RoutedEventArgs e)
        {
            //camera rtsp template
            string url = "rtsp://root:root@192.168.1.100/axis-media/media.amp?videocodec=h264&resolution=800x450&fps=8&compression=50";

            


            //'Rtsp camera server' app
            
            //rtsp template 
            url = "rtsp://192.168.43.1:5554/playlist.m3u";
            
            //rtsp template 
            url = "http://192.168.43.1:8080/playlist.m3u";






            //some online rtsp templates
            url = "rtsp://demo:demo@ipvmdemo.dyndns.org:5541/onvif-media/media.amp?profile=profile_1_h264&sessiontimeout=60&streamtype=unicast";
            url = "rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov";


            int id = vlc.playlist.add(url);
            vlc.playlist.playItem(id);
        }
    }
}
