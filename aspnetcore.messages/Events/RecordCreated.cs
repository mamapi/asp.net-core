using System;

namespace aspnetcore.messages.Events
{
    public class RecordCreated
    {
        public string Key { get; private set; }

        protected RecordCreated()
        {
            
        }

        public RecordCreated(string key)
        {
            Key = key;
        }
    }

}
