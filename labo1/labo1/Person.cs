﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo1
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get{ return name;}

            set{ name = value; }
        }

        public int Age {

            get { return age; }
            set { age = (value > 0)? value : 1; }
        }

        public Person(String name,int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " agé de " + Age + " ans";
        }
        
        
    }
}
