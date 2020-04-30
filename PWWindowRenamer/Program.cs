namespace PWWindowRenamer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var clientPath = (args.Length > 0) ? args[0] : "";
            var title = (args.Length > 1) ? args[1] : "";
            var processService = new Func.ProccessController();
            processService.Start(clientPath, title);
        }
    }
}
