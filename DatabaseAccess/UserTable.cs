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

    public partial class UserTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserTable()
        {
            this.AnnualTables = new HashSet<AnnualTable>();
            this.EmployeeCertificationTables = new HashSet<EmployeeCertificationTable>();
            this.EmployeeEducationTables = new HashSet<EmployeeEducationTable>();
            this.EmployeeLanguageTables = new HashSet<EmployeeLanguageTable>();
            this.EmployeeLeavingTables = new HashSet<EmployeeLeavingTable>();
            this.EmployeeSalaryTables = new HashSet<EmployeeSalaryTable>();
            this.EmployeeSkillTables = new HashSet<EmployeeSkillTable>();
            this.EmployeeWorkExperienceTables = new HashSet<EmployeeWorkExperienceTable>();
            this.EventTables = new HashSet<EventTable>();
            this.ExamTables = new HashSet<ExamTable>();
            this.ProgrameSessionTables = new HashSet<ProgrameSessionTable>();
            this.ProgrameTables = new HashSet<ProgrameTable>();
            this.SchoolLeavingTables = new HashSet<SchoolLeavingTable>();
            this.SectionTables = new HashSet<SectionTable>();
            this.SessionTables = new HashSet<SessionTable>();
            this.StudentTables = new HashSet<StudentTable>();
            this.SubjectTables = new HashSet<SubjectTable>();
            this.SubmissionFeeTables = new HashSet<SubmissionFeeTable>();
            this.TimeTblTables = new HashSet<TimeTblTable>();
            this.DesignationTables = new HashSet<DesignationTable>();
            this.StaffTables = new HashSet<StaffTable>();
            this.ExamMarksTables = new HashSet<ExamMarksTable>();
            this.ExpensesTables = new HashSet<ExpensesTable>();
        }

        [Display(Name = "User ID:")]
        public int UserID { get; set; }
        [Display(Name = "User Type:")]
        public int UserTypeID { get; set; }
        [Display(Name = "Created By:")]
        public string FullName { get; set; }
        [Display(Name = "User Name:")]
        public string UserName { get; set; }
        [Display(Name = "Password:")]
        public string Password { get; set; }
        [Display(Name = "Contact Number:")]
        public string ContactNo { get; set; }
        [Display(Name = "Email Address:")]
        public string EmailAddress { get; set; }
        [Display(Name = "Address:")]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnnualTable> AnnualTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeCertificationTable> EmployeeCertificationTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeEducationTable> EmployeeEducationTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLanguageTable> EmployeeLanguageTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLeavingTable> EmployeeLeavingTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeSalaryTable> EmployeeSalaryTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeSkillTable> EmployeeSkillTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeWorkExperienceTable> EmployeeWorkExperienceTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventTable> EventTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamTable> ExamTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgrameSessionTable> ProgrameSessionTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgrameTable> ProgrameTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolLeavingTable> SchoolLeavingTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SectionTable> SectionTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionTable> SessionTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentTable> StudentTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectTable> SubjectTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubmissionFeeTable> SubmissionFeeTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeTblTable> TimeTblTables { get; set; }
        public virtual UserTypeTable UserTypeTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DesignationTable> DesignationTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffTable> StaffTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamMarksTable> ExamMarksTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpensesTable> ExpensesTables { get; set; }
    }
}
