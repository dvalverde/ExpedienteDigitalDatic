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
    
    public partial class ProyectoInvestigacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProyectoInvestigacion()
        {
            this.AutorXProyectoInvestigacion = new HashSet<AutorXProyectoInvestigacion>();
            this.DocumentoProyectoInvestigacion = new HashSet<DocumentoProyectoInvestigacion>();
            this.PersonaXProyectoInvestigacion = new HashSet<PersonaXProyectoInvestigacion>();
        }
    
        public int ID { get; set; }
        public string nombre { get; set; }
        public string medioDivulgacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutorXProyectoInvestigacion> AutorXProyectoInvestigacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoProyectoInvestigacion> DocumentoProyectoInvestigacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaXProyectoInvestigacion> PersonaXProyectoInvestigacion { get; set; }
    }
}
