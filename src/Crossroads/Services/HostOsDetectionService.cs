using System;
using System.Runtime.InteropServices;

namespace Crossroads.Services
{
    public class HostOsDetectionService : IHostOsDetectionService
    {
        public string GetTargetOsRid()
        {
            return  RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? TargetOsOption.Linux :
                              (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? TargetOsOption.Windows :
                             throw new ArgumentException($"Couldn't detect host OS"));
        }
    }
}
