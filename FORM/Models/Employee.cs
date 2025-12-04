namespace FORM.Models
{
    public class Employee
    {
        public string Name { get; set; }

        //Specify Add dropdownlist
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public string Designation { get; set; }

        public int Salary { get; set; }
        //Add Radio button
        
        //public string Married { get; set; }
        

        //Add textbox
        public string Description { get; set; }
    }
    //Add dropdownlist
    public enum Gender
    {
        Male,Female
    }
}

