using System;
using System.Collections.Generic;

namespace DataAccessLayer.DBContext;

public partial class EmployeeMaster
{
    public int EmployeeMasterId { get; set; }

    public string FullName { get; set; } = null!;

    public int RoleId { get; set; }

    public string? Department { get; set; }

    public int? ManagerId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? Manager { get; set; }

    public virtual RoleMaster Role { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
