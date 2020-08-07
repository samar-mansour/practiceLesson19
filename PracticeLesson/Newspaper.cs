using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson
{
    public class Newspaper
    {
        private static int maxArray = 3;
        private Story[] stories = new Story[maxArray];
        private float price;

        public Story[] GetStories()
        {
            return this.stories;
        }

        public void SetStories(Story[] story)
        {
            for (int i = 0; i < story.Length; i++)
            {
                Console.WriteLine(story[i]);
            }
        }

        public float GetPrice()
        {
            return this.price;
        }

        public void SetPrice(float num)
        {
            if (num <= 0)
            {
                this.price = num;
            }
        }
        public Newspaper(float price, Story[] story)
        {
            this.price = price;
            this.stories = story;


        }

        public void Read()
        {
            foreach (var item in stories)
            {
                Console.WriteLine(item.GetBody());
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.GetPrice()} {this.Read()}";
        }
    }
}
