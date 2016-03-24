using System;
using GenericDelegates.BE;

namespace GenericDelegates.BL
{
    public class Factory
    {
        public static ISender GetSender(string mode)
        {
            ISender sender;
            switch (mode)
            {
                case "API":
                    sender = new APISender();
                    break;

                case "SMPT":
                    sender = new SMTPSender();
                    break;

                default:
                    sender = new SMTPSender();
                    break;
            }

            return sender;
        }


        public static Data GetData(string mode, string otherValueForSMTP)
        {
            switch (mode)
            {
                case "API":
                    return new API();
                case "SMPT":
                    return new SMTP() { SMTPSetting = otherValueForSMTP };
                default:
                    return new SMTP() { SMTPSetting = otherValueForSMTP };
            }
        }
    }
}