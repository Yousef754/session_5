namespace session_5
{
    internal class Program
    {

        #region weekday
        enum Weekday
        {

            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            sunday
        }
        #endregion

        #region seasonmonth

        
        [Flags]
        enum seasonsmonth{

            
            January = 1,       
            February = 2,      
            March = 4,         
            April = 8,         
            May = 16,          
            June = 32,         
            July = 64,         
            August = 128,      
            September = 256,   
            October = 512,     
            November = 1024,   
            December = 2048



        }
        #endregion

        #region premission
        [Flags]
        enum premission
        {
            read=1,
            write=2,
            delete=4,
            execute=8
        }

        #endregion

        static void Main(string[] args)
        {

            #region q1
            /*
            
            Create an enum called "WeekDays" with the days of the week 
            (Monday to Sunday) as its members. Then, write a C# program that prints
            out all the days of the week using this enum
              

           

            for(int i = 0; i < 7;i++)
            {
                Weekday w = (Weekday)i;
                Console.WriteLine(w);
            }*/
            #endregion

            /*
            #region q2
            
              //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) 
                //as its members. Write a C# program that takes a
                //season name as input from the user and displays the corresponding month range for that
                //season. Note range for seasons ( spring march to may ,
                //summer june to august , autumn September to November , winter December to February)
            

            seasonsmonth spring = seasonsmonth.March;
            spring |= seasonsmonth.April;
            spring |= seasonsmonth.May;


            seasonsmonth summer = seasonsmonth.June;
            summer |= seasonsmonth.July;
            summer |= seasonsmonth.August;
            

            seasonsmonth winter = seasonsmonth.December;
            winter |= seasonsmonth.January;
            winter |= seasonsmonth.February;

            seasonsmonth autumn = seasonsmonth.September;
            autumn |= seasonsmonth.October;
            autumn |= seasonsmonth.November;

            string season=Console.ReadLine();
            if (season == "summer")
            {
                Console.WriteLine(summer);
            }
            else if (season == "spring")
            {
                Console.WriteLine(spring);
            }
            else if (season == "autumn")
            {
                Console.WriteLine(autumn);
            }
            else if (season == "winter")
            {
                Console.WriteLine(winter);
            }



            #endregion

            */

            #region q3
            /*
              4- Assign the following Permissions (Read, write, Delete, Execute) in a
                 form of Enum.
                   Create Variable from previous Enum to Add and Remove Permission from variable
                   , check if specific Permission is existed inside variable
              */

            premission prem = premission.read;

            prem |= premission.write;
            Console.WriteLine(prem);

            prem&=premission.write;
            Console.WriteLine(prem);


            if (prem.HasFlag(premission.read))
            { Console.WriteLine("read in inside"); }
            else { Console.WriteLine("read isn't there");};

            #endregion












        }
    }
}
