using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Analisador_Log_Negocio;

namespace Analisador_Log_Listar.View
{
    public partial class Tela_Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void btn_Player_ItemClick(object sender, ItemClickEventArgs e)
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

        private void btn_Game_ItemClick(object sender, ItemClickEventArgs e)
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

        private void btn_Analisador_Log_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Analisador_Log_Listar oTela = new Analisador_Log_Listar();
                oTela.Show();
            }
            catch (Exception ex)
            {
                Menssagem.Chamar_Mensagem_Erro("Erro", ex.Message);
            }
        }

        private void btn_Morte_ItemClick(object sender, ItemClickEventArgs e)
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
    }
}