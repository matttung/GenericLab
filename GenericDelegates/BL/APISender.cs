using GenericDelegates.BE;
using System;

namespace GenericDelegates.BL
{
    public class APISender : ISender
    {
        public void Send()
        {
            throw new NotImplementedException();
        }

        public void Send(Data data)
        {
            throw new NotImplementedException();
        }

        public void Send(APIEntity entity)
        {
            throw new NotImplementedException();
        }
    }

    public class GenericAPISender : ISender<APIEntity>
    {
        public void Send(APIEntity entity)
        {
            throw new NotImplementedException();
        }
    }

    public class APIHandler : IHandler
    {
        public void Send<T>(T data)
        {
            throw new NotImplementedException();
        }
    }
}