//start main
DisplayMenu();
//end main

static void DisplayMenu(){
    System.Console.WriteLine("Enter 1 to display a full triangle \n Enter 2 to display a partial triangle \n Enter 3 to exit");
    string userChoice = Console.ReadLine();
    if (userChoice == "1"){
        GetFull();
        DisplayMenu();
    }
    else if (userChoice == "2"){
        GetPartial();
        DisplayMenu();
    }
    else if (userChoice == "3"){
        System.Console.WriteLine("Exiting....");
        return;
    }
    else {
        System.Console.WriteLine("Invalid Choice!");
        DisplayMenu();
    }
}
static void GetFull(){
    Random random = new Random();
    int rows = random.Next(3,9);
    for (int i = 0; i < rows; i++) {
        for (int k = 0; k < i; k++){
            Console.Write("O");
        }
        Console.Write("\n");
    }
    
}
static void GetPartial(){
    Random random = new Random();
    int rows = random.Next(3,9);
    for (int i = 0; i < rows; i++){
        for (int k = 0; k < i; k++){
            Random choice = new Random();
            int partial = choice.Next(2);
            if (partial == 1){
                Console.Write(" ");
            }
            else {
                Console.Write("O");
            }
        }
        Console.Write("\n");
    } 
}