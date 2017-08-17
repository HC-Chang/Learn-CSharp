using System;

namespace credit
{
    class Program
    {
        static void Main(string[] args)
        {
            string credit_number = "378282246310005";
            // credit_number = "5555555555554444";
            // credit_number = "4111111111111111";
            credit_number = "5105105105105100";

            // credit_number = Console.ReadLine();
            Int64 num = Convert.ToInt64(credit_number);
            
            // 驗證
            bool b = ChekedNumber(num);
            if(b == false)
            {
                Console.Write("Error");
                return;
            }
            
            Console.Write("\nCorrect\n");

            checkedCompany(credit_number);

            Console.WriteLine();
        }


        public static bool ChekedNumber(Int64 n64)
        {
            Int64 sum = 0;
            Int64 temp = 0;

            while(n64 != 0)
            {
                sum  += n64 % 10;
                n64  = n64 /10;
                if(n64 == 0)
                {
                    break;
                }
                temp = (n64 %10) *2;
                if(temp >9)
                {
                    sum += temp % 10;
                    temp =  temp /10;
                }

                sum += temp % 10;
                n64 = n64 / 10;
            }

            Console.Write(sum);

            if(sum % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void checkedCompany(string s)
        {
            int len = s.Length;

            switch(len)
            {
                case 13:
                    if(s[0]== '4')
                    {
                        Console.Write("Visa");
                    }
                    break;

                case 15:
                    if(s[0]== '3' ) 
                    {
                        if((s[1]== '4' || s[1]=='7'))
                        {
                            Console.Write("Amex");
                        }
                    }
                    break;
                        
                case 16:
                    if(s[0] == '4')
                    {
                        Console.Write("Visa");  
                    }
                    if(s[0] == '5' )
                    {
                        if(s[1] == '1' || s[1] == '2'|| s[1] == '3'||s[1] == '4'|| s[1] == '5')
                        {
                            Console.Write("Master Card");
                        }                       
                    }
                    break;
            }
        }
    }
}
