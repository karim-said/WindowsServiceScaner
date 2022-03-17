using System;
using System.IO;
using System.Timers;
using System.ServiceProcess;


namespace Service_3
{
    public partial class Service1 : ServiceBase
    {
        private readonly Timer _timer;
        public Service1()
        {
            InitializeComponent();
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }    

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };

            File.AppendAllLines(@"C:\Users\Karim\OneDrive\Desktop\File.txt", lines);
        }

        protected override void OnStart(string[] args)
        {
            _timer.Start();
        }

        protected override void OnStop()
        {
            _timer.Stop();
        }
    }
}
