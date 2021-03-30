using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3_FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetFaculty _facultyRepository;

        private readonly IGetStaff _staffRepository;

        private readonly IGetUndergraduate _undergradRepository;

        private readonly IGetGraduate _gradRepository;

        private readonly IGetEmployment _empRepository;

        private readonly IGetAbout _aboutSvc;

        public HomeController(IGetFaculty facultyRepository, IGetUndergraduate undergradRepository, 
            IGetGraduate graduateRepository, IGetEmployment empRepository, IGetStaff staffRepository, IGetAbout aboutSvc)
        {
            _aboutSvc = aboutSvc;
            _facultyRepository = facultyRepository;
            _undergradRepository = undergradRepository;
            _gradRepository = graduateRepository;
            _empRepository = empRepository;
            _staffRepository = staffRepository;
        }
        public async Task<IActionResult> Index()
        {
            var aboutData = await _aboutSvc.GetAboutData();
            var homeViewModel = new HomeViewModel()
            {
                Title = aboutData.title,
                Description = aboutData.description,
                Quote = aboutData.quote,
                QuoteAuthor = aboutData.quoteAuthor
            };
            return View(homeViewModel);
        }

        public async Task<IActionResult> GetFaculty()
        {
            var allFaculty = await _facultyRepository.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var facultyViewModel = new FacultyViewModel()
            {
                Faculty = sortedFaculty.ToList(),
                Title = "Our Faculty"
            };
            return View(facultyViewModel);
        }

        public async Task<IActionResult> Staff()
        {
            var allStaff = await _staffRepository.GetAllStaff();
            var sortedStaff = allStaff.OrderBy(f => f.username);
            var staffViewModel = new StaffViewModel()
            {
                Staff = sortedStaff.ToList(),
                Title = "Our Staff"
            };
            return View(staffViewModel);
        }

        public async Task<IActionResult> Under()
        {
            var underGradMajors = await _undergradRepository.GetUnderGradDegrees();
            var underGradMinors = await _undergradRepository.GetUnderGradMinors();
            var underViewModel = new UndergradViewModel()
            {
                UnderGradMajors = underGradMajors.ToList(),
                UnderGradMinors = underGradMinors.ToList(),
                Title = "Undergraduate Programs"
            };
            return View(underViewModel);
        }

        public async Task<IActionResult> Grad()
        {
            var grad = await _gradRepository.GetGradDegrees();
            var gradViewModel = new GradViewModel()
            {
                Grads = grad,
                Title = "Graduate Programs"
            };
            return View(gradViewModel);
        }

        public async Task<IActionResult> Employment()
        {
            var empInfo = await _empRepository.GetEmpInfo();
            var coopInfo = await _empRepository.GetCoopInfo();
            var gradViewModel = new EmploymentViewModel()
            {
                EmpInfo = empInfo,
                CoopInfo = coopInfo,
                Title = "Employment Table"
            };
            return View(gradViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
