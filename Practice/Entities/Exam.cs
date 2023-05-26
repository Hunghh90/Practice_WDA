using System;
using System.Collections.Generic;

namespace Practice.Entities;

public partial class Exam
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public string ExamDate { get; set; } = null!;

    public int Duration { get; set; }

    public int? RoomId { get; set; }

    public int? SubjectId { get; set; }

    public int? FacultyId { get; set; }

    public virtual Faculty? Faculty { get; set; }

    public virtual Room? Room { get; set; }

    public virtual Subject? Subject { get; set; }
}
