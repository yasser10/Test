﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo1
{
    class Pupil : Person
    {
        public int Grade { get; set; }

        public List<Activity> ListActivities{get;  set;}


        public char[] TabEval { get; set; }


        public Pupil (String name,int age,int grade) : base(name, age)
        {
            Grade = grade;
            ListActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(String name, int age) : this(name, age,1){ }

        public void addActivity(Activity a)
        {
            ListActivities.Add(a);
        }
        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = ListActivities.Count();
            if (cptActivities == 0)
                {
                    ch += "n’a pas encore choisi d’activité";
                }
            else
                { 
                ch += " a choisi les activités suivantes: \n";
                foreach (Activity activity in ListActivities) { ch += activity+"\n"; }
                }

            return ch;
        }

        public void AddEvaluation (String title = null, char evaluation = 'S')
        {
            int i = 0;
            foreach(Activity activity in ListActivities)
            {
                if (title == activity.Titre)
                    TabEval[i] = evaluation;
                else
                    i++;
            }
        }


    }
}
