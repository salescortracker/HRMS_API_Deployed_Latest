using System;
using System.Collections.Generic;

namespace DataAccessLayer.DBContext;

public partial class CompanyNews
{
    public int NewsId { get; set; }

    public string Title { get; set; } = null!;

    public int CategoryId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime PublishDate { get; set; }

    public bool IsPublished { get; set; }

    public int? RegionId { get; set; }

    public int? CompanyId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UserId { get; set; }

    public virtual NewsCategory Category { get; set; } = null!;

    public virtual ICollection<NewsAttachment> NewsAttachments { get; set; } = new List<NewsAttachment>();
}
