using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Repository
{
    public class ThemeMarksRepository : Repository<ThemeMark>
    {
        protected ThemeMarksRepository(MyAppContext context) : base(context)
        {

        }
    }
}
