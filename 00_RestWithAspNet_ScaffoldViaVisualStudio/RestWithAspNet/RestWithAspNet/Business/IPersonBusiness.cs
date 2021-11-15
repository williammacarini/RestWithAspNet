using RestWithAspNet.Data.VO;
using RestWithAspNet.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithAspNet.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindByName(string firstName, string secondName);
        List<PersonVO> FindAll();
        PagedSearchVO<PersonVO> FindWithPagedSeach(string name, string sortDirection,
            int pageSize, int page);
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);

    }
}
