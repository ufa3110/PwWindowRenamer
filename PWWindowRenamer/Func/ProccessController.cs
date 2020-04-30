using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PWWindowRenamer.Func
{
    public class ProccessController
    {
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        public Task Start(string cilentFullPath, String WindowTitle)
        {
            var path = cilentFullPath.Substring(0, cilentFullPath.LastIndexOf(".exe")+4);
            var argsStart = cilentFullPath.LastIndexOf(".exe") +4;
            var args = cilentFullPath.Substring(argsStart);

            var processInfo = new ProcessStartInfo(path, args);
            processInfo.WorkingDirectory = cilentFullPath.Substring(0, cilentFullPath.LastIndexOf("//"));
            var startedProcess = Process.Start(processInfo);
            while (startedProcess.MainWindowHandle ==  (IntPtr) 0)
            {
                Task.Delay(1000);
            }
            SetWindowText(startedProcess.MainWindowHandle, WindowTitle);
            return Task.CompletedTask;
        }

    }
}
