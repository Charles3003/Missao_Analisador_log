//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Analisador_Log_Negocio.Edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class Morte_BD
    {
        public int Codigo { get; set; }
        public int Codigo_Player { get; set; }
        public int Codigo_Game { get; set; }
        public string Nome_Morte { get; set; }
        public short Dano { get; set; }
    
        public virtual Game_BD TB_GAME { get; set; }
        public virtual Player_BD TB_PLAYER { get; set; }
    }
}
