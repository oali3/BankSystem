using System.Data;
using System.Security.Policy;
using BankDataLayer;


namespace BankBusinessLayer
{
    public class clsUser
    {
        enum enMode { AddNew, Update};
        enMode _Mode;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }


        public clsUser()
        {
            UserID = -1;
            UserName = "";
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
            Password = "";
            Permissions = -1;

            _Mode = enMode.AddNew;
        }
        private clsUser(int _ID, string _UserName, string _FirstName, string _LastName, string _Phone, string _Email, string _Password, int _Permissions)
        {
            UserID = _ID;
            UserName = _UserName;
            FirstName = _FirstName;
            LastName = _LastName;
            Phone = _Phone;
            Email = _Email;
            Password = _Password;
            Permissions = _Permissions;

            _Mode = enMode.Update;
        }
        public static clsUser Find(string UserName)
        {
            string  FirstName = "", LastName = "", Phone = "", Email = "", Password = "";
            int Permissions = -1, id = -1;

            if (clsUserData.Find(ref id, ref UserName, ref FirstName, ref LastName, ref Phone, ref Email, ref Password, ref Permissions))
            {
                return new clsUser(id, UserName, FirstName, LastName, Phone, Email, Password, Permissions);
            }
            else
                return null;
        }
        public static clsUser FindByUserNameAndPassword(string user, string pass)
        {
            string UserName = user, FirstName = "", LastName = "", Phone = "", Email = "", Password = pass;
            int id = -1, Permissions = -1;

            if (clsUserData.FindByUserNameAndPassword(ref id, ref UserName, ref FirstName, ref LastName, ref Phone, ref Email, ref Password, ref Permissions))
            {
                return new clsUser(id, UserName, FirstName, LastName, Phone, Email, Password, Permissions);
            }
            else
                return null;
        }
        private bool _AddNewUser()
        {
            UserID = clsUserData.AddNewUser(UserName, FirstName, LastName, Phone, Email, Password, Permissions);

            return (UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(UserID, UserName, FirstName, LastName, Phone, Email, Password, Permissions);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    return _AddNewUser();
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
        public static bool DeleteUser(string UserName)
        {
            return clsUserData.DeleteUser(UserName);
        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }








    }


    public class clsClient
    {
        enum enMode { AddNew, Update };
        enMode _Mode;
        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PinCode { get; set; }
        public decimal Balance { get; set; }



        public clsClient()
        {
            ClientID = -1;
            AccountNumber = "";
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
            PinCode = "";
            Balance = -1;

            _Mode = enMode.AddNew;
        }
        private clsClient(int _ID, string _AccountNumber, string _FirstName, string _LastName, string _Phone, string _Email, string _PinCode, decimal _Balance)
        {
            ClientID = _ID;
            AccountNumber = _AccountNumber;
            FirstName = _FirstName;
            LastName = _LastName;
            Phone = _Phone;
            Email = _Email;
            PinCode = _PinCode;
            Balance = _Balance;

            _Mode = enMode.Update;
        }

        public static clsClient FindByID(int id)
        {
            string AccountNumber = "", FirstName = "", LastName = "", Phone = "", Email = "", Password = "";
            decimal Balance = -1;

            if (clsClientData.FindByID(id, ref AccountNumber, ref FirstName, ref LastName, ref Phone, ref Email, ref Password, ref Balance))
            {
                return new clsClient(id, AccountNumber, FirstName, LastName, Phone, Email, Password, Balance);
            }
            else
                return null;
        }
        public static clsClient FindByAccountNumber(string AccountNumber)
        {
            int ID = -1;
            string FirstName = "", LastName = "", Phone = "", Email = "", Password = "";
            decimal Balance = -1;

            if (clsClientData.FindByAccountNumber(ref ID, ref AccountNumber, ref FirstName, ref LastName, ref Phone, ref Email, ref Password, ref Balance))
            {
                return new clsClient(ID, AccountNumber, FirstName, LastName, Phone, Email, Password, Balance);
            }
            else
                return null;
        }


        private bool _AddNewClient()
        {
            ClientID = clsClientData.AddNewClient(AccountNumber, FirstName, LastName, Phone, Email, PinCode, Balance);

            return (ClientID != -1);
        }
        private bool _UpdateClient()
        {
            return clsClientData.UpdateClient(ClientID, AccountNumber, FirstName, LastName, Phone, Email, PinCode, Balance);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    return _AddNewClient();
                case enMode.Update:
                    return _UpdateClient();
            }
            return false;
        }

        public static bool DeleteClient(int id)
        {
            return clsClientData.DeleteClient(id);
        }
        public static bool DeleteClient(string AccountNumber)
        {
            return clsClientData.DeleteClient(AccountNumber);
        }

        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllClients();
        }

        public static bool IsExist(string AccountNumber)
        {
            return clsClientData.IsClientExist(AccountNumber);
        }

    }


    public class clsCurrency
    {
        enum enMode { AddNew, Update };
        enMode _Mode;
        public int CurrencyID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }


        private clsCurrency(int _ID, string _Country, string _Code, string _Name, decimal _Rate)
        {
            CurrencyID = _ID;
            Country = _Country;
            Code = _Code;
            Name = _Name;
            Rate = _Rate;

            _Mode = enMode.Update;
        }


        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyData.GetAllCurrencies();
        }

        public static clsCurrency FindByCode(string Code)
        {
            int ID = -1;
            string Country = "", Name = "";
            decimal Rate = -1;

            if (clsCurrencyData.FindByCode(ref ID, ref Country, ref Code, ref Name, ref Rate))
            {
                return new clsCurrency(ID, Country, Code, Name, Rate);
            }
            else
                return null;
        }
        public static clsCurrency FindByCountry(string Country)
        {
            int ID = -1;
            string Code = "", Name = "";
            decimal Rate = -1;

            if (clsCurrencyData.FindByCountry(ref ID, ref Country, ref Code, ref Name, ref Rate))
            {
                return new clsCurrency(ID, Country, Code, Name, Rate);
            }
            else
                return null;
        }


        public bool UpdateRate(decimal NewRate)
        {
            return clsCurrencyData.UpdateRate(CurrencyID, NewRate);
        }

    }
}
