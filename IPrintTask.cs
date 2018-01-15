namespace solid_demo
{
    interface IPrintTask
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }
    interface IFaxContent
    {
        bool FaxContent(string content);
    }
    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
