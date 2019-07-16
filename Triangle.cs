using System;

class Triangle
{
static void Main()
{
  Console.WriteLine("Enter first side of the triangle ");
  string stringSide1 = Console.ReadLine();
  int side1 = int.Parse(stringSide1);
  Console.WriteLine("Enter second side of the triangle ");
  string stringSide2 = Console.ReadLine();
  int side2 = int.Parse(stringSide2);
  Console.WriteLine("Enter third side of the triangle ");
  string stringSide3 = Console.ReadLine();
  int side3 = int.Parse(stringSide3);
  triangleTracker(side1,side2,side3);

}

static void triangleTracker(int side1, int side2, int side3)
{
  if ((side1+side2>side3)&&(side2+side3>side1)&&(side1+side3>side2)){
      if (side1 == side2 && side2 ==side3){
        Console.WriteLine("Equilateral");
      } else if ((side1 == side2)||(side2 == side3)||(side1==side3)){
        Console.WriteLine("Isosceles");
      } else {
        Console.WriteLine("Scalene");
      }

    } else{
      Console.WriteLine("those sides do not produce a triangle, please try again");
    }
}
} 