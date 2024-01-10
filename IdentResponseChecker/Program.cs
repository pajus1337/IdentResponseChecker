namespace IdentResponseChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beta Version Test : ");
            IdentChecker identChecker = new IdentChecker("127.0.0.1",113);
            Console.WriteLine(identChecker.TryGetIdentResponse());
        }
    }
}
