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

int j =(int)35.2; // no matter what but need to have intiger 
int k=(int)45.6;
int l=j+k;
Console.WriteLine(l);

double m= 35.6;  //c# need to have exact data type to work 
double o= 65.9;
double p= m+o;
Console.WriteLine(p);

//float =65.2(this is error) but float =65.2F (suffix- ending when uses p that min prefix)

double q= 64.3; //(natural type)
float r= 78.5F;
double s= q+r;
Console.WriteLine(s);

Decimal t= 64.3M; //(explicit type )
Decimal z= 78.5M; //(M- for math)
Decimal x= t+z;
Console.WriteLine(s);
bool mytest= x<50; // result should be true or false 
Console.WriteLine(mytest);
if (x>100){
    Console.WriteLine("this number is grater than 100.");
}
else{
    Console.WriteLine("this number is less than 100.");
}

int a1 = 4;
int b1 = 5;
int c1 = 6;

 if ((a1 + b1 + c1 > 10) && (a1 == b1))   // bool condition 
    {
       Console.WriteLine("the answer is greater than 10");
       Console.WriteLine("the a and b is equal");
     }
 else
     {
        Console.WriteLine("the answer is less than 10");
        Console.WriteLine("the a and b is not equal");
      }

 // while loops 
 int counter =0;
 Console.WriteLine(counter);
 counter = counter +1;
 Console.WriteLine(counter);
  counter = counter +1;
 Console.WriteLine(counter);
  counter++;
 Console.WriteLine(counter);
  counter++;
 Console.WriteLine(counter);
 Console.WriteLine(".....................................................................");
 int counterr =2;
 while(counterr<6)
 {
    counterr++;
 Console.WriteLine(counterr);
 }


 

 




