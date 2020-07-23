using System.Reflection;

namespace PracticeLesson
{
    public class Story
    {
        private string title;
        private string body;
        private string visualStyle;

        public string GetTitle()
        {
            return this.title;
        }

        public string GetBody()
        {
            return this.body;
        }

        public string GetVisualStyle()
        {
            return this.visualStyle;
        }

        public string SetVisualStyle(string text)
        {
            return text;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Title: {this.title} Body: {this.body} Style: {this.visualStyle} ";
        }
    }
}