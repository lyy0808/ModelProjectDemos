using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerDemo
{
   public class BehaviourRequest: ObservableObject
    {
        private int txtNUmber ;

        public int TxTNumber
        {
            get { return txtNUmber; }
            set { txtNUmber = value;
                RaisePropertyChanged(() => TxTNumber);
            }
        }

        private string strResult;

        public string StrResult
        {
            get { return strResult; }
            set { strResult = value; RaisePropertyChanged(() => StrResult); }
        }
        public BehaviourRequest(int inumber,string strre)
        {
            txtNUmber = inumber;
            strResult = strre;

        }
    }
}
