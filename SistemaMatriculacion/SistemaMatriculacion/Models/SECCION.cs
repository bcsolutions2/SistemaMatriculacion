//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaMatriculacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SECCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECCION()
        {
            this.SECCION_MATERIA = new HashSet<SECCION_MATERIA>();
            this.ESTUDIANTE = new HashSet<ESTUDIANTE>();
        }
    
        public int ID_SECCION { get; set; }
        public string NOMBRE_SECCION { get; set; }
        public int CANTIDAD_ESTUDIANTES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECCION_MATERIA> SECCION_MATERIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTUDIANTE> ESTUDIANTE { get; set; }
    }
}
