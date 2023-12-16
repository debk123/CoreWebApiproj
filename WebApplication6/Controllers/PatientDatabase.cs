namespace WebApplication6.Controllers
{
    public class PatientDatabase
    {
        public List<patient> Patients;
        public PatientDatabase() {
            Patients = new List<patient>();
            Patients.Add(new patient(1, "p1"));
            Patients.Add(new patient(2, "p2"));
        }

        public List<patient> LoadData()
        {
            return Patients;

        }
    }

    
}
