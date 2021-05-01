using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Commands;
using ProcedureDiagnosisGrid.Helpers;
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

            AddDiagnosisCommand = new DelegateCommand(AddDiagnosisClicked);
            EditCommand = new DelegateCommand<object>((obj) => EditClicked(obj));
            DeleteCommand = new DelegateCommand<object>((obj) => DeleteClicked(obj));

        }

        private void DeleteClicked(object parm)
        {
            throw new NotImplementedException();
        }

        private void EditClicked(object parm)
        {
            throw new NotImplementedException();
        }

        private void AddDiagnosisClicked()
        {
            MessageBox.Show("Open Diagnosis Select Popup");
        }

        public DelegateCommand AddDiagnosisCommand { get; private set; }
        public DelegateCommand<object> EditCommand { get; private set; }
        public DelegateCommand<object> DeleteCommand { get; private set; }

        private Status _status;

        public Status Status
        {
            get { return _status; }
            set { _status = value; }
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
