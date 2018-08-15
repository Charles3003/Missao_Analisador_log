using Analisador_Log_Negocio.Edmx;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Analisador_Log_Negocio.Negocio
{
    public class Player_NG
    {

        #region Pesquisar


        public List<Player_Grid_BD> Pesquisar_Game()
        {
            string sqlA = "Select * FROM TB_PLAYER";

            using (var conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=BD_GAME;integrated security=True;MultipleActiveResultSets=True"))
            {
                var cmd = new SqlCommand(sqlA, conn);
                List<Player_Grid_BD> dados = new List<Player_Grid_BD>();
                Player_Grid_BD p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            p = new Player_Grid_BD();
                            p.Codigo = Convert.ToInt16(reader["CD_PLAYER"]);
                            p.Nome = reader["NM_PLAYER"].ToString();
                            dados.Add(p);
                        }
                    }
                }
                finally
                {
                    conn.Close();
                }
                return dados;
            }
        }


        #endregion


        #region Inserir


        public void Inserir(BD_GAMEEntities oBD, Player_Grid_BD pPlayer_BD)
        {
            Player_BD oPlayer = new Player_BD();
            oPlayer.Nome_Player = pPlayer_BD.Nome;
            oPlayer.Codigo_Game = pPlayer_BD.Codigo_Game;

            oBD.Player_BD.Add(oPlayer);
            oBD.SaveChanges();
        } 


        #endregion
    }
    public class Player_Grid_BD
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public short Codigo_Game { get; set; }
    }
}
