using System;
using System.IO;

namespace Learn
{
    public interface IExportable
    {
        void Export(string path);
    }
    public interface IPrintable
    {
        void Print();
    }
}