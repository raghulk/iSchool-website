using System;
using System.Collections.Generic;
using Project3_FinalExam.Models;
using System.Threading.Tasks;

namespace Project3_FinalExam.Services
{
    public interface IGetEmployment
    {
        Task<String> GetEmpInfo();
        Task<String> GetCoopInfo();
    }
}