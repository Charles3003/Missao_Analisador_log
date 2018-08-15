using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisador_Log_Negocio
{
   public class Menssagem
    {
        public static void Chamar_Mensagem(string pTitulo, string pTexto)
        {
            MessageBox.Show(pTexto, pTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Chamar_Mensagem_Erro(string pTitulo, string pTexto)
        {
            MessageBox.Show(pTexto, pTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
