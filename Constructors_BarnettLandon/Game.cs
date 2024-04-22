using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_BarnettLandon
{
    internal class Game
    {

        public string title, genre;
        //Sets default params 
        public Game(string titleParam = "Unkown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }
    }
}
