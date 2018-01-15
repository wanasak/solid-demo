using System;

namespace solid_demo.Client
{
    public class CannonMG2470 : IPrintTask
    {
        public bool FaxContent(string content)
        {
            return false;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Photo Copy Done"); return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }

        public bool PrintDuplexContent(string content)
        {
            return false;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }
}