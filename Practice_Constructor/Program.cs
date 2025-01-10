using Practice_Constructor;

Baby baby1 = new Baby()
{
    DateOfBirth = DateTime.Now,
    Name = "Baby",
    Surname = "One"
};


Baby baby2 = new Baby("Baby", "Two")
{
    DateOfBirth = DateTime.Now
};

baby1.Introduce();
Console.WriteLine("-------------------------------------");
baby2.Introduce();