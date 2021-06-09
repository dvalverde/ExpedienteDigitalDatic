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
    
    public partial class Libro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Libro()
        {
            this.Capitulo = new HashSet<Capitulo>();
            this.DocumentoLibro = new HashSet<DocumentoLibro>();
        }
    
        public int ID { get; set; }
        public string titulo { get; set; }
        public string anno { get; set; }
        public string editorial { get; set; }
        public string consejoEditorial { get; set; }
        public int id_pais { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Capitulo> Capitulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoLibro> DocumentoLibro { get; set; }
        public virtual Pais Pais { get; set; }
    }
}