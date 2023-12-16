namespace WebApplication6.Controllers
{
    public interface Ipatient
    {
        IList<patient> getAll();

        patient GetPatientById(int id);
        void AddPatient(patient newRec);

        void DeletePatient(int id);
        void UpdatePatient(patient UpdRec);

    }
}
