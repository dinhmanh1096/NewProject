namespace NewProject.Data
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleID { get; set; }
        
        //
        public Role Role { get; set; }
        public ICollection<Workout> Workouts { get; set; }
    }
}
