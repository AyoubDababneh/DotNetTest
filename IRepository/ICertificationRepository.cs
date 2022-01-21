using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.IRepository
{
    public interface ICertificationRepository
    {
        void CreateCertification(Certification certification);
        IEnumerable<Certification> GetAllCertificationsByProfileId(int Id);
        void DeleteCertification(int Id);
    }
}
