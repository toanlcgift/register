using System;
using System.Collections.Generic;

namespace Register.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Secpassword { get; set; }
        public string Password { get; set; }
        public string Rowpass { get; set; }
        public int Trytocard { get; set; }
        public int Changepwdret { get; set; }
        public int Active { get; set; }
        public int LockPassword { get; set; }
        public int Trytohack { get; set; }
        public int Newlocked { get; set; }
        public int Locked { get; set; }
        public int LastLoginIp { get; set; }
        public int PasspodMode { get; set; }
        public string Email { get; set; }
        public int Cmnd { get; set; }
        public DateTime? Dob { get; set; }
        public int Coin { get; set; }
        public int? DateCreate { get; set; }
        public DateTime? LockedTime { get; set; }
        public int Testcoin { get; set; }
        public int LockedCoin { get; set; }
        public int Bklactivenew { get; set; }
        public int Bklactive { get; set; }
        public int NExtpoin1 { get; set; }
        public int NExtpoin2 { get; set; }
        public int NExtpoin4 { get; set; }
        public int NExtpoin5 { get; set; }
        public int NExtpoin6 { get; set; }
        public int NExtpoin7 { get; set; }
        public int Scredit { get; set; }
        public int NTimeActiveBkl { get; set; }
        public int NLockTimeCard { get; set; }
    }
}
