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
    
    public partial class ObraAdministrativaDesarrollo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObraAdministrativaDesarrollo()
        {
            this.AutorXObraAdministrativaDesarrollo = new HashSet<AutorXObraAdministrativaDesarrollo>();
            this.DocumentoObraAdministrativa = new HashSet<DocumentoObraAdministrativa>();
            this.PersonaXObraAdministrativaDesarrollo = new HashSet<PersonaXObraAdministrativaDesarrollo>();
        }
    
        public int ID { get; set; }
        public string titulo { get; set; }
        public int numeroAutores { get; set; }
        public int id_tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutorXObraAdministrativaDesarrollo> AutorXObraAdministrativaDesarrollo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoObraAdministrativa> DocumentoObraAdministrativa { get; set; }
        public virtual TipoObraAdmi TipoObraAdmi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaXObraAdministrativaDesarrollo> PersonaXObraAdministrativaDesarrollo { get; set; }
    }
}