using  System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Learn
{
    //wordDoc
    public class WordDoc: DocumentProcessor, IExportable, IPrintable
    {
        public Metadata metaData {get; set;}

        public WordDoc(string title, Metadata metaData): base(title)
        {
            this.metaData = metaData;
        }
        public void Export(string path)
        {
            File.WriteAllText(path, string.Join("\n", Pages));
            Console.WriteLine($"File successfully exported: {path}");
        }
        public override void Print()
        {
            Console.WriteLine($"-------{Title}------");
            foreach (var item in Pages)
            {
                Console.WriteLine($"{item}");
            }
            metaData.Display();
        }
        public int[] wordCountsPerPage()
        {
            return Pages.Select(p => p.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length).ToArray();
        }

    }    
}