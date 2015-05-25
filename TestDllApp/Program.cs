using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermRules;

namespace TestDllApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "TextA.txt";
            TermRules.Rules rules = new Rules(inputFile, DictionaryF.IT_TERM);
            rules.ApplyRules();
            Debug.WriteLine("MainTermsAr: {0}", rules.proc.MainTermsAr.TermsAr.Count);
        }
    }
}
