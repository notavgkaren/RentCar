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
    
    public partial class Renta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Renta()
        {
            this.Inspeccions = new HashSet<Inspeccion>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Empleado { get; set; }
        public Nullable<int> Vehiculo { get; set; }
        public Nullable<int> Cliente { get; set; }
        public Nullable<System.DateTime> FechaRenta { get; set; }
        public Nullable<System.DateTime> FechaDevolucion { get; set; }
        public Nullable<int> MontoDiario { get; set; }
        public Nullable<int> CantDias { get; set; }
        public string Comentario { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<int> inspeccion { get; set; }
    
        public virtual Cliente Cliente1 { get; set; }
        public virtual Empleado Empleado1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspeccion> Inspeccions { get; set; }
        public virtual Vehiculo Vehiculo1 { get; set; }
    }
}
