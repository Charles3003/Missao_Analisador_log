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
    
    public partial class Player_BD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Player_BD()
        {
            this.TB_MORTE = new HashSet<Morte_BD>();
        }
    
        public int Codigo { get; set; }
        public int Codigo_Game { get; set; }
        public string Nome_Player { get; set; }
    
        public virtual Game_BD TB_GAME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Morte_BD> TB_MORTE { get; set; }
    }
}
