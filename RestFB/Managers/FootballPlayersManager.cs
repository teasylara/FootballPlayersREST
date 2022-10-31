using Assingment1_FootballPlayers;

namespace RestFB.Managers
{
    public class FootballPlayersManager
    {
        private static int _nextId = 1;
        public static List<FootballPlayer> players = new List<FootballPlayer>()
        {
            new FootballPlayer{ Id=_nextId++, Name="Ante", Age=28, ShirtNumber=13},
            new FootballPlayer{ Id=_nextId++, Name="Mate", Age=24, ShirtNumber=32},
            new FootballPlayer{ Id=_nextId++, Name="Jaksa", Age=22, ShirtNumber=13},
            new FootballPlayer{ Id=_nextId++, Name="Luka", Age=21, ShirtNumber=45}
        };

        public List<FootballPlayer> GetAll()
        {
            List<FootballPlayer> playerList = new List<FootballPlayer>(players);
            return playerList;
        }

        public FootballPlayer GetByID(int id)
        {
            return players.Find(p => p.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newPlayer)
        {
            newPlayer.Id = _nextId++;
            players.Add(newPlayer);
            return newPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer p = GetByID(id);
            if (id == null) return null;
            players.Remove(p);
            return p;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer p = GetByID(id);
            if (p == null) return null;
            p.Id = updates.Id;
            p.Name = updates.Name;
            p.ShirtNumber = updates.ShirtNumber;
            return p;
        }
    }
}
