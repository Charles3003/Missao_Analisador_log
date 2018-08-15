using System;
using Analisador_Log_Negocio.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Analisador_Unit
{
    [TestClass]
    public class Unit_Inserir
    {
        [TestMethod]
        public void Testar_Metodo()
        {
            Game_Grid_BD oGame = new Game_Grid_BD();
            oGame.Nome_Game = "Game 1";
            oGame.Total_Morte = 1;

            SG_Game_NG.Game.Inserir(oGame);
        }
    }
}
