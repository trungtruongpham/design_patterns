using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    public abstract class IBook
    {
        public abstract void Accept(IVisitor visitor);
    }

    public class ConcreteComponentA : IBook
    {

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }


        public string BookA_Author()
        {
            return "Book A written by Adam";
        }

        public string BookA_ReleaseDate()
        {
            return "Book A released in April 10th";
        }
    }

    public class ConcreteComponentB : IBook
    {

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string BookB_Author()
        {
            return "Book B written by Eva";
        }

        public string BookB_ReleaseDate()
        {
            return "Book B released in May 18th";
        }
    }

    public abstract class IVisitor
    {
        public abstract void VisitConcreteComponentA(ConcreteComponentA element);

        public abstract void VisitConcreteComponentB(ConcreteComponentB element);
    }

    class ConcreteVisitor1 : IVisitor
    {

        public override void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.BookA_Author() + " + ConcreteVisitor1");
        }

        public override void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.BookB_Author() + " + ConcreteVisitor1");
        }
    }

    class ConcreteVisitor2 : IVisitor
    {

        public override void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.BookA_ReleaseDate() + " + ConcreteVisitor2");
        }

        public override void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.BookB_ReleaseDate() + " + ConcreteVisitor2");
        }
    }

    public class Client
    {
        public static void ClientCode(List<IBook> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IBook> components = new List<IBook>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client lam viec voi cac Visitor thong qua VisitorInterface : ");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("Cho phep client lam viec voi cac loai Visitor khac nhau :");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
        }
    }
}