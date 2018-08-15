using Analisador_Log_Negocio.Edmx;
using Analisador_Log_Negocio.Negocio;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Log_Listar.Model
{
    public class Carregar_Componente
    {

        public static void Carregar_Game(BD_GAMEEntities pBD, LookUpEdit pLue)
        {
            List<Game_Grid_BD> oLista = SG_Game_NG.Game.Pesquisar_Game();

            pLue.Properties.DataSource = oLista;
        }
        public static void Carregar_Player(BD_GAMEEntities pBD, LookUpEdit pLue)
        {
            List<Player_Grid_BD> oLista = SG_Game_NG.Player.Pesquisar_Game();

            pLue.Properties.DataSource = oLista;
        }
    }
}
