namespace DesignLabb1.Service
{
    public interface IUserSession
    {
        string GetSessionId();
        void SetSession(string sessionId);
        void SetSessionId(string v);
    }
}
