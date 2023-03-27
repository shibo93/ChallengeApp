// jeżeli kobieta to wpisać w sex = "Woman", jeżeli mężczyzna to wpisać = "Man".
var name = "Ewa";
var age = 33;
var sex = "Woman";

if (sex == "Woman" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (!(sex == "Woman") && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (!(sex == "Woman") && age >= 18)
{
    Console.WriteLine("Mężczyzna pełnoletni");
}
else if (sex == "Woman" && age >= 30)
{
    Console.WriteLine("Kobieta ma 30 lub więcej lat");
}