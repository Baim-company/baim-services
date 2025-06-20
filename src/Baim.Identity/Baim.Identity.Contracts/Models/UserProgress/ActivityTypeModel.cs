using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Models.UserProgress;

public class ActivityTypeModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public ActivityTypeModel()
    {
        Id = Guid.NewGuid();
    }

    public ActivityTypeModel(Guid id, string title) : this()
    {
        Id = id;
        Title = title;
    }
}