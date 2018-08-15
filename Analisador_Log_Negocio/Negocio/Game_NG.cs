using Analisador_Log_Negocio.Edmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Log_Negocio.Negocio
{
    public class Game_NG
    {

        #region Pesquisar


        public Game_Grid_BD Pesquisar_pelo_Codigo(int pCodigo)
        {
            using (var conn = new SqlConnection(@"data source=DESKTOP-OUCTPF0\SQLEXPRESS;initial catalog=BD_GAME;integrated security=True"))
            {
                string sql = "Select * FROM TB_GAME WHERE CD_GAME=@cod";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod", pCodigo);
                Game_Grid_BD oGame = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                oGame = new Game_Grid_BD();
                                oGame.Codigo = (int)reader["CD_GAME"];
                                oGame.Nome_Game = reader["NM_GAME"].ToString();
                            }
                        }
                    }
                }
                finally
                {
                    conn.Close();
                }
                return oGame;
            }
        }

        public List<Game_Grid_BD> Pesquisar_Game()
        {
            string sqlA = "Select * FROM TB_GAME";

            using (var conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=BD_GAME;integrated security=True;MultipleActiveResultSets=True"))
            {
                var cmd = new SqlCommand(sqlA, conn);
                List<Game_Grid_BD> dados = new List<Game_Grid_BD>();
                Game_Grid_BD p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            p = new Game_Grid_BD();
                            p.Codigo = Convert.ToInt16(reader["CD_GAME"]);
                            p.Nome_Game = reader["NM_GAME"].ToString();
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


        public List<Game_Grid_BD> Pesquisar_Game(BD_GAMEEntities pBD, Game_Filtro_BD pFiltro)
        {
            List<Game_Grid_BD> oLista = (from g in pBD.Game_BD
                                         where (pFiltro.Nome.Length == 0 || pFiltro.Nome == null ? true : g.Nome_Game.Contains(pFiltro.Nome))
                                         select new Game_Grid_BD
                                         {
                                             Codigo = g.Codigo,
                                             Nome_Game = g.Nome_Game,
                                             Total_Morte = g.Total_Morte,

                                             Listar_Mortes = (from m in pBD.Morte_BD
                                                              where (m.Codigo_Game == g.Codigo)

                                                              join p in pBD.Player_BD
                                                              on m.Codigo_Player equals p.Codigo into Left
                                                              from item in Left.DefaultIfEmpty()

                                                              select new Morte_Grid_BD
                                                              {
                                                                  Codigo_Morte = m.Codigo,
                                                                  Nome_Palyer = item.Nome_Player,
                                                                  Nome_Morte = m.Nome_Morte,
                                                                  Dano = m.Dano
                                                              }).ToList()
                                         }).ToList();
            return oLista;
        }


        #endregion


        #region Inserir


        public void Inserir(Game_Grid_BD pGame)
        {
            using (var conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=BD_GAME;integrated security=True;MultipleActiveResultSets=True"))
            {
                string sql = "INSERT INTO TB_GAME (NM_GAME, TOTAL_MORTE) VALUES (@nome, @total)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", pGame.Nome_Game);
                cmd.Parameters.AddWithValue("@total", pGame.Total_Morte);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        #endregion


        #region Alterar


        public void Alterar(Game_Grid_BD pGame)
        {
            using (var conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=BD_TESTE;integrated security=True;MultipleActiveResultSets=True"))
            {
                string sql = "UPDATE TB_GAME SET NM_GAME=@nome Where CD_GAME=@cod";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod", pGame.Codigo);
                cmd.Parameters.AddWithValue("@nome", pGame.Nome_Game);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        #endregion


        #region Excluir


        public void Excluir(int pCodigo)
        {
            using (var conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=BD_TESTE;integrated security=True;MultipleActiveResultSets=True"))
            {
                string sql = "DELETE TB_GAME Where CD_GAME=@cod";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod", pCodigo);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        #endregion

    }

    public class Game_Filtro_BD
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
    public class Game_Grid_BD
    {
        public Game_Grid_BD()
        {
            Listar_Mortes = new List<Morte_Grid_BD>();
        }
        public int Codigo { get; internal set; }
        public string Nome_Game { get; set; }
        public int Total_Morte { get; set; }

        [DisplayName("Mortes")]
        public List<Morte_Grid_BD> Listar_Mortes { get; set; }
    }
}
