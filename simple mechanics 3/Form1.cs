//simple mechanics3.cs
// CS-1181
// Sagar Gaire
// 9/13/2017
// Anil Mandal
// frorm this simple mechanics assingment-3 we can learn what is the use of if, else, elseif and also we learn how to do a program by using this statement. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_mechanics_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //question 1-20
            bool answer;
            int number1 = 10, number2 = 15, number3 = 5, number4 = 75, number5 = 3;
            answer = 5 < 10;
            answer = 6 < 10;
            answer = 6 < 10.0;
            answer = 60 > 10;
            answer = 200 > 10;
            answer = 100.0 > 200.000;
            answer = 3 == 3;
            answer = 6 == 64 / 4;
            answer = 10 == 2 * 5;
            answer = 16 != 12;
            answer = 20 != 20.0001;
            answer = 3 <= 4;
            answer = 13 <= 67;
            answer = 15 <= 98.0;
            answer = 14 >= 3;
            answer = 25 >= 10;
            answer = 20 >= 13;
            answer = 2 * 8 >= 10;
            answer = 10 * 100 >= 10 * 5;
            answer = 3 * 100 >= 30 * 10;
            //if statement question 22-40

            if (4 > 1)
            {
                answer = true;
            }
            if (11 > 5)
            {
                answer = true;
            }
            if (42 > 34)
            {
                answer = true;
            }
            if (155 > 64)
            {
                answer = true;
            }
            if (10 > -29)
            {
                answer = false;
            }
            if (11.6 > 11.5)
            {
                answer = true;
            }
            if (number1 > 1)
            {
                answer = true;
            }
            if (19 > number1)
            {
                answer = true;

            }
            if (50 > number2)
            {
                answer = true;
            }
            if (number2 < 32)
            {
                answer = true;
            }
            if (number2 < 21)
            {
                answer = true;
            }
            if (number2 < 15.5)
            {
                answer = true;
            }
            if (number3 == 5)
            {
                answer = true;
            }
            if (number4 == 75)
            {
                answer = true;
            }
            if (number5 == 3)
            {
                answer = true;
            }
            if (number1 != 3)
            {
                answer = true;
            }
            if (number2 != 16)
            {
                answer = true;
            }
            if (number3 != 1)
            {
                answer = true;
            }
            if (number4 != 81)
            {
                answer = true;
            }
            if (number5 != 1)
            {
                answer = true;
            }
            //if-else statement question 41-50
            //question 41
            if (4 > 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 42
            if (11 > 5)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 43
            if (10 > -29)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 44
            if (11.6 > 11.5)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 45
            if (number1 > 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 46
            if (19 > number1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 47
            if (number2 < 32)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 48
            if (number3 == 5)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 49
            if (number1 != 3)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 50
            if (number5 != 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //if elseif statement question 51-60
            //question 51
            if (number2 > 1)
            {
                answer = true;
            }
            else
            {
                if (number2 > -45)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number2 > 1)
            {
                answer = true;
            }
            else if (number2 > -45)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 52
            if (number3 < 34)
            {
                answer = true;
            }
            else
            {
                if (number3 < 64)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number3 < 34)
            {
                answer = true;
            }
            else if (number3 < 64)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 53
            if (number4 < -29)
            {
                answer = true;
            }
            else
            {
                if (number4 > 11.5)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number4 <-29)
            {
                answer = true;
            }
            else if (number4 > 11.5)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 54
            if (number1 > 1)
            {
                answer = true;
            }
            else
            {
                if (number1 < 19)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number1 > 1)
            {
                answer = true;
            }
            else if (number1 < 19)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 55
            if (number2 < 50)
            {
                answer = true;
            }
            else
            {
                if (number2 < 32)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number2 < 50)
            {
                answer = true;
            }
            else if (number2 < 32)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 56
            if (number2 < 21)
            {
                answer = true;
            }
            else
            {
                if (number2 < 25.5)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number2 < 21)
            {
                answer = true;
            }
            else if (number2 < 25.5)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 57
            if (number3== 5)
            {
                answer = true;
            }
            else
            {
                if (number3 == 75)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number3 == 5)
            {
                answer = true;
            }
            else if (number3 == 75)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // question 58
            if (number5 == 3)
            {
                answer = true;
            }
            else
            {
                if (number1 < 3)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number5 == 3)
            {
                answer = true;
            }
            else if (number1 < 3)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 59
            if (number5 == 5)
            {
                answer = true;
            }
            else
            {
                if (number5 < 15)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
                if (number5 > 16)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number5 == 5)
            {
                answer = true;
            }
            else if (number5 < 15)
            {
                answer = true;
            }
            else if (number5 > 16)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //question 60
            if (number3 == 16)
            {
                answer = true;
            }
            else
            {
                if (number4 != 81 )
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
                if (number5 != 1)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            if (number3 == 16)
            {
                answer = true;
            }
            else if (number4 != 81 )
            {
                answer = true;
            }
            else if (number5 != 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // switch statemet
            //question61
            if (number1 == 12)
            {
                answer = true;
            }
            else if (number1 == 11)
            {
                answer = true;
            }
            else if (number1 == 10)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            switch (number1)
            {
                case 12:
                    answer = true;
                    break;
                case 11:
                    answer = true;
                    break;
                case 10:
                    answer = true;
                    break;
                default:
                    answer = false;
                    break;
            }
            // question62
            if (number2 == 15)
            {
                answer = true;
            }
            else if (number2 == -34)
            {
                answer = true;
            }
            else if (number2 == 45)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            switch (number2)
            {
                case 15:
                    answer = true;
                    break;
                case -34:
                    answer = true;
                    break;
                case 45:
                    answer = true;
                    break;
                default:
                    answer = false;
                    break;
            }
            //question 63
            if (number3 == 944)
            {
                answer = true;
            }
            else if (number3 == 1)
            {
                answer = true;
            }
            else if (number3 == 22)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            switch (number3)
            {
                case 944:
                    answer = true;
                    break;
                case 1:
                    answer = true;
                    break;
                case 22:
                    answer = true;
                    break;
                default:
                    answer = false;
                    break;
            }
            // question 64
            if (number4 == 7825)
            {
                answer = true;
            }
            else if (number4 == 64)
            {
                answer = true;
            }
            else if (number4 == 1090)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            switch (number4)
            {
                case 7825:
                    answer = true;
                    break;
                case 64:
                    answer = true;
                    break;
                case 1090:
                    answer = true;
                    break;
                default:
                    answer = false;
                    break;
            }
            //question 65
            if (number5 == -134)
            {
                answer = true;
            }
            else if (number5 == -1324)
            {
                answer = true;
            }
            else if (number5 == -2435)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            switch (number2)
            {
                case -134:
                    answer = true;
                    break;
                case -1324:
                    answer = true;
                    break;
                case -2435:
                    answer = true;
                    break;
                default:
                    answer = false;
                    break;
            }










        }
    }
}
