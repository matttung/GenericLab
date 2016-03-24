using GenericDelegates.BE;
using System;

namespace GenericDelegates.BL
{
    public class Factory3
    {
        public static void Send(string mode, string otherValueForSMTP)
        {
            switch (mode)
            {
                case "API":
                    DelegateSend<APIEntity> d1 = APISend;
                    d1(new APIEntity());
                    break;

                case "SMPT":
                    DelegateSend<SMTPEntity> d2 = SMTPSend;
                    d2(new SMTPEntity());
                    break;

                default:
                    break;
            }
        }

        public delegate void DelegateSend<T>(T data);

        public static void SMTPSend(SMTPEntity entity)
        {
            throw new NotImplementedException();
        }

        public static void APISend(APIEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}