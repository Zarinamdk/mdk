using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MDK.Lab7
{
    [Datacontract]
    public class Student:Person
    {        
        public Student(string name, string surname, int age, string gender, string myGroup, string vuz, string special)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Gender = gender;
            MyGroup = myGroup;  
            Vuz = vuz;
            Special = special;
        }

        //переменные
        private string _group = "";
        private string _vuz = "";
        private string _special = "";

        //свойства
        [DataMember]
        public string MyGroup
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }

        public string Vuz
        {
            get
            {
                return _vuz;
            }
            set
            {
                _vuz = value;
            }
        }

        public string Special
        {
            get
            {
                return _special;
            }
            set
            {
                _special = value;
            }
        }
    }
}
