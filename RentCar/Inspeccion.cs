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
    
    public partial class Inspeccion
    {
        public int ID { get; set; }
        public Nullable<int> Empleado { get; set; }
        public Nullable<int> Vehiculo { get; set; }
        public Nullable<int> Renta { get; set; }
        public Nullable<bool> TieneRalladuras { get; set; }
        public string CantCombustible { get; set; }
        public Nullable<bool> TieneGomaRepuesto { get; set; }
        public Nullable<bool> TieneGato { get; set; }
        public Nullable<bool> TieneRoturaCristal { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Goma1 { get; set; }
        public Nullable<bool> Goma2 { get; set; }
        public Nullable<bool> Goma3 { get; set; }
        public Nullable<bool> Goma4 { get; set; }
    
        public virtual Empleado Empleado1 { get; set; }
        public virtual Renta Renta1 { get; set; }
        public virtual Vehiculo Vehiculo1 { get; set; }
    }
}
