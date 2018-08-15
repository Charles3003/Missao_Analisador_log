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
using Analisador_Log_Negocio.Negocio;
using DevExpress.XtraSplashScreen;
using Analisador_Log_Listar.Model;
using Analisador_Log_Negocio.Edmx;

namespace Analisador_Log_Listar.View
{
    public partial class Morte_Manter : DevExpress.XtraEditors.XtraForm
    {
        public Morte_Manter()
        {
            InitializeComponent();
        }

        private void Morte_Manter_Shown(object sender, EventArgs e)
        {
            try
            {
                using (BD_GAMEEntities oBD = new BD_GAMEEntities())
                {
                    Carregar_Componente.Carregar_Game(oBD, lue_Game);
                    Carregar_Componente.Carregar_Player(oBD, lue_Nome_Player);
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
                SplashScreenManager.ShowForm(typeof(SplashScreen_Carregar));

                Morte_Grid_BD oMorte = new Morte_Grid_BD();
                if (Convert.ToInt16(lue_Game.EditValue) > 0)
                    oMorte.Codigo_Game = Convert.ToInt16(lue_Game.EditValue);
                if (Convert.ToInt16(lue_Nome_Player.EditValue) > 0)
                    oMorte.Codigo_Player = Convert.ToInt16(lue_Nome_Player.EditValue);
                oMorte.Dano = Convert.ToInt16(txt_Dano.Text);
                oMorte.Nome_Morte = txt_Nome_Morte.Text;

                SG_Game_NG.Morte.Inserir(oMorte);

                SplashScreenManager.CloseForm();

                Menssagem.Chamar_Mensagem("Salvo", "Registro salvo com sucesso!!");

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