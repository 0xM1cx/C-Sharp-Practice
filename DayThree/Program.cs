class House{

    string color;
    string owningCompany;
    int numberOfWindows;
    string houseID;
    bool available = true;
    public void status(){
        Console.WriteLine("The house {0} is available", houseID); 
        
    }
    

    public static void Main(){
        House myhome = new House();
        
        myhome.color = "Blue";
        myhome.owningCompany = "Bridge Homes";
        myhome.numberOfWindows = 4;
        myhome.houseID = "ACB 32";

        myhome.status();

        if(myhome.available == true){
            Console.WriteLine("When can we move in?");
        } 

        Console.Write("The house is owned by {0}. ", myhome.owningCompany);
        Console.WriteLine("House Specifications include: {0}\n{1}\n", myhome.color, myhome.numberOfWindows);
    }
}
