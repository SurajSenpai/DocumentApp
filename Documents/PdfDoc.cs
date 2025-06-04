using System;

namespace Learn
{
    public class PDFDoc: DocumentProcessor, IExportable, IPrintable
    {
        public Metadata MetaData { get; set; }        

        public PDFDoc(string title, Metadata metaData): base(title)
        {
            this.MetaData= metaData;
        }
        //file export meethod
        public void Export(string path)
        {
            File.WriteAllText(path, string.Join("\n", Pages));
            Console.WriteLine($"Document successfully exported: {path}");
        }
        //overiding base abastract class's method(in this system display/print is mandatory)
        public override void Print()
        {
            Console.WriteLine($"----------{Title}---------");
            foreach(var page in Pages)
            {
                Console.WriteLine($"{page}");
            }
            MetaData.Display();
        }
        public int[] wordCountsPerPage()
        {
            return Pages.Select(p => p.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length).ToArray();
        }
    }
}