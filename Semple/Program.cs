using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

//D:\Project\CSharp\WindowsServiceScaner\Semple\bin\Debug\HeartbeatService > Semple.exe install start
//D:\Project\CSharp\WindowsServiceScaner\Semple\bin\Debug\HeartbeatService > Semple.exe uninstall
namespace Semple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x=>
            {
                x.Service <Heartbeat>(s =>
                  {
                      s.ConstructUsing(heartbeat => new Heartbeat());
                      s.WhenStarted(heartbeat => heartbeat.Start());
                      s.WhenStopped(heartbeat => heartbeat.Stop());
                  });

                x.RunAsLocalSystem();

                x.SetServiceName("HeartbeatService");
                x.SetDisplayName("Heartbeat Service");
                x.SetDescription("This is th sample heartbeat service used in a Youtube demo. ");

            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
