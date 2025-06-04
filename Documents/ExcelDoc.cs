using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Learn
{
    public class ExcelDoc: DocumentProcessor, IExportable, IPrintable   
    {
        private Metadata _metaData;
        private List<List<string>> _tabledata = new List<List<string>>();

        public Metadata MetaData
        {
            get => _metaData;
            set
            {
                if(value == null)
                {
                    throw new ArgumentException($"{nameof(MetaData)} MetaData can't be null!");
                }
                _metaData = value;
            }
            
        }
        public List<List<string>> Tabledata
        {
            get => _tabledata;
            set
            {
                if(value == null || value.Count == 0)
                {
                    throw new ArgumentException("Table can't be null or empty!");
                }
                _tabledata = value;
            }
        }

        public ExcelDoc(string title, Metadata metaData): base(title) 
        {
            this.MetaData = metaData;
        }
        public void Export(string path)
        {
            var lines = Tabledata.Select(row => string.Join(",", row));
            File.WriteAllText(path, string.Join("\n", lines));
            Console.WriteLine($"File successfully exported {path}.csv");
        }
        public override void Print()
        {
            Console.WriteLine($"--------{Title}--------");
            
            foreach(var row in Tabledata)
            {
                Console.WriteLine($"{string.Join("\t", row)}");
            }
            MetaData.Display();
        }
    }
}