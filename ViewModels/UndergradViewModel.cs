using System.Collections.Generic;
using Project3_FinalExam.Models;

namespace Project3_FinalExam.ViewModels
{
    public class UndergradViewModel
    {
        public List<UnderGradMajors> UnderGradMajors { get; set; }
        public List<UnderGradMinors> UnderGradMinors { get; set; }
        public string Title { get; set; }
    }
}
