/*1.შეადგინეთ სამკუთხედის კლასი, რომელშიც განსაზღვრულია ერთი და იგივე
სახელის მქონე 2 მეთოდი. პირველ მეთოდს 2 მთელრიცხვა პარამეტრი აქვს:
სამკუთხედის სიმაღლე და ფუძე და აბრუნებს  სამკუთხედის
ფართობს. მეორე მეთოდს 3 მთელრიცხვა პარამეტრი აქვს: სამკუთხედის
გვერდები და აბრუნებს სამკუთხედის პერიმეტრს. Program.cs ში 
შექმენით შესაბამისი ობიექტი და გამოიძახეთ ორივე მეთოდი. 
შექმენით ორი მეთოდი, რომელიც აბრუნებებს ორი რიცხვის ნამრავლს, 
პირველ მეთოდს პარამეტრებად გადაეცემა int ტიპის რიცხვები, 
ხოლო მეორე მეოთდს double ტიპის პარამეტრები
3.შექმენით Shape კლასი და განსაზღვრეთ მეთოდი რომელიც აბრუნებს 
მართკუთხედის პერიმეტრს, შექმენით Triangle კლასი რომელიც არის  
Shape კლასის შვილობილი კლასი, და პირველ გვერდსა და მეორე გვერდს 
მემკვიდრეობით იღებს მშობელი კლასიდან, გადაფარეთ მშობელი კლასის მეთოდი
და დააბრუნეთ სამკუთხედის პერიმეტრი.
*/

using Assignment9;

triangle triangle = new triangle();
Console.WriteLine("samkutxedis fartobi :  "  + triangle.GetArea(10, 15));
Console.WriteLine("samkutxedis perimetri  :  " + triangle.GetPerimeter(10,25,30));


multiplication multiplication = new multiplication();
int wholeNumber = (int)multiplication.multiplication2Numbers(10, 25);
Console.WriteLine("ori ricxvis namravli   : "  +wholeNumber);
double Adecimal_number = (double)multiplication.multiplication2Numbers(10.5, 30.5);
Console.WriteLine("atwiladebis namravli   :  "  + Adecimal_number);

Shape shape = new Shape();
int PerimeterRectangle = shape.PerimeterOfARectangle(100, 60);
Console.WriteLine("martkutxedis merimetri   : "+PerimeterRectangle);

Triangle1 triangle1 = new Triangle1();
int PerimeterTriangle1 = triangle1.GetPerimeter(10, 10, 15);
Console.WriteLine("samkutxedis perimetri   :  "+PerimeterTriangle1);
