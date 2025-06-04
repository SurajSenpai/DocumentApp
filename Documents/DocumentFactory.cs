using System;
using System.Collections.Generic;

namespace Learn
{
    //factory pattern implemented for easier creation of multiple documents
    public static class DocumentFactory
    {
        public static DocumentProcessor CreateDocument(string type, string title, string author)
        {
            if(type.ToLower() == "pdf")
            {
                return new PDFDoc(title, new Metadata(author));
            }
            if(type.ToLower() == "word")
            {
                return new WordDoc(title, new Metadata(author));
            }
            if(type.ToLower() == "excel")
            {
                return new ExcelDoc(title, new Metadata(author));
            }

                Console.WriteLine($"Other documents are not implemented yet!");
                return null;
        }
    } 
    
}