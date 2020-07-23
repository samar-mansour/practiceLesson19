using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson
{
    internal class HealthTeam: NewsTeam
    {
        internal override void AddStyle()
        {
            string text = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(story.GetVisualStyle());
            Console.WriteLine(story.SetVisualStyle(text));
        }

        internal override void CreateStory()
        {
            Console.WriteLine(story.GetTitle());
            Console.WriteLine(story.GetBody());
            Console.WriteLine(story.GetVisualStyle());
        }
    }
}
