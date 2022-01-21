using dotnetcoreTest.IRepository;
using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Repository
{
    public class CertificationRepository : ICertificationRepository
    {
        private readonly AppDbContext _context;

        public CertificationRepository( AppDbContext context)
        {
            _context = context;
        }

      
        public void CreateCertification(Certification certification)
        {
            if (certification == null)
            {
                throw new ArgumentNullException();
            }

            _context.Certifications.Add(certification);
            _context.SaveChanges();
        }

        public void DeleteCertification(int Id)
        {
            var certification = _context.Certifications.Where(x => x.Id == Id).FirstOrDefault();
            if (certification == null)
            {
                throw new NullReferenceException();
            }
            _context.Certifications.Remove(certification);
        }

        public IEnumerable<Certification> GetAllCertificationsByProfileId(int Id)
        {
            var certification = _context.Certifications.Where(x => x.ProfileId == Id).ToList();
            if (certification == null)
            {
                throw new NullReferenceException();
            }
            return certification;
        }
    }
}
