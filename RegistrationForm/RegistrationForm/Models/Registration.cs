using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class AccountInfo
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private string _repassword;
        public string RePassword
        {
            get { return _repassword; }
            set { _repassword = value; }
        }
    }

    public class PersonalInfo
    {
        private string _sex;

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private string _birthday;

        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        private string _currentaddress;

        public string Currentaddress
        {
            get { return _currentaddress; }
            set { _currentaddress = value; }
        }
        private string _phonenumber;

        public string Phonenumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }
    }

    public class RegistrationAccount
    {
        private AccountInfo _accountinfo;

        public AccountInfo Accountinfo
        {
            get { return _accountinfo; }
            set { _accountinfo = value; }
        }
        private PersonalInfo _personalInfo;

        public PersonalInfo PersonalInfo
        {
            get { return _personalInfo; }
            set { _personalInfo = value; }
        }

        public RegistrationAccount()
        {
            _accountinfo = new AccountInfo();
            _personalInfo = new PersonalInfo();
        }
    }


    public class SexyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}