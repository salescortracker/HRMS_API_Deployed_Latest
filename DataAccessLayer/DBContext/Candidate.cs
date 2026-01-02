using System;
using System.Collections.Generic;

namespace DataAccessLayer.DBContext;

public partial class Candidate
{
    public int CandidateId { get; set; }

    public int RegionId { get; set; }

    public int CompanyId { get; set; }

    public int UserId { get; set; }

    public string CandidateName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Mobile { get; set; }

    public string Technology { get; set; } = null!;

    public int ExperienceYears { get; set; }

    public string? CurrentCtc { get; set; }

    public string FileName { get; set; } = null!;

    public string? FilePath { get; set; }

    public DateOnly AppliedDate { get; set; }

    public int CurrentStageId { get; set; }

    public int ProgressPercent { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual ICollection<CandidateStageHistory> CandidateStageHistories { get; set; } = new List<CandidateStageHistory>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual RecruitmentStage CurrentStage { get; set; } = null!;
}
