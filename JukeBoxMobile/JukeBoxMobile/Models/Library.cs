using System;
using System.Collections.Generic;
using System.Text;

namespace JukeBoxMobile.Models
{
   public class Library
    {

        public string Name { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public LibraryDetail LibraryDetails { get; set; }


        public class MusicPair : Tuple<Library, Library>
        {
            public MusicPair(Library item1, Library item2)
                : base(item1, item2 ?? null) { }

            //    private static Person CreateEmptyModel()
            //    {
            //        return new Person { IsVisible = true };
            //    }
        }
    }
}
