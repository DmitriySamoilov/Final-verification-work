//string [] arrayFirst={"hello","2", "world", ":-)"};
string [] arrayFirst={"1234","1567", "-2", "computer science"};
//string [] arrayFirst={"Russia","Denmark", "Kazan"};
System.Console.WriteLine($"[{string.Join(", ", arrayFirst)}]");
string [] arraySecond= FindStringBelow4(arrayFirst);
System.Console.WriteLine($"[{string.Join(", ", arraySecond)}]");

string [] FindStringBelow4(string[] arrayStart)
{
int n=0,j=0;
foreach (string item in arrayStart)
{
   if (item.Length<4) n++;
}
string []arrayResult= new string [n];
foreach (string item in arrayStart)
{
   if (item.Length<4) {arrayResult[j]=item; j++;}
}
return arrayResult;
}
