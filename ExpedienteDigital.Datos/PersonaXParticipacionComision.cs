//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpedienteDigital.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonaXParticipacionComision
    {
        public int ID { get; set; }
        public int id_persona { get; set; }
        public int id_participacion { get; set; }
    
        public virtual ParticipacionComision ParticipacionComision { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
