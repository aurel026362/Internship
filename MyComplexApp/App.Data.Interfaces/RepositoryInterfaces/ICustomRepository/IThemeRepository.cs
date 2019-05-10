using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces.IComplexRepository
{
    public interface IThemeRepository : IGenericRepository<Theme>
    {
        IList<Theme> GetThemes();
        IList<Theme> GetThemesByModuleId(long moduleId);
        IList<Theme> GetThemesByMenthorId(long menthorId);
    }
}
