using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces
{
    public interface IInternMarks
    {
        ICollection<ThemeMark> GetAllMarks();
    }
}
