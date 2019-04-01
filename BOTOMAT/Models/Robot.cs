using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOTOMAT.Models
{
    public class Robot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RobotType { get; set; }

        public string ImgUrl { get; set; }
        public int CompletedTasks { get; set; }
    }
}