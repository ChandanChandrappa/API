using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcedureDiagnosisGrid.Models;

namespace ProcedureDiagnosisGrid.ViewModels
{
    class AddDiagnosisViewModel
    {
        public AddDiagnosisViewModel()
        {
            Procedure _proc = new Procedure()
            {
                ProcedureCode = "89076",
                Diagnoses = new List<Diagnosis>()
                {
                    new Diagnosis() { DiagnosisCodeId = "R05.5", DiagnosisCodeLibId = "68s789784549856545" },
                    new Diagnosis() { DiagnosisCodeId = "98605", DiagnosisCodeLibId = "68s789784549856545" }, 
                    new Diagnosis() { DiagnosisCodeId = "R693.7", DiagnosisCodeLibId = "68s789784549856545"}
                }
            };

            Diags = _proc.Diagnoses;

        }

        private Procedure _proc;

        public Procedure Procs
        {
            get { return _proc; }
            set { _proc = value; }
        }


        private List<Diagnosis> diags;

        public List<Diagnosis> Diags
        {
            get { return diags; }
            set { diags = value; }
        }

        public enum POA
        {
            A,
            B,
            C
        }
    }
}
