using GenericDelegates.BE;
using System;

namespace GenericDelegates
{
    public class SMTPSender : ISender
    {
        public void Send()
        {
            throw new NotImplementedException();
        }

        public void Send(Data data)
        {
            var item = (SMTP)data;
            Console.WriteLine(item.SMTPSetting);
        }

        public void Send(SMTPEntity entity)
        {
            throw new NotImplementedException();
        }
    }

    public class GenericSMTPSender : ISender<SMTPEntity>
    {
        public void Send(SMTPEntity entity)
        {
            throw new NotImplementedException();
        }
    }

    public class SMTPHandler : IHandler
    {
        public void Send<T>(T data)
        {
            throw new NotImplementedException();
        }
    }
}