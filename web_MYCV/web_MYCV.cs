using System;

namespace web_MYCV
{
    public class Web_MyCV
    {
        public DateTime Date { get; set; }

        public int IdLogin_Logcol { get; set; }

        public int IdUser_Logcol { get; set; }

        public int IdRecruiter_Log { get; set; }

        public int IdRegister_Log { get; set; }
        [View]
        public string GETALLid { get; set; }

        public int Login_View { get; set; }

        public int User_View { get; set; }

        public int Register_View { get; set; }

        public int Recruiter_View { get; set; }

        public int Replace_View { get; set; }

    }
}
