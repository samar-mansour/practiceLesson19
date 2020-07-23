using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson
{
    static class NewsPaperCalculator
    {
        internal static int CalcNumberOfChars(Newspaper newspaper)
        {
            return newspaper.GetStories().Length;
        }
    }
}
