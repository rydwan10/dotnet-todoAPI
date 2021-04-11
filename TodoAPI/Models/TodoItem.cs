using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public bool IsComplete { get; set; }

    }
}
