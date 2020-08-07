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
            int count = 0;
            
            for (int i = 0; i < newspaper.GetStories().Length; i++)
            {
                if (newspaper.GetStories()[i] != null)
                {
                    count += newspaper.GetStories()[i].GetBody().Length;
                    count += newspaper.GetStories()[i].GetTitle().Length;
                }
            }
            return count;
        }
    }
}
