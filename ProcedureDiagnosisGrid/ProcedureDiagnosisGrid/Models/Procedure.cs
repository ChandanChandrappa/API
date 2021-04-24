using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcedureDiagnosisGrid.Models;

namespace ProcedureDiagnosisGrid.Models
{
    public class Procedure
    {
        public string ProcedureCode { get; set; }

        public List<Diagnosis> Diagnoses { get; set; }

    }
}
