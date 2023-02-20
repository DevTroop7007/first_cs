using System;


    class Program
    {
        static void Main(string[]args)
        {
            //styling
            Console.Title = "<<<<<Math Puzzles>>>>>";
            
            Console.WriteLine("\t\t\t\t<<<<<Math Puzzles>>>>>");
            Console.WriteLine("Complete these math puzzles to get some chocolates.");
            Console.WriteLine("If you give wrong answer you will be punished.");
          Console.WriteLine("Don't use any calculator.Otherwise you will be kicked into hell.");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            MathGame();
            Console.WriteLine("Thank you for choosing us.[Press a key to next]");
            Console.ReadKey();
            Console.WriteLine("But we have some valuable stuff for you");
            Console.WriteLine("Here is your reward->->->->->->->->->");
            Console.WriteLine("[Press a key to grab your rewards]");
            Console.ReadKey();
            Console.WriteLine("We have some screwdrivers for you and we will torture and kill you with it.");
            Console.WriteLine("We don't want any MATHMATICIAN in this world");
            Console.WriteLine("Me and my friends will be the ONLY MATHMATICIAN in the world.(HE HE HE HE)");
            Console.WriteLine("SCREWING MACHINE EXECECUTING----EXECUTION DONE");
            Console.WriteLine("You::::Ahhhhhhhh!!!   I will Never play this game Uhhhhhhhhh!!!!");
            Console.WriteLine("\t\t\tTHANK YOU");
            
            Console.ReadKey();
        }
        static void MathGame()
        {
            //Variable declarations
            string[] p = {"1+1","2+3","9+4","2-1","5-2","128-45","2*2","10*15","19*12","12*15","125/5","585/3","222/2","(2+1+5)/2","(2*5)/2","(9+3+5+9+1)/9","64^3","2023^2","7!","13!"};
            //Answers
            double[] r = {2,5,13,1,3,83,4,150,228,180,25,195,111,4,5,3,262144,4092529,5040};
          long fac = 6227020800;
            
            //Game Starts from here
            //1
            Console.WriteLine("1." + p[0] + "=?\nAns;");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a==r[0])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //2
            Console.WriteLine("2." + p[1] + "=?\nAns;");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b==r[1])
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;  
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //3
            Console.WriteLine("3." + p[2] + "=?\nAns;");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c==r[2])
            {
              
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;  
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //4
            Console.WriteLine("4." + p[3] + "=?\nAns;");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d==r[3])
            {
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //5
            Console.WriteLine("5." + p[4] + "=?\nAns;");
            int e = Convert.ToInt32(Console.ReadLine());
            if (e==r[4])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //6
            Console.WriteLine("6." + p[5] + "=?\nAns;");
            int f = Convert.ToInt32(Console.ReadLine());
            if (f==r[5])
            {
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //7
            Console.WriteLine("7." + p[6] + "=?\nAns;");
            int g = Convert.ToInt32(Console.ReadLine());
            if (g==r[6])
            {
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //8
            Console.WriteLine("8." + p[7] + "=?\nAns;");
            int h = Convert.ToInt32(Console.ReadLine());
            if (h==r[7])
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //9
            Console.WriteLine("9." + p[8] + "=?\nAns;");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i==r[8])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //10
            Console.WriteLine("10." + p[9] + "=?\nAns;");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j==r[9])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //11
            Console.WriteLine("11." + p[10] + "=?\nAns;");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k==r[10])
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //12
            Console.WriteLine("12." + p[11] + "=?\nAns;");
            int l = Convert.ToInt32(Console.ReadLine());
            if (l==r[11])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //13
            Console.WriteLine("13." + p[12] + "=?\nAns;");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m==r[12])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //14
            Console.WriteLine("14." + p[13] + "=?\nAns;");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n==r[13])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //15
            Console.WriteLine("15." + p[14] + "=?\nAns;");
            int o = Convert.ToInt32(Console.ReadLine());
            if (o==r[14])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //16
            Console.WriteLine("16." + p[15] + "=?\nAns;");
            int q = Convert.ToInt32(Console.ReadLine());
            if (q==r[15])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //17
            Console.WriteLine("17." + p[16] + "=?\nAns;");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s==r[16])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //18
            Console.WriteLine("18." + p[17] + "=?\nAns;");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t==r[17])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //19
            Console.WriteLine("19." + p[18] + "=?\nAns;");
            int u = Convert.ToInt32(Console.ReadLine());
            if (u==r[18])
            {
                Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
            //20
            Console.WriteLine("20." + p[19] + "=?\nAns;");
            long v = Convert.ToInt64(Console.ReadLine());
            if (v==fac)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ResetColor();
            }
        }
    }
