using System.ComponentModel.DataAnnotations;
namespace WebApplication6.Controllers
{
   
        public class patient
        {
            [Key]
            public int pid { get; set; }
            public string pname { get; set; }

            public patient()
            {
                pid = 1;
                pname = "sanjay";
            }
            public patient(int id, string nm)
            {
                pid = id;
                pname = nm;
            }
        
    }
}
