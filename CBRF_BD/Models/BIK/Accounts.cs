using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CBRF_DB.Models
{
    public class Accounts : INotifyPropertyChanged
    {
        private List<AccRstrList> accRstr = new List<AccRstrList>();
        private string account = "";
        private string regulationAccountType = ""; 
        private string cK = "";
        private string accountCBRBIC = "";
        private string dateIn = ""; 
        private string accountStatus = "";
        private string dateOut = "";

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<AccRstrList> AccRstr
        {
            get { return accRstr; }
            set
            {
                if (accRstr.Equals(value) == false)
                {
                    accRstr = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("AccRstr");
                }
            }
        }
        public string Account
        {
            get { return account; }
            set
            {
                if (account.Equals(value) == false)
                {
                    account = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("Account");
                }
            }
        }
        public string RegulationAccountType
        {
            get { return regulationAccountType; }
            set
            {
                if (regulationAccountType.Equals(value) == false)
                {
                    regulationAccountType = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("RegulationAccountType");
                }
            }
        }
        public string CK
        {
            get { return cK; }
            set
            {
                if (cK.Equals(value) == false)
                {
                    cK = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("CK");
                }
            }
        }
        public string AccountCBRBIC
        {
            get { return accountCBRBIC; }
            set
            {
                if (accountCBRBIC.Equals(value) == false)
                {
                    accountCBRBIC = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("AccountCBRBIC");
                }
            }
        }
        public string DateIn
        {
            get { return dateIn; }
            set
            {
                if (dateIn.Equals(value) == false)
                {
                    dateIn = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("DateIn");
                }
            }
        }
        public string AccountStatus
        {
            get { return accountStatus; }
            set
            {
                if (accountStatus.Equals(value) == false)
                {
                    accountStatus = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("AccountStatus");
                }
            }
        }
        public string DateOut
        {
            get { return dateOut; }
            set
            {
                if (dateOut.Equals(value) == false)
                {
                    dateOut = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("DateOut");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // OnPropertyChanged to update property value in binding
        private void OnPropertyChanged(string propName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
