using System;
using System.Collections.Generic;
using System.Text;

namespace InternalSystem.Entity
{
    public class TimeSheet
    {
        public TimeSheet()
        {
            OID = 0;
        }

        /// <summary>
		/// OID
        /// </summary>
		private int _oid;

        public int OID
        {
            get { return _oid; }
            set { _oid = value; }
        }

        /// <summary>
        /// WorkingDate
        /// </summary>
        private DateTime _workingdate;

        public DateTime WorkingDate
        {
            get { return _workingdate; }
            set { _workingdate = value; }
        }

        /// <summary>
        /// GOPunchTime
        /// </summary>
        private string _gopunchtime;

        public string GOPunchTime
        {
            get { return _gopunchtime; }
            set { _gopunchtime = value; }
        }

        /// <summary>
        /// OffPunchTime
        /// </summary>
        private string _offpunchtime;

        public string OffPunchTime
        {
            get { return _offpunchtime; }
            set { _offpunchtime = value; }
        }

        /// <summary>
        /// UserID
        /// </summary>
        private string _userid;

        public string UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }

        /// <summary>
        /// MacID
        /// </summary>
        private string _macid;

        public string MacID
        {
            get { return _macid; }
            set { _macid = value; }
        }

        /// <summary>
        /// AbPunchCheck
        /// </summary>
        private string _abpunchcheck;

        public string AbPunchCheck
        {
            get { return _abpunchcheck; }
            set { _abpunchcheck = value; }
        }

        /// <summary>
        /// LePunchCheck
        /// </summary>
        private string _lepunchcheck;

        public string LePunchCheck
        {
            get { return _lepunchcheck; }
            set { _lepunchcheck = value; }
        }

        /// <summary>
        /// PunchLocation
        /// </summary>
        private string _punchlocation;

        public string PunchLocation
        {
            get { return _punchlocation; }
            set { _punchlocation = value; }
        }

        /// <summary>
        /// GoStatus
        /// </summary>
        private string _gostatus;

        public string GoStatus
        {
            get { return _gostatus; }
            set { _gostatus = value; }
        }

        /// <summary>
        /// OffStatus
        /// </summary>
        private string _offstatus;

        public string OffStatus
        {
            get { return _offstatus; }
            set { _offstatus = value; }
        }

        /// <summary>
        /// ViewsGoStatus
        /// </summary>
        private string _viewsgostatus;

        public string ViewsGoStatus
        {
            get { return _viewsgostatus; }
            set { _viewsgostatus = value; }
        }

        /// <summary>
        /// ViewsOffStatus
        /// </summary>
        private string _viewsoffstatus;

        public string ViewsOffStatus
        {
            get { return _viewsoffstatus; }
            set { _viewsoffstatus = value; }
        }

        /// <summary>
        /// LateHours
        /// </summary>
        private string _latehours;

        public string LateHours
        {
            get { return _latehours; }
            set { _latehours = value; }
        }

        /// <summary>
        /// EarlyLeave
        /// </summary>
        private string _earlyleave;

        public string EarlyLeave
        {
            get { return _earlyleave; }
            set { _earlyleave = value; }
        }

        /// <summary>
        /// FieldStatus
        /// </summary>
        private string _fieldstatus;

        public string FieldStatus
        {
            get { return _fieldstatus; }
            set { _fieldstatus = value; }
        }
    }
}