using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    public static class GetRequests
    {
        /// <summary>
        /// Get player with TAG (something like "Y99YRPYG") 
        /// </summary>
        /// <param name="tag">Player's ingame tag (something like "Y99YRPYG")</param>
        /// <returns></returns>
        public static Player GetPlayer(this API API, string tag)
        {
            return API.Parse<Player>(API.Get(EndPoints.Player, tag));
        }

        /// <summary>
        /// Get clan from CR API
        /// </summary>
        /// <param name="tag">TAG of clan (something like "22Y802")</param>
        /// <returns></returns>
        public static Clan GetClan(this API API, string tag)
        {
            return API.Parse<Clan>(API.Get(EndPoints.Clan, tag));
        }

    }
}
