﻿using System;
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
            Console.WriteLine();
        }

        internal override void CreateStory()
        {
            Console.WriteLine(story.GetTitle());
            Console.WriteLine(story.GetBody());

        }
    }
}