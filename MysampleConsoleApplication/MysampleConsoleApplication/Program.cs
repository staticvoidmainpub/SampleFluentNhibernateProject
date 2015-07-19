using System;
using FluentNHibernate;
using NHibernate;
using System.Collections.Generic;
using MysampleConsoleApplication.Model;

class Program
{
    static void Main(string[] args)
    {
        using (var session = MysampleConsoleApplication.Configuration.CreateSessionFactory().OpenSession())
        {
            string h_stmt = "FROM Catagory";

            IQuery query = session.CreateQuery(h_stmt);

            IList<Catagory> customersList = query.List<Catagory>();

            foreach (var cust in customersList)
            {
                Console.WriteLine("{0} in {1}",cust.CatagoryID,cust.Name);
            }
            Console.ReadLine();
        }
    }
}