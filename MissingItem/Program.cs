using System;
using System.IO;

namespace MissingItem
{
    class Program
    {
        static string ServerDb;
        static string ItemInfo;
        static string OutFile;
        static void Main(string[] args)
        {
            if(args.Length < 2)
            {
                Log("Not enough arguments. Defaulting target files to item_db.txt, ItemInfo.lua");
                ServerDb = Path.Combine(Directory.GetCurrentDirectory(), "item_db.txt");
                ItemInfo = Path.Combine(Directory.GetCurrentDirectory(), "ItemInfo.lua");
            }else
            {
                ServerDb = Path.Combine(Directory.GetCurrentDirectory(), args[0]);
                ItemInfo = Path.Combine(Directory.GetCurrentDirectory(), args[1]);
            }
            if(args.Length < 3)
            {
                Log("Output file not specified. Defaulting to MissingItems.txt");
                OutFile = Path.Combine(Directory.GetCurrentDirectory(), "MissingItems.txt");
            }else
            {
                OutFile = Path.Combine(Directory.GetCurrentDirectory(), args[2]);
            }
            Log("Starting program..");
            new MissingItem(ServerDb, ItemInfo, OutFile).GenerateOutput();
        }

        static void Log(string arg) { Console.WriteLine("[*] " + arg);  }
    }
}
