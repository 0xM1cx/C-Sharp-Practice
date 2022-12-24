using System;

namespace ClassPractice
{
    
    

    class exHouse 
    {
        public string a = "It Worked";
        protected void akonBalay(){
            House h1 = new House();
            h1.owningCompany = "Camella Homes";
            Console.WriteLine(h1.owningCompany);
        }

    }


    class House : exHouse
    {

        string color;
        string owningCompany;
        int numberOfWindows;
        string houseID;
        bool available = true;
        void status(){
            Console.WriteLine("The house {0} is available", houseID); 
            
        }
        

        static void Main(string[] args)
        {
            House myhome = new House();
            myhome.akonBalay();
            myhome.houseID = "ACB2012";
            myhome.status();
            // myhome.color = "Blue";
            // myhome.owningCompany = "Bridge Homes";
            // myhome.numberOfWindows = 4;
            // myhome.houseID = "ACB 32";

            // myhome.status();

            // if(myhome.available == true){
            //     Console.WriteLine("When can we move in?");
            // } 

            // Console.Write("The house is owned by {0}. ", myhome.owningCompany);
            // Console.WriteLine("House Specifications include: {0}\n{1}\n", myhome.color, myhome.numberOfWindows);
        }



    }

}
