using System;
using Analisador_Log_Negocio;
using Analisador_Log_Negocio.Negocio;
using Analisador_Log_Listar.Model;
using Analisador_Log_Negocio.Edmx;

namespace Analisador_Log_Listar.View
{
    public partial class Player_Manter : DevExpress.XtraEditors.XtraForm
    {
        public Tela_Principal Tela_Origem { get; internal set; }

        public Player_Manter()
        {
            InitializeComponent();
        }

        private void Player_Manter_Shown(object sender, EventArgs e)
        {
            try
            {
                using (BD_GAMEEntities oBD = new BD_GAMEEntities())
                {
                    Carregar_Componente.Carregar_Game(oBD, lue_Game);
                }
            }
            catch (Exception ex)
            {
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Player_Grid_BD oPlayer_BD = new Player_Grid_BD();
                oPlayer_BD.Nome = txt_Nome_Morte.Text;
                oPlayer_BD.Codigo_Game = Convert.ToInt16(lue_Game.EditValue);

                using (BD_GAMEEntities oBD = new BD_GAMEEntities())
                {
                    SG_Game_NG.Player.Inserir(oBD, oPlayer_BD);

                    Menssagem.Chamar_Mensagem("Salvo", "Registro salvo com sucesso!!");
                }
                Close();
            }
            catch (Exception ex)
            {
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


    }
}