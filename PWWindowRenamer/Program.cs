namespace PWWindowRenamer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //E://Games//Games//1.4.6 Classic NEW//element//elementclient.exe user:asd adddd=2
            var clientPath = (args.Length > 0) ? args[0] : "E://Games//Games//1.4.6 Classic NEW//element//elementclient.exe user:asd adddd=2";
            var title = (args.Length > 1) ? args[1] : "123";
            var processService = new Func.ProccessController();
            processService.Start(clientPath, title);
        }
    }
}
