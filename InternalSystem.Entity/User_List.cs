using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InternalSystem.Entity
{
    [Table("Company")]
    public class User_List
    {
        public User_List()
        {
            pk_User = 0;
            UserName = "";
            Password = "";
            TypeID = 0;
            fk_Department = 0;
            RoleValue = 0;
            RoleList = "";
            Position = 0;
            Number = "";
            Skin = "";
            Language = "";
            IsLock = true;
            LastLoginIP = "";
            LastLoginTime=DateTime.Now;
            NickName = "";
            FullName = "";
            FirstName = "";
            MiddleName = "";
            LastName = "";
            Phone1 = "";
            Phone2 = "";
            Email1 = "";
            Email2 = "";
            Fax = "";
            Line = "";
            Wechat = "";
            QQ = "";
            Facebook = "";
            Twitter = "";
            Linkedin = "";
            ZipCode = "";
            Place = "";
            Address1 = "";
            Address2 = "";
            Province = 0;
            City = 0;
            County = 0;
            Zone = 0;
            Sex = 0;
            Height = 0;
            Weight = 0;
            Birthday=DateTime.Now;
            Education = "";
            School = "";
            ImagePath1 = "";
            ImagePath2 = "";
            IDCardPath = "";
            ResumePath = "";
           
        }

        /// <summary>
        /// pk_User
        /// </summary>
        private int _pk_user;

        public int pk_User
        {
            get { return _pk_user; }
            set { _pk_user = value; }
        }

        /// <summary>
        /// UserName
        /// </summary>
        private string _username;

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        /// <summary>
        /// Password
        /// </summary>
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        /// TypeID
        /// </summary>
        private int _typeid;

        public int TypeID
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        /// <summary>
        /// fk_Department
        /// </summary>
        private int _fk_department;

        public int fk_Department
        {
            get { return _fk_department; }
            set { _fk_department = value; }
        }

        /// <summary>
        /// RoleValue
        /// </summary>
        private int _rolevalue;

        public int RoleValue
        {
            get { return _rolevalue; }
            set { _rolevalue = value; }
        }

        /// <summary>
        /// RoleList
        /// </summary>
        private string _rolelist;

        public string RoleList
        {
            get { return _rolelist; }
            set { _rolelist = value; }
        }

        /// <summary>
        /// Position
        /// </summary>
        private int _position;

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        /// <summary>
        /// Number
        /// </summary>
        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        /// <summary>
        /// Skin
        /// </summary>
        private string _skin;

        public string Skin
        {
            get { return _skin; }
            set { _skin = value; }
        }

        /// <summary>
        /// Language
        /// </summary>
        private string _language;

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        /// <summary>
        /// IsLock
        /// </summary>
        private bool _islock;

        public bool IsLock
        {
            get { return _islock; }
            set { _islock = value; }
        }

        /// <summary>
        /// LastLoginIP
        /// </summary>
        private string _lastloginip;

        public string LastLoginIP
        {
            get { return _lastloginip; }
            set { _lastloginip = value; }
        }

        /// <summary>
        /// LastLoginTime
        /// </summary>
        private DateTime? _lastlogintime;

        public DateTime? LastLoginTime
        {
            get { return _lastlogintime; }
            set { _lastlogintime = value; }
        }

        /// <summary>
        /// NickName
        /// </summary>
        private string _nickname;

        public string NickName
        {
            get { return _nickname; }
            set { _nickname = value; }
        }

        /// <summary>
        /// FullName
        /// </summary>
        private string _fullname;

        public string FullName
        {
            get { return _fullname; }
            set { _fullname = value; }
        }

        /// <summary>
        /// FirstName
        /// </summary>
        private string _firstname;

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        /// <summary>
        /// MiddleName
        /// </summary>
        private string _middlename;

        public string MiddleName
        {
            get { return _middlename; }
            set { _middlename = value; }
        }

        /// <summary>
        /// LastName
        /// </summary>
        private string _lastname;

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        /// <summary>
        /// Phone1
        /// </summary>
        private string _phone1;

        public string Phone1
        {
            get { return _phone1; }
            set { _phone1 = value; }
        }

        /// <summary>
        /// Phone2
        /// </summary>
        private string _phone2;

        public string Phone2
        {
            get { return _phone2; }
            set { _phone2 = value; }
        }

        /// <summary>
        /// Email1
        /// </summary>
        private string _email1;

        public string Email1
        {
            get { return _email1; }
            set { _email1 = value; }
        }

        /// <summary>
        /// Email2
        /// </summary>
        private string _email2;

        public string Email2
        {
            get { return _email2; }
            set { _email2 = value; }
        }

        /// <summary>
        /// Fax
        /// </summary>
        private string _fax;

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        /// <summary>
        /// Line
        /// </summary>
        private string _line;

        public string Line
        {
            get { return _line; }
            set { _line = value; }
        }

        /// <summary>
        /// Wechat
        /// </summary>
        private string _wechat;

        public string Wechat
        {
            get { return _wechat; }
            set { _wechat = value; }
        }

        /// <summary>
        /// QQ
        /// </summary>
        private string _qq;

        public string QQ
        {
            get { return _qq; }
            set { _qq = value; }
        }

        /// <summary>
        /// Facebook
        /// </summary>
        private string _facebook;

        public string Facebook
        {
            get { return _facebook; }
            set { _facebook = value; }
        }

        /// <summary>
        /// Twitter
        /// </summary>
        private string _twitter;

        public string Twitter
        {
            get { return _twitter; }
            set { _twitter = value; }
        }

        /// <summary>
        /// Linkedin
        /// </summary>
        private string _linkedin;

        public string Linkedin
        {
            get { return _linkedin; }
            set { _linkedin = value; }
        }

        /// <summary>
        /// ZipCode
        /// </summary>
        private string _zipcode;

        public string ZipCode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        /// <summary>
        /// Place
        /// </summary>
        private string _place;

        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }

        /// <summary>
        /// Address1
        /// </summary>
        private string _address1;

        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }

        /// <summary>
        /// Address2
        /// </summary>
        private string _address2;

        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }

        /// <summary>
        /// Province
        /// </summary>
        private int _province;

        public int Province
        {
            get { return _province; }
            set { _province = value; }
        }

        /// <summary>
        /// City
        /// </summary>
        private int _city;

        public int City
        {
            get { return _city; }
            set { _city = value; }
        }

        /// <summary>
        /// County
        /// </summary>
        private int _county;

        public int County
        {
            get { return _county; }
            set { _county = value; }
        }

        /// <summary>
        /// Zone
        /// </summary>
        private int _zone;

        public int Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        /// <summary>
        /// Sex
        /// </summary>
        private int _sex;

        public int Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// Height
        /// </summary>
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// Weight
        /// </summary>
        private int _weight;

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        /// <summary>
        /// Birthday
        /// </summary>
        private DateTime? _birthday;

        public DateTime? Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        /// <summary>
        /// Education
        /// </summary>
        private string _education;

        public string Education
        {
            get { return _education; }
            set { _education = value; }
        }

        /// <summary>
        /// School
        /// </summary>
        private string _school;

        public string School
        {
            get { return _school; }
            set { _school = value; }
        }

        /// <summary>
        /// ImagePath1
        /// </summary>
        private string _imagepath1;

        public string ImagePath1
        {
            get { return _imagepath1; }
            set { _imagepath1 = value; }
        }

        /// <summary>
        /// ImagePath2
        /// </summary>
        private string _imagepath2;

        public string ImagePath2
        {
            get { return _imagepath2; }
            set { _imagepath2 = value; }
        }

        /// <summary>
        /// IDCardPath
        /// </summary>
        private string _idcardpath;

        public string IDCardPath
        {
            get { return _idcardpath; }
            set { _idcardpath = value; }
        }

        /// <summary>
        /// ResumePath
        /// </summary>
        private string _resumepath;

        public string ResumePath
        {
            get { return _resumepath; }
            set { _resumepath = value; }
        }

        /// <summary>
        /// Wages
        /// </summary>
        private decimal _wages;

        public decimal Wages
        {
            get { return _wages; }
            set { _wages = value; }
        }

        /// <summary>
        /// BankAccount
        /// </summary>
        private string _bankaccount;

        public string BankAccount
        {
            get { return _bankaccount; }
            set { _bankaccount = value; }
        }

        /// <summary>
        /// IDNumber
        /// </summary>
        private string _idnumber;

        public string IDNumber
        {
            get { return _idnumber; }
            set { _idnumber = value; }
        }

        /// <summary>
        /// Source
        /// </summary>
        private string _source;

        public string Source
        {
            get { return _source; }
            set { _source = value; }
        }

        /// <summary>
        /// Note
        /// </summary>
        private string _note;

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        /// <summary>
        /// Remark
        /// </summary>
        private string _remark;

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        /// <summary>
        /// EntryTime
        /// </summary>
        private DateTime? _entrytime;

        public DateTime? EntryTime
        {
            get { return _entrytime; }
            set { _entrytime = value; }
        }

        /// <summary>
        /// IsQuit
        /// </summary>
        private bool _isquit;

        public bool IsQuit
        {
            get { return _isquit; }
            set { _isquit = value; }
        }

        /// <summary>
        /// QuitTime
        /// </summary>
        private DateTime? _quittime;

        public DateTime? QuitTime
        {
            get { return _quittime; }
            set { _quittime = value; }
        }

        /// <summary>
        /// ShowHistory
        /// </summary>
        private int _showhistory;

        public int ShowHistory
        {
            get { return _showhistory; }
            set { _showhistory = value; }
        }

        /// <summary>
        /// fk_Company
        /// </summary>
        private int _fk_company;

        public int fk_Company
        {
            get { return _fk_company; }
            set { _fk_company = value; }
        }

        /// <summary>
        /// CreateUser
        /// </summary>
        private int _createuser;

        public int CreateUser
        {
            get { return _createuser; }
            set { _createuser = value; }
        }

        /// <summary>
        /// CreateDate
        /// </summary>
        private DateTime? _createdate;

        public DateTime? CreateDate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }

        /// <summary>
        /// ModifyUser
        /// </summary>
        private int _modifyuser;

        public int ModifyUser
        {
            get { return _modifyuser; }
            set { _modifyuser = value; }
        }

        /// <summary>
        /// ModifyDate
        /// </summary>
        private DateTime? _modifydate;

        public DateTime? ModifyDate
        {
            get { return _modifydate; }
            set { _modifydate = value; }
        }

        /// <summary>
        /// DeviceID
        /// </summary>
        private string _deviceid;

        public string DeviceID
        {
            get { return _deviceid; }
            set { _deviceid = value; }
        }

        /// <summary>
        /// app_code
        /// </summary>
        private string _app_code;

        public string app_code
        {
            get { return _app_code; }
            set { _app_code = value; }
        }

        /// <summary>
        /// Shrine
        /// </summary>
        private string _shrine;

        public string Shrine
        {
            get { return _shrine; }
            set { _shrine = value; }
        }

        /// <summary>
        /// UniqueID
        /// </summary>
        private string _uniqueid;

        public string UniqueID
        {
            get { return _uniqueid; }
            set { _uniqueid = value; }
        }

        /// <summary>
        /// 地区
        /// </summary>
        private string _area;

        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        /// <summary>
        /// 固定补助标准
        /// </summary>
        private string _fixedsubsidy;

        public string FixedSubsidy
        {
            get { return _fixedsubsidy; }
            set { _fixedsubsidy = value; }
        }

        /// <summary>
        /// 其他项标准
        /// </summary>
        private string _othercriteria;

        public string OtherCriteria
        {
            get { return _othercriteria; }
            set { _othercriteria = value; }
        }

        /// <summary>
        /// 社保号账号
        /// </summary>
        private string _socialsecurityn;

        public string SocialSecurityN
        {
            get { return _socialsecurityn; }
            set { _socialsecurityn = value; }
        }

        /// <summary>
        /// 公积金账号
        /// </summary>
        private string _providentfundn;

        public string ProvidentFundN
        {
            get { return _providentfundn; }
            set { _providentfundn = value; }
        }

        /// <summary>
        /// 社保基数
        /// </summary>
        private string _socialsecuritybase;

        public string SocialSecurityBase
        {
            get { return _socialsecuritybase; }
            set { _socialsecuritybase = value; }
        }

        /// <summary>
        /// 公积金基数
        /// </summary>
        private string _providentfundbase;

        public string ProvidentFundBase
        {
            get { return _providentfundbase; }
            set { _providentfundbase = value; }
        }

        /// <summary>
        /// 转正时间
        /// </summary>
        private DateTime? _turnpositivetime;

        public DateTime? TurnPositiveTime
        {
            get { return _turnpositivetime; }
            set { _turnpositivetime = value; }
        }

        /// <summary>
        /// 合同开始时间
        /// </summary>
        private DateTime? _contractstarttime;

        public DateTime? ContractStartTime
        {
            get { return _contractstarttime; }
            set { _contractstarttime = value; }
        }

        /// <summary>
        /// 合同到期时间
        /// </summary>
        private DateTime? _contractexpirationtime;

        public DateTime? ContractExpirationTime
        {
            get { return _contractexpirationtime; }
            set { _contractexpirationtime = value; }
        }

        /// <summary>
        /// 用工形式
        /// </summary>
        private string _employmentforms;

        public string EmploymentForms
        {
            get { return _employmentforms; }
            set { _employmentforms = value; }
        }

        /// <summary>
        /// 专业
        /// </summary>
        private string _profession;

        public string Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }

        /// <summary>
        /// 户籍所在地
        /// </summary>
        private string _domicile;

        public string Domicile
        {
            get { return _domicile; }
            set { _domicile = value; }
        }

        /// <summary>
        /// 户籍类型
        /// </summary>
        private string _domiciletype;

        public string DomicileType
        {
            get { return _domiciletype; }
            set { _domiciletype = value; }
        }

        /// <summary>
        /// 紧急联系人
        /// </summary>
        private string _emergencycontact;

        public string EmergencyContact
        {
            get { return _emergencycontact; }
            set { _emergencycontact = value; }
        }

        /// <summary>
        /// 关系
        /// </summary>
        private string _relationship;

        public string Relationship
        {
            get { return _relationship; }
            set { _relationship = value; }
        }

        /// <summary>
        /// 电话
        /// </summary>
        private string _emergencycall;

        public string EmergencyCall
        {
            get { return _emergencycall; }
            set { _emergencycall = value; }
        }

        /// <summary>
        /// 工资标准
        /// </summary>
        private string _wage;

        public string Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }
    }
}