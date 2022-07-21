using System.Linq;

var videoGames = new List<string>() { "call of duty", "halo", "gta", "forza", "rocket league", "fortnite" };

videoGames.OrderBy(x => x.Length)
          .ToList()
          .ForEach(x => Console.WriteLine(x));





