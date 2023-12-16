namespace WebApplication6.Controllers
{
    public class PatientService : Ipatient
    {
        private PatientDbContext db;

        public PatientService(PatientDbContext db)
        {
            this.db = db;
        }

        public void AddPatient(patient newRec)
        {
            try
            {
                db.Patients.Add(newRec);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void DeletePatient(int id)
        {
            try
            {
                var res = db.Patients.Find(id);

                db.Patients.Remove(res);
                db.SaveChanges();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IList<patient> getAll()
        {
            try
            {
                return db.Patients.ToList();

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public patient GetPatientById(int id)
        {
            try
            {
                var res = db.Patients.Find(id);
                return res;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdatePatient(patient UpdRec)
        {
            try
            {
                var res = db.Patients.Find(UpdRec.pid);

                res.pname = UpdRec.pname;
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
