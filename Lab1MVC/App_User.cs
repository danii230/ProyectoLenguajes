//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class App_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public App_User()
        {
            this.Professor = new HashSet<Professor>();
            this.Student = new HashSet<Student>();
        }
    
        public int AppUserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string URLPhoto { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int Province { get; set; }
        public int Canton { get; set; }
        public int District { get; set; }
        public string Interest { get; set; }
        public bool Status { get; set; }
        public System.DateTime CreateAt { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    
        public virtual Canton Canton1 { get; set; }
        public virtual District District1 { get; set; }
        public virtual Province Province1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Professor> Professor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student { get; set; }
    }
}
