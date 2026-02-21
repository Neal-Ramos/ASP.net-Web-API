using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id {get; private set;}
        public string Name {get; set;} = null!;

        private User(){ }// for ef core

        public User(string name)
        {
            Id = Guid.NewGuid();
            Name = name; 
        }
    }
}