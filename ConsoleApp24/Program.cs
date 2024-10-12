using ConsoleApp24;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter key: basic, pro, expert");
        string key = Console.ReadLine();

        DocumentProgram docProgram;

        if (key == "pro")
        {
            docProgram = new ProDocumentProgram();
        }
        else if (key == "expert")
        {
            docProgram = new ExpertDocument();
        }
        else
        {
            docProgram = new DocumentProgram();
        }

        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
    }
}