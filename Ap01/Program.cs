using Ap01.Models;

db01Context db = new db01Context();

/*Insert Data*/
/*
var result = db.Customers.Where(c => c.CustId == "C001").FirstOrDefault();
if (result == null)
{
    var newCustomer = new Customer
    {
        CustId = "C001",
        CustName = "Cust01",
        Addr = "Addr01",
        Phone = "Phone01"
    };
    db.Customers.Add(newCustomer);
    Console.WriteLine("Add Customer");
    Console.WriteLine($"{newCustomer.CustId} {newCustomer.CustName} {newCustomer.Addr} {newCustomer.Phone}");

    db.SaveChanges();
}
else
{
    Console.WriteLine("Customer already exists");
    Console.WriteLine($"{result.CustId} {result.CustName} {result.Addr} {result.Phone}");
}
*/

/*Update Data*/

/*
var result = db.Customers.Where(c => c.CustId == "C001").FirstOrDefault();
if (result != null)
{
    result.CustName = "A-Comp";
    result.Addr = "TP";
    result.Phone = "999-9999";
    Console.WriteLine("Update Customer");
    Console.WriteLine($"{result.CustId} {result.CustName} {result.Addr} {result.Phone}");
    db.SaveChanges();
}
else
{
    Console.WriteLine("Customer not found");
}
*/

//Delete Data
/*
var result = db.Customers.Where(c => c.CustId == "C001").FirstOrDefault();
if (result != null)
{
    Console.WriteLine("Delete Customer");
    Console.WriteLine($"{result.CustId} {result.CustName} {result.Addr} {result.Phone}");
    db.Customers.Remove(result);
    db.SaveChanges();
}
else
{
    Console.WriteLine("Customer not found");
}
*/


/*List Data*/

var customers = db.Customers.ToList();
Console.WriteLine("\nList all Customers");
foreach (var c in customers)
{
    Console.WriteLine($"{c.CustId} {c.CustName} {c.Addr} {c.Phone}");
}
