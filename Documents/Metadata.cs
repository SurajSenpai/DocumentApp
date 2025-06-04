using System;

namespace Learn
{
    public class Metadata
    {
        private string _author;
        private DateTime _createdDate;

        public string Author
        {
            get => _author;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Field cant be null or empty!");
                }
                _author = value;
            }
        }
        public DateTime CreatedDate => _createdDate;

        public Metadata(string author)
        {
            this.Author = author;
            _createdDate = DateTime.Now;
        }
        
        public void Display()
        {
            Console.WriteLine($"Author: {Author} | Created Date: {_createdDate: MM/dd/yyyy h:mm tt}");
        }
    }
}