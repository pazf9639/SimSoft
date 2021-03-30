using System;

namespace SimSift.DAL
{
    internal class SqlConection
    {
        private string conString;

        public SqlConection(string conString)
        {
            this.conString = conString;
        }

        internal T QuerySingle<T>(string query, object commandType, int commandTimeout)
        {
            throw new NotImplementedException();
        }
    }
}