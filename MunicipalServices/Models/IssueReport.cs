using System;
using System.Collections.Generic;

namespace MunicipalServices.Models
{
    /// <summary>
    /// Represents a citizen-reported municipal issue.
    /// </summary>
    public class IssueReport
    {
        private static int _nextId = 1;

        public int Id { get; private set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> AttachedMediaPaths { get; set; }
        public DateTime ReportedAt { get; set; }
        public string Status { get; set; }

        public IssueReport()
        {
            Id = _nextId++;
            AttachedMediaPaths = new List<string>();
            ReportedAt = DateTime.Now;
            Status = "Pending";
        }

        public override string ToString()
        {
            return $"[{Id}] {Category} at {Location} ({ReportedAt:dd MMM yyyy HH:mm}) - {Status}";
        }
    }
}
