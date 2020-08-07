using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PracticeLesson
{
    abstract class NewsTeam
    {
        protected Story story;

        internal abstract void CreateStory();
        internal Story GetStory()
        {
            return this.story;
        }
        internal virtual void AddStyle()
        {
            string text = null;
            Console.WriteLine(story.SetVisualStyle(text));
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
