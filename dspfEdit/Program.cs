using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using dspfEdit;

namespace dspfEdit
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = String.Join(" ", args);

            Editor editor;

            if (File.Exists(Path))
            {
                Console.WriteLine("Loading file: " + Path);
                DisplayParse parser = new DisplayParse();
                parser.ParseFile(Path);
                editor = new Editor(parser.GetRecordFormats(), Path);
            }
            else
            {
                Console.WriteLine("No file loaded.");
                editor = new Editor();
            }

            editor.ShowDialog();
        }
    }
}
