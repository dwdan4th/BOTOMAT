using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOTOMAT.Models;

namespace BOTOMAT
{
    public class Repository

    {
        List<Robot> robots;
        List<RobotTask> tasks;

        public Repository()
        {
            
            tasks = InitTasks();
            robots = InitRobots();

        }

        private List<Robot> InitRobots()
        {
            return new List<Robot>();
        }

        private List<RobotTask> InitTasks()
        {
            int i = 1;
            tasks = new List<RobotTask>();
            tasks.Add(new RobotTask() { Id = i++, Description = "do the dishes", TaskDuration = 1000 });
            tasks.Add(new RobotTask() { Id = i++, Description = "sweep the house", TaskDuration = 3000 });
            tasks.Add(new RobotTask() { Id = i++, Description = "do the laundry", TaskDuration = 10000 });
            tasks.Add(new RobotTask() { Id = i++, Description = "take out the recycling", TaskDuration = 4000 });
            tasks.Add(new RobotTask() { Id = i++, Description = "make a sammich", TaskDuration = 7000 });
            tasks.Add(new RobotTask() { Id = i++, Description = "mow the lawn", TaskDuration = 20000 });
            tasks.Add(new RobotTask() { Id = i++, Description = "rake the leaves", TaskDuration = 18000 });
            tasks.Add(new RobotTask() { Id = i++, Description = "give the dog a bath", TaskDuration = 14500 });
            tasks.Add(new RobotTask() { Id = i++, Description = "bake some cookies", TaskDuration = 8000 });
            tasks.Add(new RobotTask() { Id = i++, Description = "wash the car", TaskDuration = 20000 });
            return tasks;
        }

        public List<string> GetRobotTypes()
        {
            List<string> robotTypes = new List<string>();
            robotTypes.Add("UNIPEDAL");
            robotTypes.Add("BIPEDAL");
            robotTypes.Add("QUADRUPEDAL");
            robotTypes.Add("ARACHNID");
            robotTypes.Add("RADIAL");
            robotTypes.Add("AERONAUTICAL");
            return robotTypes;
        }

        public Robot AddRobot(string name, string type)
        {
            int count = robots.Count();
            var r = new Robot() { Id = count + 1, Name = name, RobotType = type };
            robots.Add(r);
            return r;
        }

        public List<RobotTask> GetRandomRobotTasks()
        {
            var toDoTasks = new List<RobotTask>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int id = random.Next(1, 10);
                toDoTasks.Add(tasks.Single(r => r.Id == id));
            }

            return toDoTasks;
    }
    }
}