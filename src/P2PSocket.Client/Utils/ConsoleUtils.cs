﻿using P2PSocket.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace P2PSocket.Client.Utils
{
    public static class ConsoleUtils
    {
        static ConsoleCore Instance { get; } = new ConsoleCore();
        public static void Show(LogLevel logLevel, string log)
        {
            if (LogUtils.Instance.LogLevel >= logLevel)
                Instance.WriteLine($"Client> {log}");
        }
    }
}
