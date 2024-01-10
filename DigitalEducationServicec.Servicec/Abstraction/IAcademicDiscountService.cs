using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{


    // IAcademicDiscountService interface
    public interface IAcademicDiscountService
    {
        Task<List<AcademicDiscountTb>> GetAcademicDiscountListAsync();
        Task<AcademicDiscountTb> GetByIDAsync(long id);
        Task<string> AddAsync(AcademicDiscountTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(AcademicDiscountTb data);
        Task<string> DeleteAsync(AcademicDiscountTb data);
    }
}