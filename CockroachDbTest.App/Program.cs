// See https://aka.ms/new-console-template for more information

using CockroachDbTest.App;

using (var db = new DataContext())
{
    Console.WriteLine("Migration started at {0}", DateTime.Now);

    db.Migrate();
    
    Console.WriteLine("Migration end at {0}", DateTime.Now);
}

using (var db = new DataContext())
{
    var e1 = new Entity1 { Id = Guid.NewGuid(),Name = "Tom", Age = 33 };
    var e2 = new Entity1 { Id = Guid.NewGuid(),Name = "Bil", Age = 27 };
 
    db.Entities1.AddRange(e1,e2);
    db.SaveChanges();
}
using (var db = new DataContext())
{
    var list = db.Entities1.ToList();
    foreach (var e in list)
    {
        Console.WriteLine($"{e.Name} - {e.Age}");
    }
}

Console.ReadLine();