using System;
using Domain;

namespace Persistence
{
    public class DbInitializer
    {
        public static async Task SeedData(AppDbContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new() {
                    Title = "Doctor Appointment 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Routine check-up with Dr. Grinch",
                    Category = "General Check-up",
                    City = "London",
                    Department = "Cardiology, St. Mary's Hospital",
                    Latitude = 51.51171665,
                    Longitude = -0.1256611057818921
                },
                new() {
                    Title = "Doctor Appointment 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Follow-up appointment with Dr. Rose",
                    Category = "Orthopedics",
                    City = "Paris",
                    Department = "Orthopedic Department, Pitié-Salpêtrière Hospital",
                    Latitude = 48.8611473,
                    Longitude = 2.33802768704666
                },
                new() {
                    Title = "Doctor Appointment 3",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Annual physical with Dr. Cobain",
                    Category = "General Check-up",
                    City = "London",
                    Department = "General Medicine, King's College Hospital",
                    Latitude = 51.496510900000004,
                    Longitude = -0.17600190725447445
                },
                new() {
                    Title = "Doctor Appointment 4",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Eye examination with Dr. Patel",
                    Category = "Ophthalmology",
                    City = "Sydney",
                    Department = "Ophthalmology, Moorfields Eye Hospital",
                    Latitude = 51.502936649999995,
                    Longitude = 0.0032029278126681844
                },
                new()
                {
                    Title = "Doctor Appointment 5",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Consultation for back pain with Dr. Stojkaj",
                    Category = "Physiotherapy",
                    City = "London",
                    Department = "Physiotherapy, The Royal London Hospital",
                    Latitude = 51.501778,
                    Longitude = -0.053577
                },
                new()
                {
                    Title = "Doctor Appointment 6",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Dental check-up with Dr. Davis",
                    Category = "Dentistry",
                    City = "London",
                    Department = "Dentistry, Guy's Hospital",
                    Latitude = 51.512146650000005,
                    Longitude = -0.10364680647106028
                },
                new()
                {
                    Title = "Doctor Appointment 7",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Follow-up for skin rash with Dr. White",
                    Category = "Dermatology",
                    City = "London",
                    Department = "Dermatology, St. Thomas' Hospital",
                    Latitude = 51.5237629,
                    Longitude = -0.1584743
                },
                new()
                {
                    Title = "Doctor Appointment 8",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Consultation for hypertension with Dr. Green",
                    Category = "Cardiology",
                    City = "London",
                    Department = "Cardiology, Royal Brompton Hospital",
                    Latitude = 51.5432505,
                    Longitude = -0.15197608174931165
                },
                new()
                {
                    Title = "Doctor Appointment 9",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Consultation for asthma with Dr. Blue",
                    Category = "Pulmonology",
                    City = "London",
                    Department = "Pulmonology, University College Hospital",
                    Latitude = 51.5575525,
                    Longitude = -0.781404
                },
                new()
                {
                    Title = "Doctor Appointment 10",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Follow-up for diabetes with Dr. Brown",
                    Category = "Endocrinology",
                    City = "London",
                    Department = "Endocrinology, The Royal Free Hospital",
                    Latitude = 51.5575525,
                    Longitude = -0.781404
                }
            };

            context.Activities.AddRange(activities);

            await context.SaveChangesAsync();
        }
    }
}
