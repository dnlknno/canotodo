using System;

namespace canotodo.Common.Models
{
    public class Todo
    {
        public DateTime CreateTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
