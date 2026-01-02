using DataAccessLayer.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    
    public interface IadminService
    {
        Task<IEnumerable<Relationship>> GetAllrelatiopnshipByUserAsync( int companyId, int regionId);
        Task<Relationship> AddrelatiopnshipAsync(Relationship relationship);
        Task<Relationship?> UpdaterelatiopnshipAsync(Relationship relationship);
        Task<bool> Deleterelatiopnship(int relationshipId);

        Task<IEnumerable<Gender>> GetAllgenderByUserAsync(int companyId, int regionId);
        Task<Gender> AddgenderAsync(Gender gender);
        Task<Gender?> UpdategenderAsync(Gender gender);
        Task<bool> DeletegenderAsync(int genderId);
    }
}
