namespace webMvc.Services
{
    internal class sqlConnection
    {
        public sqlConnection(string connect)
        {
            Connect = connect;
        }

        public string Connect { get; }
    }
}