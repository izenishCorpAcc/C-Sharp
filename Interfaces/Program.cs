using Interfaces;

IShape circleObj =new Circle(12);
Console.WriteLine(circleObj.calcArea());
Console.WriteLine (circleObj.calcPerimeter());
//Console.WriteLine(circleObj.ExtraClassToCheckInterface()); --> This wont work because the circleObj is an IShape type but since ExtraClassToCheckInterface() 
// is of Circle type we cant access it

var x =new Circle(12);
x.ExtraClassToCheckInterface();