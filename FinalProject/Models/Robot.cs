using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Robot
    {
        [PrimaryKey, AutoIncrement]
        public int RobotID { get; set; }
        public string? RobotName { get; set; }
        public string? RobotModel { get; set; }
        public string? RobotDescription { get; set; }
        public string? RobotManufacturer {  get; set; }
        
    }
}
