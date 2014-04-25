using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class VideoGame
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Awesomeness { get; set; }
        public string Rating { get; set; }
        public string Code { get; set; }

        public VideoGame(string title, string genre, string code)
        {
            this.Title = title;
            this.Genre = genre;
            this.Code = code;
        }

        public void Play()
        {
            Console.WriteLine(this.Code);
        }
    }
}
