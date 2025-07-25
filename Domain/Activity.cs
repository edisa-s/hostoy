using System;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[Index(nameof(Date))]

public class Activity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Title { get; set; }
    public DateTime Date { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }
    public bool IsCancelled { get; set; }


    public required string City { get; set; }
    public required string Department { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }


    public ICollection<ActivityAttendee> Attendees { get; set; } = [];
    public ICollection<Comment> Comments { get; set; } = [];
}