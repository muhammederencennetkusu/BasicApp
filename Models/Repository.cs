namespace BasicApp.Models
{
    
    public static class Repository{

        private static List<Course> applicatons = new();

        private static IEnumerable<Course> Application => applicatons;



        public static void Add(Course course){

            applicatons.Add(course);
        }
    }
}