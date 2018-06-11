using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyTBVT.Common
{
    public static class CommonConstant
    {
        public static readonly string MESSAGE_INFO ="THÔNG BÁO";

        public static readonly string MESSAGE_WARNING = "CẢNH BÁO";

        public static bool CheckPhoneNumber(string strPhone)
        {
            bool match = Regex.IsMatch(strPhone, @"(09|01|08|[2|6|8|9])+([0-9]{8})\b");
            return match;
        }

        public static readonly string STATUS_DADUYET = "Đã Duyệt";

        public static readonly string STATUS_MOI = "Mới";

        public static readonly string STATUS_DANHAP = "Đã Nhập";
    }
}
