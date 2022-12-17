const string Diploma = "Diploma";
const string Certificate = "Certificate";
const string AspNetCore = "Asp.Net Core";
const string SpringBoot = "SpringBoot";
const string Laravel = "Laravel Framework";

string Qualification = Console.ReadLine();

if(Qualification.ToLower().Contains("university"))
{
    Console.WriteLine(Diploma);
} else if (Qualification.ToLower().Contains("academy"))
{
    Console.WriteLine(Certificate);
} else if (Qualification.ToUpper().Contains("CSSHARP"))
{
    Console.WriteLine(AspNetCore);  
} else if (Qualification.ToUpper().Contains("JAVA"))
{
    Console.WriteLine(SpringBoot);  
} else if (Qualification.ToUpper().Contains("PHP"))
{
    Console.WriteLine(Laravel); 
} else
{
    Console.WriteLine("Invalid qualification"); 
}