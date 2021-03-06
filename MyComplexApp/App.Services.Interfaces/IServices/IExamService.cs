﻿using App.Services.Dtos.DTOs;
using App.Services.Dtos.DTOs.Exam;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Interfaces.IServices
{
    public interface IExamService
    {
        IList<ExamDto> GetExams();
        ExamDto GetExam(long moduleId);
    }
}
