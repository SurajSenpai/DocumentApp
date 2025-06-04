using System;
using System.Collections.Generic;

namespace Learn
{
    public abstract class DocumentProcessor
    {
        private string _title;
        private List<string> _pages = new List<string>();

        public string Title
        {
            get => _title;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Field can't be null nor empty!");
                }
                _title = value;
            }
        }
        //use IReadOnly when you want to make it only visible not editable on list
        //you add validation in methods, think it as private access modifier but can be visible
        public IReadOnlyList<string> Pages => _pages;


        public DocumentProcessor(string title)
        {
            this.Title = title;
        }

        public void AddPage(string content)
        {
            if(!string.IsNullOrWhiteSpace(content))
            {
                _pages.Add(content);
            }
            else
            {
                Console.WriteLine($"Page can't be empty or have white spaces!");
            }
        }
        public void RemovePage(int index)
        {
            if(index >= 0 && index < _pages.Count)
            {
                _pages.RemoveAt(index);
            }
            else
            {
                Console.WriteLine($"Invalid idex!");
            }
        }
        public void UpdatePage(int index, string newContent)
        {
            if(index >= 0 && index < _pages.Count && !string.IsNullOrWhiteSpace(newContent))
            {
                _pages[index] = newContent;
            }
            else
            {
                Console.WriteLine($"Invalid index or content!");
            }
        }
        //assigning abstract method//yo method chai derived/child class le override garnai garxa
        //print is necessary as data stored must be displayed so we assign it to base class
        public abstract void Print();
    }
}





// public abstract class DocumentProcessor
//     {
        
//         public abstract void Print();
//         public abstract void Save();
//     }