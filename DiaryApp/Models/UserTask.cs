

namespace DiaryApp.Models
{
    public class UserTask
    {
        public int User_Id { get; set; }
        public int UserTask_Id { get; set; }
        public int Priority_Id { get; set; }
        public int Period_Id { get; set; }
        public string TaskName { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }

    }
}
