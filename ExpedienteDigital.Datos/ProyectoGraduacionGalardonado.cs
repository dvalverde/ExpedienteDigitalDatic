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
    
    public partial class ProyectoGraduacionGalardonado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProyectoGraduacionGalardonado()
        {
            this.AutorXProyectoGraduacion = new HashSet<AutorXProyectoGraduacion>();
            this.DocumentoProyectoGraduacion = new HashSet<DocumentoProyectoGraduacion>();
            this.PersonaXProyectoGraduacion = new HashSet<PersonaXProyectoGraduacion>();
        }
    
        public int ID { get; set; }
        public string nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutorXProyectoGraduacion> AutorXProyectoGraduacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoProyectoGraduacion> DocumentoProyectoGraduacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaXProyectoGraduacion> PersonaXProyectoGraduacion { get; set; }
    }
}
