namespace session_5
{
    internal class Program
    {

        
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


        
        static void Main(string[] args)
        {
            
            #region q1
            /*
            Create an enum called "WeekDays" with the days of the week 
            (Monday to Sunday) as its members. Then, write a C# program that prints
            out all the days of the week using this enum
              */

            //Weekday w1=Weekday.Monday;
            //Weekday w2=Weekday.Tuesday;
            //Weekday w3=Weekday.Wednesday;
            //Weekday w4=Weekday.Thursday;
            //Weekday w5=Weekday.Friday;
            //Weekday w6=Weekday.Saturday;
            //Weekday w7 = Weekday.sunday;


            //Weekday w8 = (Weekday)1;
            //Console.WriteLine(w8 );

            for(int i = 0; i < 7;i++)
            {
                Weekday w = (Weekday)i;
                Console.WriteLine(w);
            }




                //Console.WriteLine(w1);
                //Console.WriteLine(w2);
                //Console.WriteLine(w3);
                //Console.WriteLine(w4);
                //Console.WriteLine(w5);
                //Console.WriteLine(w6);
                //Console.WriteLine(w7);
            #endregion














        }
    }
}
