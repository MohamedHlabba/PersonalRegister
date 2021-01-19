using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
   
    public  class Register
    {
        List<Employe> employes { get; set; }
       
       public Register()
        {

            employes = new List<Employe>();

        }
        public void addemploye (Employe em)

        {
            employes.Add(em);

        }
        public List<String> affichemplyee()
        {
            List<String> result = new List<String>();
            foreach(Employe em in employes)
            {
                result.Add("employe name " +em.name + " employee salary : " +em.Salary );
            }
            return result;
        }
    }
}
