// See https://aka.ms/new-console-template for more information

using methodOverloadin;




List<Shape> shapeList = new List<Shape>();
//Adding new Shapes

shapeList.Add(new Circle());
shapeList.Add(new Triangle());
shapeList.Add(new Rectangle());



var canvas_Object = new Canvas();
canvas_Object.Depict(shapeList);