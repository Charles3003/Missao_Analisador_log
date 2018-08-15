using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Analisador_Log_Negocio;
using DevExpress.XtraSplashScreen;
using Analisador_Log_Negocio.Negocio;

namespace Analisador_Log_Listar.View
{
    public partial class Game_Manter : DevExpress.XtraEditors.XtraForm
    {
        public Game_Manter()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(SplashScreen_Carregar));

                Game_Grid_BD oGame = new Game_Grid_BD();
                oGame.Nome_Game = txt_Nome_Game.Text;
                oGame.Total_Morte = Convert.ToInt16(txt_Total_Morte.Text);

                SG_Game_NG.Game.Inserir(oGame);

                SplashScreenManager.CloseForm();
                Menssagem.Chamar_Mensagem("Salvo", "Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }

        private void bt_Inserir_Morte_Click(object sender, EventArgs e)
        {
            try
            {
                Morte_Manter oTela = new Morte_Manter();
                oTela.Show();
            }
            catch (Exception ex)
            {
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }

        private void btn_Inserir_Player_Click(object sender, EventArgs e)
        {
            try
            {
                Player_Manter oTela = new Player_Manter();
                oTela.Show();
            }
            catch (Exception ex)
            {
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }
    }
}