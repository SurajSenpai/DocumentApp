// 2. **Document Processor**
//     - Abstract `Document` class with `Print()`, `Save()`.
//     - Derived: `WordDoc`, `PDFDoc`, `ExcelDoc`.

using System;
using System.Collections.Generic;

namespace Learn
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuOperation menu = new MenuOperation();
            while (true)
            {
                menu.Menu();
            }            
        }
    }
}
        
