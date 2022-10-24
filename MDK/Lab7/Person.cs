using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MDK.Lab7
{
    [DataContract]
    public class Person
    {
        //переменные
        private string _name = "";
        private string _surname = "";
        private int _age = 0;
        private string _gender = "";

        //свойства
        [DataMember]
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
        [DataMember]
        public string SurName
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        [DataMember]
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
        [DataMember]
        public string Gender
        {

            get
            {
                return _gender;
            }
            set
            {
                if (value == "мужской" || value == "женский")
                {
                    _gender = value;
                }
            }
        }
    }
}
