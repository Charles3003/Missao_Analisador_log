using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Log_Negocio.Negocio
{
    public class SG_Game_NG
    {
        #region Variavel


        private static Game_NG _Game = null;
        private static Player_NG _Player = null;
        private static Morte_NG _Morte = null;


        #endregion


        #region Atributos


        public static Game_NG Game
        {
            get
            {
                if (_Game == null)
                    return new Game_NG();
                return _Game;

            }
        }

        public static Player_NG Player
        {
            get
            {
                if (_Player == null)
                    return new Player_NG();
                return _Player;

            }
        }

        public static Morte_NG Morte
        {
            get
            {
                if (_Morte == null)
                    return new Morte_NG();
                return _Morte;

            }
        }


        #endregion
    }
}
