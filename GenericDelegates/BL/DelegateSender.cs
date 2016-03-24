using GenericDelegates.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates.BL
{
    public class DelegateSender
    {
        public delegate void DelegateSend<T>(T data);

        public void SMTPSend(SMTPEntity entity)
        {
            throw new NotImplementedException();
        }

        public void APISend(APIEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Send<T>(Action<T> delegateion)
        {

        }
    }
}
