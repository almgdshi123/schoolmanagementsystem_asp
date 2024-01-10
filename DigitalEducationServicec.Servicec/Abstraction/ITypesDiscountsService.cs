using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ITypesDiscountsService
    {
        Task<List<TypesDiscountsTb>> GetTypesDiscountsListAsync();
        Task<TypesDiscountsTb> GetByIDAsync(long id);
        Task<string> AddAsync(TypesDiscountsTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(TypesDiscountsTb data);
        Task<string> DeleteAsync(TypesDiscountsTb data);
    }






}
