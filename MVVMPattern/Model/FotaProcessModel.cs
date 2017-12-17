using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.Model
{
    class FotaProcessModel
    {
        FotaDataModel _fotaData;
        string _autoInput;
        public FotaProcessModel(FotaDataModel fotaData)
        {
            _fotaData = fotaData;
        }

        public List<string> AutoMakeInformation(string Input)
        {
            // autoInput => resultString (string => string[])
             _autoInput = Input;

            List<String> makedList = new List<String>();
            
            makedList.Add("Vzw : " + _autoInput);
            makedList.Add("Att : " + _autoInput);

            return makedList;
        }

        public string ManaulMakeInformation(FotaDataModel fotaData)
        {
            _fotaData = fotaData;
            string str = fotaData.Name + fotaData.Age;

            return str;
        }
    }
}
