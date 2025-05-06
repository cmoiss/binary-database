using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace binary_database.Model
{
    public class User
    {
        public string Name {  get; set; }
        public long DigitalCode {  get; set; }

        public User(string name, long digitalCode)
        {
            this.Name = name;
            this.DigitalCode = digitalCode;
        }
    }
}