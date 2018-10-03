using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbuz
{
    public interface ITwilio
    {
        void SmsSend(string accountSid, string accountToken, string ToPhoneNumber, int verifyCode);
    }
}
