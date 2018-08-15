using Analisador_Log_Listar.View;
using Analisador_Log_Negocio;
using Analisador_Log_Negocio.Edmx;
using Analisador_Log_Negocio.Negocio;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Analisador_Log_Listar
{
    public partial class Analisador_Log_Listar : XtraForm
    {
        const string INICIAR_GAME = "InitGame:";
        const string FIM_GAME = "ShutdownGame:";
        const string CLINTE_CONECTADO = "ClientConnect:{0}";
        const string CLINTE_INICIAR_GAME = "ClientBegin:{0}";
        const string NOME_CLINTE = "ClientUserinfoChanged:";
        const string MORTE = "Kill:";

        public Analisador_Log_Listar()
        {
            InitializeComponent();
        }

        private void Analisador_Log_Listar_Shown(object sender, EventArgs e)
        {
            try
            {
                Ler_Arquivo_Log();

            }
            catch (Exception ex)
            {
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }

        public void Ler_Arquivo_Log()
        {
            List<string[]> oLista_Games = new List<string[]>();
            //List<Game> oGames = new List<Game>();

            string[] oArquivo = System.IO.File.ReadAllLines(@"C:\Users\Charles Marques\Desktop\games.log");
            string text = System.IO.File.ReadAllText(@"C: \Users\Charles Marques\Desktop\games.log");


            int oContador = 0;
            int oInicio_Game = 0;
            int oFim_Game = 0;

            /*Agrupar games*/
            foreach (string linha in oArquivo)
            {
                string[] oLinha = linha.Split(' ');

                if (oLinha.Contains(INICIAR_GAME))
                {
                    oInicio_Game = oContador;
                }
                else if (oLinha.Contains(FIM_GAME))
                {
                    oFim_Game = oContador;

                    oLista_Games.Add(Pegar_Intervalo_Array(oArquivo, oInicio_Game, oFim_Game));
                }
                oContador++;
            }

            //oContador = 0;

            //foreach (string[] item in oLista_Games)
            //{
            //    Game oGame = new Game();
            //    oGame.Nome_Game = string.Format("game_{0}", oContador);

            //    for (int i = 0; i < item.Count(); i++)
            //    {
            //        if (item[i] != null)
            //        {
            //            if (item[i].Contains(NOME_CLINTE))
            //            {
            //                string[] oLinha = item[i].Split(' ');

            //                int oPosicao_Final = oLinha[oLinha.Count() - 1].ToString().IndexOf("\\t");
            //                string oNome = oLinha[oLinha.Count() - 1].ToString().Substring(2, oPosicao_Final).Replace("\\t", "");

            //                if (!oGame.Players.Exists(w => w.Nome_Jogador == oNome))
            //                {
            //                    oGame.Players.Add(new Jogador { Numero_Jogador = oContador, Nome_Jogador = oNome });
            //                }
            //                else
            //                {
            //                    oGame.Players.Where(w => w.Numero_Jogador == oContador).Select(w => w.Nome_Jogador = oNome);
            //                }
            //            }
            //            if (item[i].Contains(MORTE))
            //            {
            //                string[] oLinha = item[i].Split(' ');


            //            }
            //        }
            //    }


            //    oContador++;
            //}


        }

        private strin   g[] Pegar_Intervalo_Array(string[] pArray, int pInicio, int pFim)
        {
            string[] oArry_Novo = new string[pFim + 1];

            for (int i = pInicio; i <= pFim; i++)
            {
                oArry_Novo[i] = pArray[i];
            }

            return oArry_Novo;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(SplashScreen_Carregar));

                Game_Filtro_BD oFiltro = new Game_Filtro_BD();
                oFiltro.Nome = txt_Nome_Game.Text;

                List<Game_Grid_BD> oLista = null;
                using (BD_GAMEEntities oBD = new BD_GAMEEntities())
                {
                    oLista = SG_Game_NG.Game.Pesquisar_Game(oBD, oFiltro);
                    gc_Log.DataSource = oLista;
                }
                SplashScreenManager.CloseForm();
                if (oLista.Count == 0)
                {
                    Menssagem.Chamar_Mensagem("Pesquisar", "Não foi encotrado nenhum registro!");
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Nome_Game.Text = "";
                gc_Log.DataSource = null;
            }
            catch (Exception ex)
            {
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Game_Manter oTela = new Game_Manter();
                oTela.Show();
            }
            catch (Exception ex)
            {
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }
    }
}
