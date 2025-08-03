using Assessment.Q01;
using Assessment.Q02;
using Assessment.Q03;
using Assessment.Q04;

namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            /*
             * Question 01:
                Define an interface named IShape with a property Area and a method DisplayShapeInfo.
                Create two interfaces, ICircle and IRectangle, that inherit from IShape.
                Implement these interfaces in classes Circle and Rectangle.
                Test your implementation by creating instances of both classes and displaying their shape information.

             */
            //Rectangle rectangle = new Rectangle(5, 10);
            //rectangle.DisplayShapeInfo();
            //Console.WriteLine("======================");
            //Circle circle = new Circle(10);
            //circle.DisplayShapeInfo();

            #endregion

            #region Q02

            //BasicAuthenticationService user1 = new BasicAuthenticationService("Hossam", 123);
            //user1.AuthenticateUser();
            //user1.AuthorizeUser();

            //Console.WriteLine("==============================================");

            //BasicAuthenticationService user2 = new BasicAuthenticationService("Ahmed", 123);
            //user2.AuthenticateUser();
            //user2.AuthorizeUser();

            //Console.WriteLine("==============================================");

            //BasicAuthenticationService user3 = new BasicAuthenticationService("Ahmed", 456);
            //user3.AuthenticateUser();
            //user3.AuthorizeUser();


            #endregion

            #region Q03

            //INotificationService mailNotification = new EmailNotificationService();
            //mailNotification.SendNotification("Hossam", "Hello Hossam How Are You :)");

            //INotificationService smsNotification = new SmsNotificationService();
            //smsNotification.SendNotification("Hossam", "Hello Hossam How Are You :)");

            //INotificationService pushNotification = new PushNotificationService();
            //pushNotification.SendNotification("Hossam", "Hello Hossam How Are You :)");


            #endregion

            #region Q04

            //Console.Write("Hello What is Your Name: ");
            //string name = Console.ReadLine() ?? "";
            
            //Console.Write("Input Your Type (Regular, Premium, or Guest): ");
            //string type = Console.ReadLine() ?? "";
            
            //Console.Write("Pleas Enter Quantity of Products: ");
            //int.TryParse(Console.ReadLine(), out int quantity);

            //Console.Write("Pleas Enter Price of Products: ");
            //decimal.TryParse(Console.ReadLine(), out decimal price);


            //Console.WriteLine("==============================================");

            //UserType user = new UserType(name, type, quantity, price);
            //user.GetDiscount();

            #endregion

        }
    }
}
