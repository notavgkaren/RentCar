//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentCar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Modelo_Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modelo_Vehiculo()
        {
            this.Vehiculoes = new HashSet<Vehiculo>();
        }
    
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<int> marca { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo> Vehiculoes { get; set; }
        public virtual Marca_Vehiculo Marca_Vehiculo { get; set; }
    }
}
