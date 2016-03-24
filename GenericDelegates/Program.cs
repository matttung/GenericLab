using GenericDelegates.BE;
using GenericDelegates.BL;
using System;

namespace GenericDelegates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mode = "SMPT";

            ParameterInterface(mode);

            GenericInterface(mode);
            GenericMethod(mode);

            Console.Read();
        }

        private static void GenericInterface(string mode)
        {
            switch (mode)
            {
                case "API":
                    ISender<APIEntity> genericSender = new GenericAPISender();
                    genericSender.Send(new APIEntity());
                    break;

                case "SMPT":
                    ISender<SMTPEntity> genericSender2 = new GenericSMTPSender();
                    genericSender2.Send(new SMTPEntity());
                    break;

                default:
                    break;
            }
        }

        private static void GenericMethod(string mode)
        {
            IHandler handler = Factory2.GetHandler(mode);
            switch (mode)
            {
                case "API":
                    handler.Send<APIEntity>(new APIEntity());
                    break;

                case "SMPT":
                    handler.Send<SMTPEntity>(new SMTPEntity());
                    break;

                default:
                    break;
            }
        }

        private static void ParameterInterface(string mode)
        {
            ISender sender = Factory.GetSender(mode);
            Data item = Factory.GetData(mode, "ValuesForDifferentMode");

            sender.Send(item);
        }
    }
}