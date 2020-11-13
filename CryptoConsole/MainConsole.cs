using System;
using CryptographicAlgs;

namespace CrConsole
{
    class MainConsole
    {
        static public string[] HelpList =
        {
            "ROT13 [message: string]\n", 
            "Caesar [message: string] [key: int]\n",
            "YuPie [message: string]\n"
        };

        static public void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("HELP: <command> [arg1: type] [arg2: type] ... [argN: type]");
                foreach (string Message in HelpList)
                    Console.Write(Message);
            }
            else
            {
                switch (args[0])
                {
                    case "ROT13":
                        if (args.Length < 2)
                            Console.WriteLine(HelpList[0]);
                        else
                            Console.WriteLine(SubstitutionAlgs.ROT13(args[1]));
                        break;
                    case "Caesar":
                        if (args.Length < 2)
                            Console.WriteLine(HelpList[1]);
                        else if (args.Length == 2)
                            Console.WriteLine(SubstitutionAlgs.Caesar(args[1], 3));
                        else
                            Console.WriteLine(SubstitutionAlgs.Caesar(args[1], Convert.ToInt32(args[2])));
                        break;
                    case "YuPie":
                        if (args.Length < 2)
                            Console.WriteLine(HelpList[2]);
                        else
                            Console.WriteLine(SAF.YuPieEncrypt(args[1]));
                        break;
                    default:
                        Console.WriteLine("HELP: <command> [arg1: type] [arg2: type] ... [argN: type]");
                        foreach (string Message in HelpList)
                            Console.Write(Message);
                        break;
                }
            }
        }
    }
}
