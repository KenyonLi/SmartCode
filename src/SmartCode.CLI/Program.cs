﻿using System;
using System.Threading.Tasks;
using SmartCode.Utilities;
using SmartCode.App;

namespace SmartCode.CLI
{
    class Program
    {
        /// <summary>
        /// 默认配置文件路径
        /// </summary>
        static string DEFAULT_CONFIG_PATH = AppPath.Relative("SmartCode.yml");

        static async Task Main(string[] args)
        {
            var configPath = String.Empty;
            if (args.Length > 0)
            {
                configPath = args[0];
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------ SmartCode Build Start! --------------");

            if (String.IsNullOrEmpty(configPath))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pleace Please enter the path to build configuration file:");
                configPath = Console.ReadLine();
                if (String.IsNullOrEmpty(configPath))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("------- Not Find ConfigPath Arg! -------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"------- Use default config :{DEFAULT_CONFIG_PATH}! -------");
                    configPath = DEFAULT_CONFIG_PATH;
                }
            }
            SmartCodeApp app = new SmartCodeApp(configPath);
            await app.Run();
            Console.ReadLine();
        }
    }
}
