using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
   public class PlayerList
    {
        public static List<FootballPlayers> Players = new List<FootballPlayers>()
        {
            new FootballPlayers {Name = "Lionel Messi", Country = "Argentina", Matches = 142, Goals = 71, Assists = 47, Picture = "Messi.jpg" },
            new FootballPlayers {Name = "Cristiano Ronaldo", Country = "Portugal", Matches = 170, Goals = 102, Assists=30, Picture = "Cristiano_Ronaldo.jpg"},
            new FootballPlayers {Name ="Zlatan Ibrahimovic" , Country= "Sweden", Matches = 116, Goals = 62, Assists =12, Picture = "ibrahimovic.jpg" },
            new FootballPlayers {Name = "Andre Iniesta", Country="Spain" , Matches =96, Goals =12 , Assists =9, Picture = "Iniesta.jpg"},
            new FootballPlayers {Name ="Neymar Jr" , Country= "Brazil", Matches = 103, Goals =64 , Assists =43, Picture = "neymar.jpg"},
            new FootballPlayers {Name ="Mesut Ozil" , Country="Germany" , Matches =92,  Goals =23 , Assists =40, Picture = "ozil.jpg"},
            new FootballPlayers {Name ="Robin Van Persie" , Country="Netherlands" , Matches =102, Goals = 50, Assists =19, Picture = "Robin.jpg"},
            new FootballPlayers {Name ="Thiago Silva" , Country="Brazil" , Matches =93, Goals =7 , Assists =3, Picture = "Silva.jpg"},
            new FootballPlayers {Name ="Xavi" , Country="Spain" , Matches =133, Goals =12 , Assists =24, Picture = "Xavi.jpg"},
            new FootballPlayers {Name = "Sergio Ramos" , Country= "Spain", Matches =178, Goals =23 , Assists = 7, Picture = "ramos.jpg"}
        };
    }

    public class FootballPlayers
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Matches { get; set; }
        public string Picture { get; set; }
        public int Sequence { get; set; }
    }
}
