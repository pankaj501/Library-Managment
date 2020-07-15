using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup11
{
   static class Library
   {
        public static List<Media> media = new List<Media>();
        public static List<LibraryMember> member = new List<LibraryMember>();
        public static void AddData()
        {
            media.Add(new Book(100,"Harry potter","Book"));
            media.Add(new Book(150,"Cinderella","Book"));
            media.Add(new Book(200,"Frozen","book"));
            media.Add(new Book(90,"Sherlock Homes","book"));
            media.Add(new Book(145,"two States","Book"));

            media.Add(new Magazine(50, "Times of India", "Magazine"));
            media.Add(new Magazine(40, "NewYork Times", "Magazine"));
            media.Add(new Magazine(60, "Bollywood Talkies", "Magazine"));
            media.Add(new Magazine(80, "Gossip", "Magazine"));
            media.Add(new Magazine(45, "Trending Cars", "Magazine"));

            media.Add(new Movie(60.00,"Life of PI","Movie"));
            media.Add(new Movie(55.46, "Dhakka", "Movie"));
            media.Add(new Movie(45.00, "Now You See Me", "Movie"));
            media.Add(new Movie(70.00, "How to train your Dragon", "Movie"));
            media.Add(new Movie(80.00, "Moana", "Movie"));

            member.Add(new LibraryMember("pankaj Bandhan"));
            member.Add(new LibraryMember("Shaun Paul"));
            member.Add(new LibraryMember("Rowdy Rathore"));
            member.Add(new LibraryMember("Arjit Singh"));
            member.Add(new LibraryMember("Honey Singh"));



        }
    }
}
