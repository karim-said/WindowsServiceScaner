using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceScaner
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override async void OnStart(string[] args)
        {
            while (true)
            {
                File.AppendAllText(@"C:\Users\Karim\OneDrive\Desktop\File.txt","I work on system");
                await Task.Delay(300);
            }
        }
 
    }
}
