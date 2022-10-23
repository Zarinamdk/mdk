using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK.Lab7
{
    public class Student
    {
        public Student(string Name, int Age, string Gender, string Group, string Vuz, string Special)
        {
            Name = _name;
            Age = _age;
            Gender = _gender;
            Group = _group;
            Vuz = _vuz;
            Special = _special;
        }

        private string _name = "";
        private int _age;
        private string _gender = "";
        private string _group = "";
        private string _vuz = "";
        private string _special = "";

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
        public string Gender
        {

            get
            {
                return _gender;
            }
            set
            {
                if (value == "man" || value == "woman")
                {
                    _gender = value;
                }
            }
        }
        public string Group
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
