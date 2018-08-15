using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Log_Negocio.Negocio
{
    public class Morte_NG
    {

        #region Inserir


        public void Inserir(Morte_Grid_BD pMorte)
        {
            using (var conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=BD_GAME;integrated security=True;MultipleActiveResultSets=True"))
            {
                string sql = "INSERT INTO TB_MORTE (CD_PLAYER, CD_GAME, NM_MORTE, DANO) VALUES (@CD_PLAYER, @CD_GAME,@NM_MORTE,@DANO)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CD_PLAYER", pMorte.Codigo_Player);
                cmd.Parameters.AddWithValue("@CD_GAME", pMorte.Codigo_Game);
                cmd.Parameters.AddWithValue("@NM_MORTE", pMorte.Nome_Morte);
                cmd.Parameters.AddWithValue("@DANO", pMorte.Dano);
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
    public class Morte_Grid_BD
    {
        [Display(AutoGenerateField = false)]
        public int Codigo { get; set; }
        [Display(AutoGenerateField = false)]
        public int Codigo_Player { get; set; }
        [Display(AutoGenerateField = false)]
        public int Codigo_Game { get; set; }
        [DisplayName("Nome Morte")]
        public string Nome_Morte { get; set; }
        public short Dano { get; set; }
        [DisplayName("Nome Player")]
        public string Nome_Palyer { get; set; }
        [Display(AutoGenerateField = false)]
        public int Codigo_Morte { get; internal set; }
    }
}
