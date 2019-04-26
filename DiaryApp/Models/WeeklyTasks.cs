using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryApp.Models
{
    public class WeeklyTasks
    {
        public int UserTask_Id { get; set; }
        public int WeeklyTasks_Id { get; set; }
        public int DailyTasks_Id { get; set; }
        public int NumberTask { get; set; }
        public int Grade_Id { get; set; }

        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }

    }
}
