using System;
using System.Collections;
using System.Collections.Generic;
namespace studentlib
{
    public class Student
    {
        public int Id;
        public string Fio;
        public string Data_R;
        public int Vozrast;
        public string Group;

        public Student()
        {
        }
        public void AddId(int id)
        {
            Id = id;
        }
        public void AddName(string f)
        {
            Fio = f;
        }

        public void AddData(string d)
        {
            Data_R = d;
        }
        public void AddVozrast(int v)
        {
            Vozrast = v;
        }

        public void AddGroup(string g)
        {
            Group = g;
        }
        List<Student> list = new List<Student>();
        public void addStudent(Student st)
        {
            list.Add(st);
        }
        public void delStudent(Student st)
        {
            list.Remove(st);
        }
        public void Show()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
        }
        public void del()
        {
            Student st = new Student();
            Console.WriteLine("Введите id:");
            st.AddId(Console.Read());
            Console.WriteLine("Введите фио:");
            st.AddName(Console.ReadLine());
            Console.WriteLine("Введите дату рождения:");
            st.AddData(Console.ReadLine());
            Console.WriteLine("Введите возраст:");
            st.AddVozrast(Console.Read());
            Console.WriteLine("Введите группу:");
            st.AddGroup(Console.ReadLine());
            delStudent(st);
        }
        public void Add()
        {
            int control;
            control = Convert.ToInt32(Console.ReadLine());
            switch (control)
            {

                case 1:
                    Student st = new Student();
                    Console.WriteLine("Введите id:");
                    st.AddId(Console.Read());
                    Console.WriteLine("Введите фио:");
                    st.AddName(Console.ReadLine());
                    Console.WriteLine("Введите дату рождения:");
                    st.AddData(Console.ReadLine());
                    Console.WriteLine("Введите возраст:");
                    st.AddVozrast(Console.Read());
                    Console.WriteLine("Введите группу:");
                    st.AddGroup(Console.ReadLine());
                    addStudent(st);
                    break;
                case 2:
                    Show();
                    break;
                default:
                    break;
            }
            Console.ReadLine();

        }
        public void findid()
        {
            Console.WriteLine("id :");
            int i = Console.Read();
            bool ft = false;
            foreach (var student in list)
            {
                Student st = (Student)student;
                if (i == st.Id)
                {
                    list.Add(st);
                    ft = true;
                }
            }
            if (!ft)
            {
                Console.WriteLine("Ошибка!");
                return;

            }
            foreach (var student in list)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public void find()
        {
            Console.WriteLine("Введите группу :");
            string i = Console.ReadLine();
            bool fg = false;
            foreach (var student in list)
            {
                Student st = (Student)student;
                if (i == st.Group)
                {
                    list.Add(st);
                    fg = true;
                }
            }
            if (!fg)
            {
                Console.WriteLine("Студенты не найден");
                return;

            }
            foreach (var student in list)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public int S
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть < 17");
                }
                else
                {
                    Vozrast = value;
                }
            }
            get { return Vozrast; }
        }
        public int A
        {
            set
            {
                if (value > 18)
                {
                    Console.WriteLine("Возраст должен быть > 17");
                }
                else
                {
                    Vozrast = value;
                }
            }
            get { return Vozrast; }
        }
        public void familia_s()
        {
            Console.WriteLine(S);
        }
        public void familia_a()
        {
            Console.WriteLine(A);
        }
        public void Phoisk()
        {
            Console.WriteLine("Введите фио:");
            string i = Console.ReadLine();
            bool ft = false;
            foreach (var student in list)
            {
                Student st = (Student)student;
                if (i == st.Fio)
                {
                    list.Add(st);
                    ft = true;
                }
            }
            if (!ft)
            {
                Console.WriteLine("Ошибка!");
                return;

            }
            foreach (var student in list)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}

