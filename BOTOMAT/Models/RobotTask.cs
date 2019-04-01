using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOTOMAT.Models
{
    public class RobotTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TaskDuration { get; set; }
    }
}