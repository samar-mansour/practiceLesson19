using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson
{
    internal class GossipTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            story.SetTitle(story.GetTitle());
            story.SetBody(story.GetBody());
            story.SetVisualStyle(story.GetVisualStyle());
        }
    }
}

