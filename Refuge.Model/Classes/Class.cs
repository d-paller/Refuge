using System;

namespace Refuge.Model.Classes
{
    public class Class
    {
        public int ClassId { get; set; }

        public int TeacherUserId { get; set; }

        public string TeacherName { get; set; }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public string Location { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
    }
}
