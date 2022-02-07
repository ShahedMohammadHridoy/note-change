using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program {
	class Program {
		static void Main(string[] args) {

            Console.WriteLine("Enter Amount:");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            
            int remainValue = inputNum;

            //500
            if(remainValue>500){
                  int result = remainValue/500;
                  Console.WriteLine("500 X "+result);
                  remainValue = remainValue-500*result;
            }

            //100
            if(remainValue>100){
                  int result = remainValue/100;
                  Console.WriteLine("100 X "+result);
                  remainValue = remainValue-100*result;
            }

            //50
            if(remainValue>50){
                  int result = remainValue/50;
                  Console.WriteLine(" 50 X "+result);
                  remainValue = remainValue-50*result;
            }

            //20
            if(remainValue>20){
                  int result = remainValue/20;
                  Console.WriteLine(" 20 X "+result);
                  remainValue = remainValue-20*result;
            }

            //10
            if(remainValue>10){
                  int result = remainValue/10;
                  Console.WriteLine(" 10 X "+result);
                  remainValue = remainValue-10*result;
            }

            //5
            if(remainValue>5){
                  int result = remainValue/5;
                  Console.WriteLine("  5 X "+result);
                  remainValue = remainValue-5*result;
            }

            //2
            if(remainValue>2){
                  int result = remainValue/2;
                  Console.WriteLine("  2 X "+result);
                  remainValue = remainValue-2*result;
            }

            //1
            if(remainValue!=0){
                  int result = remainValue/1;
                  Console.WriteLine("  1 X "+result);
                  remainValue = remainValue-1*result;
            }

            // //remain value
            // Console.WriteLine("Remaining Amount: " + remainValue);
		}
	}
}