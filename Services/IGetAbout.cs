using Project3_FinalExam.Models;
using System.Threading.Tasks;

namespace Project3_FinalExam.Services
{
    public interface IGetAbout
    {
        Task<About> GetAboutData();
    }
}