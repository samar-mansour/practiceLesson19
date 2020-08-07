using System;
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

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetBody()
        {
            return this.body;
        }

        public void SetBody(string body)
        {
            this.body = body;
        }

        public string GetVisualStyle()
        {
            return this.visualStyle;
        }

        public void SetVisualStyle(string text)
        {
            if (text is null)
            {
               Console.WriteLine("Empty");
            }
            this.title = text;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Title: {this.title} Body: {this.body} Style: {this.visualStyle} ";
        }
    }
}
