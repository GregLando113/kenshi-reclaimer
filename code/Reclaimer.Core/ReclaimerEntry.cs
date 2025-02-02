﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using System.Reflection;
using Reclaimer.Shinobi;

namespace Reclaimer.Core
{
    public delegate void ReclaimerEntryFn();
    public static class ReclaimerEntry
    {

        public static void Install()
        {
            Console.WriteLine("Hello from .NET Install()");


            Shinobi.Memory.Resolver.Initialize();

        }
        public static void Initialize()
        {
            Console.WriteLine("Hello from .NET Initialize()");
        }

        public static void Shutdown()
        {
            Console.WriteLine("Hello from .NET Shutdown()");
        }

        public static void Uninstall()
        {
            Console.WriteLine("Hello from .NET Uninstall()");
        }
    }
}
