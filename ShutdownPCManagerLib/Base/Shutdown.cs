using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ShutdownPCManagerLib.Base
{
    internal class Shutdown
    {
        protected void Start()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("shutdown","/s /t 0");
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process.Start(processStartInfo);
        }
    }
}
