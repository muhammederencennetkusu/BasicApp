namespace BasicApp.Models
{

   public class Course {

        public string? StudentEmail { get; set; } = String.Empty;
        public string StudentName { get; set; }= String.Empty;
        public string StudentSurname { get; set; }= String.Empty;
        public string StudentFullName { get; set; }= String.Empty;
        public string StudentAge { get; set; }= String.Empty;
        public DateTime CourseAt { get; set; }= DateTime.Now;
    }
    
}