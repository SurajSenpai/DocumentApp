// 2. **Document Processor**
//     - Abstract `Document` class with `Print()`, `Save()`.
//     - Derived: `WordDoc`, `PDFDoc`, `ExcelDoc`.

using System;

namespace Learn
{
    public class MenuOperation
    {

        public void Menu()
        {
            System.Console.WriteLine("\nDOcument Processor");
            string[] options = new string[] {"\n1 > WordDoc", "2 > PDFDoc", "3 > ExcelDOc", "4 > Exit"};     
                
            foreach(string menuItems in options)
            {
                System.Console.WriteLine(menuItems);
            }
            
            System.Console.Write("\nEnter your choice: ");
            int userInput = Validator.StringToIntValidator(Console.ReadLine());
            MenuOptions(userInput);
        }
        public void MenuOptions(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    (string wordTitle, string wordAuthor) = Details();
                    Metadata metaData = new Metadata(wordAuthor);

                    DocumentProcessor wordDoc = DocumentFactory.CreateDocument("word", wordTitle, wordAuthor);

                    string wordContent = ContentBody();
                    wordDoc.AddPage(wordContent);
                    wordDoc.Print();

                    if(wordDoc is IExportable exportableWordDOC)
                    {
                        exportableWordDOC.Export($"{wordTitle}.txt");
                    }
                    break;

                case 2:
                    (string pdfTitle, string pdfAuthor) = Details();
                    Metadata metaDataa = new Metadata(pdfAuthor);
                    DocumentProcessor doc = DocumentFactory.CreateDocument("pdf",pdfTitle, pdfAuthor);

                    string pdfContent = ContentBody();
                    doc.AddPage(pdfContent);
                    doc.Print();

                    if(doc is IExportable exportablePdf)
                    {
                        exportablePdf.Export($"{pdfTitle}.txt");
                    }

                break;

                case 3:
                    (string excelTitle, string excelAuthor) = Details();
                    Metadata metaDataE = new Metadata(excelAuthor);
                    DocumentProcessor excelDoc = DocumentFactory.CreateDocument("excel", excelTitle, excelAuthor);

                    // string excelContent = ContentBody();
                    if (excelDoc is ExcelDoc typedExcel)
                    {
                        Console.Write($"Enter number of rows: ");
                        int rows = Validator.StringToIntValidator(Console.ReadLine());

                        Console.Write($"Enter number of columns: ");
                        int columns = Validator.StringToIntValidator(Console.ReadLine());

                        for(int i = 0; i < rows; i++)
                        {
                            List<string> row = new List<string>();

                            for(int j = 0; j < columns; j++)
                            {
                                Console.Write($"Enter value for ({i} {j}): ");
                                string cellValue = Validator.StringValidator(Console.ReadLine());

                                row.Add(cellValue);
                            }
                            typedExcel.Tabledata.Add(row);
                        }
                        typedExcel.Print();
                    } 
                    if(excelDoc is IExportable exportableExcelDoc)
                    {
                        exportableExcelDoc.Export($"{excelTitle}.csv");
                    }
                break;

                case 4:
                    Console.WriteLine($"Exitting Program");
                    Environment.Exit(0);

                break;

                default:
                    Console.WriteLine($"Select between 1 - 4!");
                break;
            }
        }
        //method for taking data from user
        public (string title, string author) Details()
        {
            Console.Write($"Enter title: ");
            string title = Validator.StringValidator(Console.ReadLine());

            Console.Write($"Enter author: ");
            string author = Validator.StringValidator(Console.ReadLine());
            
            return(title, author);
        }
        // method for taking content from the user
        public string ContentBody()
        {
            Console.Write($"Write content \nEnter:");
            string content = Validator.StringValidator(Console.ReadLine());

            return content;
        }
    }  
            
}
