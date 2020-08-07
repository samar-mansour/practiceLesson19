using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson
{
    internal class PoliticsTeam : NewsTeam
    {
        internal override void AddStyle()
        {
            string text = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(story.GetVisualStyle());
            story.SetVisualStyle(text);
        }

        internal override void CreateStory()
        {
            story.SetTitle(story.GetTitle());
            story.SetBody(story.GetBody());

        }
    }
}
