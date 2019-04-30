using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces.ContentInternshipService
{
    public interface IContentInternshipService : ICommentService, IExamService, IModuleService, IThemeService, ISavingContext
    {
    }
}
