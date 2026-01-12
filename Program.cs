// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//trim and Replace 
string firstFriend = "maria";
string secondFriend = "             ramani                      ";


string friends = $"my  friend are {firstFriend} and {secondFriend.Trim()}";
Console.WriteLine(friends);
friends = friends.Replace("ramani","sithu");
Console.WriteLine(friends);

//numbers 
int a =18; //21000000(in this 32 bits only allowd for the range)
int b= 6;
int c= a+b;// also the result should be 32 bit 
Console.WriteLine(c);

long d=25893333333333; // when it comes to long that make sense in 64 bit range 
long e=5698;
long f=d+e;
Console.WriteLine(f);

int g = 2100000000;
int h = 2100000000;
long i=(long)g+(long)h; //also can used "checked" for never have to overflow 
Console.WriteLine(i);


