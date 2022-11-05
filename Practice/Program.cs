using Practice.Interfaces;
using Practice.Models;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit-Explicit
            //Manat manat = new Manat(100);

            //Dollar dollar = manat;

            //Dollar dollar = (Dollar)manat;

            //Console.WriteLine(dollar.Usd);
            #endregion

            #region GenericList
            //StringList list = new StringList();

            //list.Add("Rasul");
            //list.Add("Ali");
            //list.Add("Ramil");

            //list.GetAll();

            //IntList ages = new IntList();

            //ages.Add(15);
            //ages.Add(26);
            //ages.Add(41);

            //ages.GetAll();


            //DataList<int> ages = new DataList<int>();

            //ages.Add(15);
            //ages.Add(26);
            //ages.Add(41);

            //var resultages = ages.GetAll();

            //foreach (var item in resultages)
            //{
            //    Console.WriteLine(item);
            //}

            //DataList<string> names = new DataList<string>();

            //names.Add("Rasul");
            //names.Add("Ali");
            //names.Add("Ramil");

            //names.GetAll();
            #endregion

            //Repository<int> number1 = new Repository<int>();

            //Repository<DateTime> number2 = new Repository<DateTime>();

            //Repository<double> number3 = new Repository<double>();

            //Repository<string> name = new Repository<string>();

            //Repository<Student> student = new Repository<Student>();

            //Repository<Employee> employee1 = new Repository<Employee>();

            //Repository<Person> person1 = new Repository<Person>();


            //Repository<Student, Common> person2 = new Repository<Student, Common>();

            //Repository<Employee, Common> employee2 = new Repository<Employee, Common>();



            //DateTime start = DateTime.Now;
            //DateTime end = DateTime.Now.AddDays(10);

            //Console.WriteLine($"Start date: {start} - End date {end}");

            //GetProductsByDate(start, end, 1500);

        }

        //public static void GetProductsByDate(DateTime start, DateTime end, double price)
        //{
        //    DateTime productDate = DateTime.Now.AddDays(3);

        //    if ((productDate > start && productDate < end) && price > 1000)
        //    {
        //        Console.WriteLine("Yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No");
        //    }
        //}

    }


    #region GenericList
    public class DataList<T>
    {
        private T[] _datas;

        public DataList()
        {
            _datas = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public void GetAll()
        {
            foreach (var item in _datas)
            {
                Console.WriteLine(item);
            }
        }

        //public T[] GetAll()
        //{
        //    return _datas;
        //}
    }

    public class StringList
    {
        private string[] _arr;

        public StringList()
        {
            _arr = new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = str;
        }

        public void GetAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class IntList
    {
        private int[] _arr;

        public IntList()
        {
            _arr = new int[0];
        }

        public void Add(int number)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = number;
        }

        public void GetAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    #endregion


    #region Implicit-Explicit
    public class Dollar
    {
        public double Usd { get; set; }

        public Dollar(double dollar)
        {
            Usd = dollar;
        }
    }

    public class Manat
    {
        public double Azn { get; set; }

        public Manat(double manat)
        {
            Azn = manat;
        }

        public static implicit operator Dollar(Manat manat)
        {
            Dollar dollar = new Dollar(manat.Azn / 1.7);
            return dollar;
        }
    }

    //public class Manat
    //{
    //    public double Azn { get; set; }

    //    public Manat(double manat)
    //    {
    //        Azn = manat;
    //    }

    //    public static explicit operator Dollar(Manat manat)
    //    {
    //        Dollar dollar = new Dollar(manat.Azn / 1.7);
    //        return dollar;
    //    }
    //}
    #endregion
}