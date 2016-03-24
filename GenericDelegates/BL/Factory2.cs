namespace GenericDelegates.BL
{
    public class Factory2
    {
        public static IHandler GetHandler(string mode)
        {
            IHandler handler;
            switch (mode)
            {
                case "API":
                    handler = new APIHandler();
                    break;

                case "SMPT":
                    handler = new SMTPHandler();
                    break;

                default:
                    handler = new SMTPHandler();
                    break;
            }

            return handler;
        }
    }
}