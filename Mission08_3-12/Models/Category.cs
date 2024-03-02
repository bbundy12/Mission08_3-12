using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission08_3_12.Models;

public partial class Category
{
    [Key]
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<TaskFix> Tasks { get; set; } = new List<TaskFix>();
}
