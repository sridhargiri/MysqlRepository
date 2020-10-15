using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiDeploy.Model;

namespace WebapiDeploy.Repository
{
    public class PlayerRepository : IPlayerRepository
    {

        public int Add(Player player)
        {
            try
            {
                using (var context = new PlayerDbContext())
                {
                    context.Players.Add(player);
                    context.SaveChanges();
                }
                return player.PlayerID;
            }
            catch
            {

                throw;
            }
        }
        public PlayerCollection GetPlayers()
        {
            try
            {
                using (var context = new PlayerDbContext())
                {
                    PlayerCollection coll = new PlayerCollection();
                    coll.PlayerStats = context.Players.ToList();
                    return coll;
                }
            }
            catch
            {

                throw;
            }
        }
        public PlayerCollection GetPlayerById(int pid)
        {
            try
            {
                using (var context = new PlayerDbContext())
                {
                    PlayerCollection coll = new PlayerCollection();
                    coll.PlayerStats = context.Players.Where(x => x.PlayerID == pid).ToList();
                    return coll;
                }
            }
            catch
            {

                throw;
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (var context = new PlayerDbContext())
                {
                    var found = context.Players.Where(x => x.PlayerID == id).First();
                    if (found != null)
                    {
                        context.Players.Remove(found);
                        context.SaveChanges();
                    }
                }
            }
            catch
            {

                throw;
            }
        }
        public void Update(Player player)
        {
            try
            {
                using (var context = new PlayerDbContext())
                {
                    var found = context.Players.Where(x => x.PlayerID == player.PlayerID).First();
                    if (found != null)
                    {
                        found.Score = player.Score;
                        context.SaveChanges();
                    }
                }
            }
            catch
            {

                throw;
            }
        }

    }


}
