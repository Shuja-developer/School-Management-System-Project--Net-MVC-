//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AnnualTable
    {
        public int AnnualID { get; set; }
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Select Programe")]
        public int ProgrameID { get; set; }

        [Required(ErrorMessage = "Please Enter Annual Fee Title")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Enter Annual Fee")]
        [DataType(DataType.Currency)]
        public Nullable<double> Fees { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        public virtual ProgrameTable ProgrameTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
