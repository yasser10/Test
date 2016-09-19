using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo1
{
    class Activity
    {
        private string titre;
        private bool compulsary;

        public bool Compulsary
        {
            get { return compulsary; }
            set { compulsary = value; }
        }


        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public Activity(string titre,bool compulsary)
        {
            Titre = titre;
            Compulsary = compulsary;
        }

        public override string ToString()
        {
            string mess = "";
            if(Compulsary)
              mess+=  Titre +" est obligatoire";
            return mess;
        }
    }
}
