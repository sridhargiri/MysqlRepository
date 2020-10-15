using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiDeploy.Model;

namespace WebapiDeploy.Repository
{
    public interface IPlayerRepository
    {
        int Add(Player player);
        PlayerCollection GetPlayers();
        void Update(Player player);
        PlayerCollection GetPlayerById(int pid);
    }
}
