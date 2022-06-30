using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    enum Status {Next_Up, In_Progress, Complete};
    enum Priority {Low, Medium, High};
    internal class Task
    {
        private String name;
        public String Name { get { return name; } set { name = value; } }

        private String description;
        public String Description { get { return description; } set { description = value; } }

        private Status status;
        public Status Status { get { return status; } set { status = value; } }

        private Priority priority;
        public Priority Priority { get { return priority; } set { priority = value; } }

        public Task(string name, string description, Status status, Priority priority)
        {
            Name = name;
            Description = description;
            Status = status;
            Priority = priority;
        }
    }
}
