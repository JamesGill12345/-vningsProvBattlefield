List <Student> Students = new List<Student>(); // lista med alla elever



Console.WriteLine("Hur många teknikelever går i klassen?"); // fråga
string numoftestring = Console.ReadLine(); // svar lagras i en string
int numofteint; // skapar en int

int.TryParse(numoftestring, out numofteint); // konverterar string till int
 
int i = 0; // en räknargrej

while(numofteint > i) // så länge talet du angav är större än i fortsätter loopen
{
    i++; // i ökar i värde så att loopen inte pågår för evigt
    Testudent testudent = new Testudent(); // gör en ny teknikelev
    Students.Add(testudent); // lägger till teknikelev i listan
}


// nedan är iprincip samma sak 

Console.WriteLine("Hur många estetelever går i klassen?");
string numofesstring = Console.ReadLine();
int numofesint;

int.TryParse(numofesstring, out numofesint);
 
int x = 0;

while(numofesint > x)
{
    x++;
    esstudent esstudent = new esstudent();
    Students.Add(esstudent);
}




Console.WriteLine("Hur många itelever går i klassen?");
string numofitstring = Console.ReadLine();
int numofitint;

int.TryParse(numofitstring, out numofitint);
 
int y = 0;

while(numofitint > y)
{
    y++;
    itstudent itstudent = new itstudent();
    Students.Add(itstudent);
}


