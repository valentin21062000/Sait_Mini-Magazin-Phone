using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;
        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Model>> Models()
        {
            return await _db.Models.ToListAsync();
        }
        public async Task<IEnumerable<Phone>> GetPhones(string sTrem = "", int modelId = 0)
        {
            sTrem = sTrem.ToLower();
            IEnumerable<Phone> phones = await (from phon in _db.Phones
                          join Model in _db.Models
                          on phon.ModelId equals Model.Id
                          where string.IsNullOrWhiteSpace(sTrem) || (phon!=null && phon.PhoneName.ToLower().StartsWith(sTrem))
                          select new Phone
                          {
                              Id= phon.Id,
                              Image=phon.Image,
                              Company=phon.Company,
                              PhoneName=phon.PhoneName,
                              Model= phon.Model,
                              Price=phon.Price,
                             
                          }).ToListAsync();
            if(modelId>0)
            {
                phones = phones.Where(a => a.Model.Id == modelId).ToList();
            }
            return phones;
        }
    }
}
