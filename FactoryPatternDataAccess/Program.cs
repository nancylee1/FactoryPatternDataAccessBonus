using FactoryPatternDataAccess;

Console.WriteLine("What database would you like to access? ");
Console.WriteLine("Type ListDataAccess for accessing a list: "); 
Console.WriteLine("Type SQLDataAccess for accessing a list: "); 
Console.WriteLine("Type MongoDataAccess for accessing a list: ");

var input = Console.ReadLine();
IDataAccess myDataAccess; //Declaring a variable of type IDataAccess called myDataAccess
myDataAccess = DataAccessFactory.GetDataAccess(input); // Initializing that variable with a value that is returned from the method
IDataAccess myDataAccess1 = DataAccessFactory.GetDataAccess(input); // Declaring and Initializing where datatype variableName = value;
myDataAccess.LoadData();
myDataAccess.SaveData();


