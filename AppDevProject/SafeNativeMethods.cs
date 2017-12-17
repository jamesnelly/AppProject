using System;

namespace AppDevProject
{
    internal class SafeNativeMethods
    {
        internal static void QueryPerformanceCounter(out long timestamp)
        {
            throw new NotImplementedException();
        }

        internal static bool QueryPerformanceFrequency(out long frequency)
        {
            throw new NotImplementedException();
        }
    }
}