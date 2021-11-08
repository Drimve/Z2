using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z2._3
{
    public class Service
    {
        Dictionary<string, string> storage = new Dictionary<string, string>();

        public void Add(string key, string value)
        {
            storage.Add(key, value);
        }

        public void Del(string key)
        {
            storage.Remove(key);
        }

        public Dictionary<string, string> Storage()
        {
            Dictionary<string, string> list = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> keyValue in storage)//расписать
            {
                list.Add(keyValue.Key, keyValue.Value);
            }

            return list;
        }
    }
}
