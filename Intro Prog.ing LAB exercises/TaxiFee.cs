using System;
            Console.Write("How long have you moved, please? ");
            float distance = float.Parse(Console.ReadLine());
            float fee = 0;
            
            //12+ km: discount 10%
            bool isDiscount = distance>=12;

            //1st km: 15k
            if (distance<=1) {
                fee = 15000 * distance;
            } else {
                fee = 15000;
                distance -= 1;
                
                //next 4 km (1-5): 13.5k
                if (distance<=4) {
                    fee += 13500 * distance;
                } else {
                    fee += 13500 * 4;
                    distance -= 4;

                    //5+ km: 11k
                    fee += distance * 11000;
                }
            }
            
            if (isDiscount) {
                fee *= (float)0.9;
            }

            Console.WriteLine("Your taxi cost is {0} VND.\nThank you for using MeoAhihi taxi service!\nSee you again", fee);
        

