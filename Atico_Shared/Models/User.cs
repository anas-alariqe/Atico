public class User :Account
    {
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public string Tel { get; set; }= string.Empty;
        public Roles roles { get; set; } 
        
    }
    public enum Roles  {
        a = 0000-0001,
        b = 0000_0010,


        
    }