using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryApp.Models
{
    public class MonthlyTasks
    {
        public int UserTask_Id { get; set; }
        public int WeeklyTasks_Id { get; set; }
        public int MonthlylyTasks_Id { get; set; }
        public int NumberTask { get; set; }
        public int Grade_Id { get; set; }
    }
}
