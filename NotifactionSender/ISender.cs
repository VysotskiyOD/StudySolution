using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifactionSender
{
    public interface ISender
    {
        void Send(string message);
    }
}
