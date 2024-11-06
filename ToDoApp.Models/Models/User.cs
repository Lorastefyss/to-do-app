using Microsoft.AspNetCore.Identity;

namespace ToDoApp.Models.Models
{
    public class User : IdentityUser
    {
        //hashSet - list that cannot contain dublicated item
        public ICollection<ToDoTask> Tasks { get; set; } = new HashSet<ToDoTask>();


    }
}
