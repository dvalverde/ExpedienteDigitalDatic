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
    
    public partial class CursoNoRemunerado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CursoNoRemunerado()
        {
            this.DocumentoCursoNoRemunerado = new HashSet<DocumentoCursoNoRemunerado>();
            this.PersonaXCursoNoRemunerado = new HashSet<PersonaXCursoNoRemunerado>();
        }
    
        public int ID { get; set; }
        public string nombre { get; set; }
        public string periodoLectivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoCursoNoRemunerado> DocumentoCursoNoRemunerado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaXCursoNoRemunerado> PersonaXCursoNoRemunerado { get; set; }
    }
}