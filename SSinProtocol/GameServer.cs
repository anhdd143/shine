using System;
using System.Collections.Generic;
using System.Net;

namespace PROProtocol
{
    public enum GameServer
    {
        Silver,
        Gold
    }

    public static class GameServerExtensions
    {
        private static readonly IPAddress ServerIp = IPAddress.Parse("167.172.74.176");

        public static IPEndPoint GetAddress(this GameServer server)
        {
            switch (server)
            {
                case GameServer.Silver:
                    return new IPEndPoint(ServerIp, 800);
                case GameServer.Gold:
                    return new IPEndPoint(ServerIp, 801);
            }
            return null;
        }

        public static GameServer FromName(string name)
        {
            switch (name.ToUpperInvariant())
            {
                case "SILVER":
                    return GameServer.Silver;
                case "GOLD":
                    return GameServer.Gold;
            }
            throw new Exception("The server " + name + " does not exist");
        }

        public static IPAddress GetMapAddress(this GameServer server)
        {
            return ServerIp;
        }
    }
}

