using MVVMPattern.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.ViewModel
{
    public class FotaViewModel : ViewModelBase
    {
               
        ObservableCollection<String> fotaList;

        FotaProcessModel fotaProcess;
        FotaDataModel fotaDataModel;
        RelayCommand addFotaCommand;

        public FotaViewModel()
        {
            fotaDataModel = new FotaDataModel();
            this.fotaList = new ObservableCollection<String>();
            this.addFotaCommand = new RelayCommand(p => this.AddList(), p => true);
            //AddList();
        }
        
        #region Properties
        public ObservableCollection<String> FotaList
        {
            get
            {
                return fotaList;
            }
            set
            {
                fotaList = value;
                OnPropertyChanged("FotaList");
            }
        }

        public FotaDataModel FotaInformationActual
        {
            get
            {
                return fotaDataModel;
            }
            set
            {
                fotaDataModel = value;
                OnPropertyChanged("FotaInformationActual");
            }
        }

        public RelayCommand AddFotaCommand
        {
            get
            {
                return addFotaCommand;
            }
        }
        #endregion

        #region Methods
        private void AddList()
        {
            fotaProcess = new FotaProcessModel(fotaDataModel);

            string result = "";

            // Auto
            if (!string.IsNullOrEmpty(fotaDataModel.Input))
            {
                List<String> lr = fotaProcess.AutoMakeInformation(fotaDataModel.Input);

                for(int i = 0; i < lr.Count; i++)
                {
                    if (!fotaList.Contains(lr[i]))
                        fotaList.Add(lr[i]);
                }
            }
            

            // Manual
            if (!string.IsNullOrEmpty(fotaDataModel.Name) &&
                !string.IsNullOrEmpty(fotaDataModel.FirstName))
            {
                result = fotaProcess.ManaulMakeInformation(fotaDataModel);
                if (!fotaList.Contains(result))
                    FotaList.Add(result);
            }
           
        }
        #endregion

    }
}
