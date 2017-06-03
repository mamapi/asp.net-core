using System;

namespace aspnetcore.messages.Events
{
    public class CreateRecordFailed
    {
        public string Key { get; private set; }
        public string Reason { get; private set; }

        protected CreateRecordFailed()
        {
        }

        public CreateRecordFailed(string key, string reason)
        {
            Key = key;
            Reason = reason;
        }
    }

}
