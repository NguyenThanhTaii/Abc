using System;

namespace DTO
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateFinish { get; set; }
        public Status Status { get; set; }
        public int ID { get; set; }
    }
}
