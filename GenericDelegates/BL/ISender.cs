namespace GenericDelegates
{
    public interface ISender
    {
        void Send();

        void Send(Data data);
    }

    // Generic Interface
    public interface ISender<T>
    {
        void Send(T data);
    }

    // Generic Method
    public interface IHandler
    {
        void Send<T>(T data);
    }

    public interface IWorker
    {
        void Send(Data data);
    }

    public class Data
    {
        public string Title;
        public string Context;
    }
}