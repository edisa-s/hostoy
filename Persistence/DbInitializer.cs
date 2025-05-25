using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class DbInitializer
    {
        public static async Task SeedData(AppDbContext context, UserManager<User> userManager)
        {
            var users = new List<User>
            {
                new() { DisplayName = "Eda", UserName = "eda@test.com", Email = "eda@test.com" },
                new() { DisplayName = "Kurt", UserName = "kurt@test.com", Email = "kurt@test.com" },
                new() { DisplayName = "Eddie", UserName = "eddie@test.com", Email = "eddie@test.com" }
            };

            if (!userManager.Users.Any())
            {
                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Annual Physical Exam",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "General Checkup",
                    Category = "general",
                    City = "Reykjavík",
                    Department = "Internal Medicine Department, Landspítali Hospital",
                    Latitude = 51.51171665,
                    Longitude = -0.1256611057818921,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[0].Id,
                            IsHost = true,
                        },
                        new ActivityAttendee
                        {
                            UserId = users[1].Id,
                            IsHost = false,
                        }
                    }
                },
                new Activity
                {
                    Title = "Skin Rash Evaluation",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Dermatology Consultation",
                    Category = "skin",
                    City = "Akureyri",
                    Department = "Skin Clinic, Akureyri Hospital",
                    Latitude = 48.8611473,
                    Longitude = 2.33802768704666,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[1].Id,
                            IsHost = true,
                        },
                        new ActivityAttendee
                        {
                            UserId = users[2].Id
                        },
                        new ActivityAttendee
                        {
                            UserId = users[0].Id,
                        }
                    }
                },
                new Activity
                {
                    Title = "Cardiology Check-up",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Cardiology Check",
                    Category = "heart",
                    City = "Hafnarfjörður",
                    Department = "Cardiology Department, Sudurnes Hospital",
                    Latitude = 51.496510900000004,
                    Longitude = -0.17600190725447445,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[2].Id,
                            IsHost = true,
                        }
                    }
                },
                new Activity
                {
                    Title = "Neurological Assessment",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Neurology Consultation",
                    Category = "neuro",
                    City = "Kópavogur",
                    Department = "Neurology Unit, Heilsugæslan Kópavogi",
                    Latitude = 51.502936649999995,
                    Longitude = 0.0032029278126681844,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[0].Id,
                            IsHost = true,
                        },
                        new ActivityAttendee
                        {
                            UserId = users[2].Id
                        }
                    }
                },
                new Activity
                {
                    Title = "Orthopedic Consultation",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Orthopedic Evaluation",
                    Category = "orthopedics",
                    City = "Ísafjörður",
                    Department = "Orthopedic Dept., Ísafjörður Health Center",
                    Latitude = 51.501778,
                    Longitude = -0.053577,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[1].Id,
                            IsHost = true,
                        }
                    }
                },
                new Activity
                {
                    Title = "ENT Examination",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "ENT Checkup",
                    Category = "ENT",
                    City = "Selfoss",
                    Department = "ENT Clinic, Selfoss Medical Center",
                    Latitude = 51.512146650000005,
                    Longitude = -0.10364680647106028,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[2].Id,
                            IsHost = true,
                        },
                        new ActivityAttendee
                        {
                            UserId = users[0].Id
                        }
                    }
                },
                new Activity
                {
                    Title = "Child Health Visit",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Pediatric Consultation",
                    Category = "pediatrics",
                    City = "Egilsstaðir",
                    Department = "Pediatric Ward, Egilsstaðir Hospital",
                    Latitude = 51.5237629,
                    Longitude = -0.1584743,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[0].Id,
                            IsHost = true,
                        }
                    }
                },
                new Activity
                {
                    Title = "Psychiatric Follow-up",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Psychiatry Session",
                    Category = "mental",
                    City = "Reykjanesbær",
                    Department = "Psychiatric Services, Reykjanes Health Center",
                    Latitude = 51.5432505,
                    Longitude = -0.15197608174931165,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[1].Id,
                            IsHost = true,
                        },
                        new ActivityAttendee
                        {
                            UserId = users[0].Id
                        }
                    }
                },
                new Activity
                {
                    Title = "Women's Health Screening",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Gynecology Check",
                    Category = "women",
                    City = "Akranes",
                    Department = "Women's Health Dept., Akranes Hospital",
                    Latitude = 51.5575525,
                    Longitude = -0.781404,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[2].Id,
                            IsHost = true,
                        },
                        new ActivityAttendee
                        {
                            UserId = users[1].Id
                        }
                    }
                },
                new Activity
                {
                    Title = "Imaging & Radiology Scan",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Radiology Exam",
                    Category = "imaging",
                    City = "Húsavík",
                    Department = "Radiology Unit, Húsavík Health Center",
                    Latitude = 51.5575525,
                    Longitude = -0.781404,
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            UserId = users[0].Id,
                            IsHost = true,
                        }
                    }
                }
            };

            context.Activities.AddRange(activities);
            await context.SaveChangesAsync();
        }
    }
}
