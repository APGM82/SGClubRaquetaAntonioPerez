//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGClubRaquetaAntonioPerez
{
    using System;
    using System.Collections.Generic;
    
    public partial class pistas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pistas()
        {
            this.reservas = new HashSet<reservas>();
        }
    
        public int idPista { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public Nullable<decimal> precioHora { get; set; }
        public byte[] foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservas> reservas { get; set; }
    }
}
