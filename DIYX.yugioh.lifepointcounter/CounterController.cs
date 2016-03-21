using DIYX.yugioh.lifepointcounter.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DIYX.yugioh.lifepointcounter
{
    static class CounterController
    {
        private static List<Player> Players = new List<Player>();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainCounterScreen());
        }

        public static void InitCounter(List<string> playerNames)
        {
            int iterator = 0;
            foreach (string PlayerName in playerNames)
            {
                Players.Add(new Player() { playerName = PlayerName, lifePoints = 8000, playerId = iterator });
                iterator++;
            }
        }

        public static int TakeDamage(int player, int amount)
        {
            return Players[player].lifePoints;
        }
    }
}
