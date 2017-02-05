using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queue.Models
{
    public class Client
    {
        public int Id { get; set; }
        public ClientStatusEnum Status { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
    }
}