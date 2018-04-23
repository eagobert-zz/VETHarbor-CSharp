using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models.SearchViewModels
{
    public class ProgramSearchViewModel
    {
        public List<Programs> programs;
        public SelectList programType;
        public string ProgramType { get; set; }
    }
}
