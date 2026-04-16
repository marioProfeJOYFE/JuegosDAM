using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDAM.MVVM.Model
{
    internal class Game
    {

        public int id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public List<string> genres { get; set; }


        public Game(int id, string title, string description, List<string> genres)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.genres = genres;
        }

        public Game(int id, string title, string description)
        {
            List<string> genres = new List<string>();
            genres.Add("Accion");
            this.id = id;
            this.title = title;
            this.description = description;
            this.genres = genres;
        }


    }
}
