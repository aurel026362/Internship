using App.Services.Dtos.DTOs.ExamMark;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces.IServices
{
    public interface IExamMarkService 
    {
        IList<ExamMarkDto> GetExamMarksByUserId(long userId);
        ExamMarkDto GetExamMark(long userId, long moduleId);
        IList<ExamMarkDto> GetExamMarksByModuleId(long moduleId);
        IList<ExamMarkDto> GetExamMarks();
    }
}
