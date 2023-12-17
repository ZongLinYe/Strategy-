using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2._1.H_交友配對系統
{
    public class Individual
    {
        private int _id;
        private Gender _gender;
        private int _age;
        private string _intro;
        private List<string> _habits;
        public Individual(int id, Gender gender, int age, string intro, List<string> habits, Coord coord)
        {
            Id = id;
            Gender = gender;
            Age = age;
            Intro = intro;
            Habits = habits;
            Coord = coord;
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                // id is unique & positive
                if (value <= 0)
                {
                    throw new ArgumentException("id must be positive");
                }
                _id = value;
            }
        }
        public Gender Gender
        {
            get { return _gender; }
            set
            {
                if (value.Equals(Gender.Unknown))
                {
                    throw new ArgumentException("gender is male or female");
                }
                _gender = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("age must be greater than  18");
                }
                _age = value;
            }
        }
        public string Intro
        {
            get { return _intro; }
            set
            {
                if (value.Length > 200)
                {
                    throw new ArgumentException("intro  words less than 200");
                }
                _intro = value;
            }
        }
        public List<string> Habits
        {
            get { return _habits; }
            set
            {
                foreach (var item in value)
                {
                    if (item.Length > 10 || item.Length == 0)
                    {
                        throw new ArgumentException("one habit word greater than 0 and less 10");
                    }
                }
                _habits = value;
            }
        }
        public Individual Matched { get; private set; }
        public Coord Coord { get; set; }
        public void Match(Individual matched)
        {
            if (matched == this)
            {
                throw new ArgumentException("Must not match one to himself");
            }
            // do something
            Matched = matched;
        }

    }
}
