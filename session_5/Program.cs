namespace session_5
{
    internal class Program
    {

       
        static void Main(string[] args)
        {


            #region v1

            // boxing and unboxing 
            // boxing : casting fro valuetype to reference
            //unboxing: casting from referenct to value

            object o1;
            o1 = 3;
            o1=1.5;
            o1='a';
            o1 = true;

            int x = 5;
             o1 =/*(object)*/ x;
            // implicit casting
            //parent = child =>child is parent




            #endregion

            #region V2
            //int x = 500;
            //x = null; // Invalid

            //Nullable<int> y = 500;
            //int? y = 500;
            //y = null;

            //Console.WriteLine(y.HasValue);
            //Console.WriteLine(y.Value); 



            //int x = 10;
            //int? y = x; // Valid, Implicit Casting[Safe]

            //int? y = 10;
            //y = null;
            //int x = (int)y; // Explicit Casting
            //int x;

            //if(y is not null)
            //{
            //    x = y.Value;
            //    //x = (int)y;
            //}
            //else
            //{
            //    x = 0;
            //}

            //if (y.HasValue)
            //{
            //    x = y.Value;
            //    //x = (int)y;
            //}
            //else
            //{
            //    x = 0;
            //}

            //condition ? true : false 
            //x = y.HasValue ? y.Value : 0;

            //x = y.GetValueOrDefault(); 
            #endregion
            #region V3


            //string s = "Hello world";

            //string s = null;

            //Console.WriteLine(s); 


            #endregion

            #region V4
            //region Null Operators
            //Console.Write("Enter Your Name: ");
            //string name = Console.ReadLine() ?? "No Name";

            //Console.WriteLine(name);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //numbers = null!;
            //numbers = null;
            //if(numbers is not null)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            //for (int i = 0; i < numbers?.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} 
            #endregion

            #region V5
            // What You Can write Inside?
            // 1. Class
            // 2. Struct
            // 3. Interface
            // 4. Enum

            // Access Modifier Allowed Inside?
            // 1. Internal [Default]
            // 2. Public

            //Class Library
            //Product p1 = new Product();
            //p1.Id = 1;
            //p1.Name = "Tea";

            //Console.WriteLine(p1.ToString()); 
           

          // Access Modifiers [Private, Internal, Public]
            //TypeA a = new TypeA();

            //Console.WriteLine(a.x);
            //Console.WriteLine(a.y);
            //Console.WriteLine(a.z);


            //a.MethodA(); 
            //access modifiers inside the namespace;
            // 1. internal:inside thte same project
            //2. public: everywhere


            /*
              access modiferes inside the class
            1- private
            2- private protected
            3- protected
            4- internal 
            5- internal protected
            6- public

            access inside the struct
            1 private 
            2 internal 
            public
              
              
              
              
             */


            #endregion




        }
    }
}
