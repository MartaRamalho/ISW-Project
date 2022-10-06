
List<string> nationalities;
void initList()
{
    nationalities = new List<string>()
     {
         "Australian",
         "Mongolian",
         "Russian",
         "Austrian",
         "Brazilian"
     };
}
initList();
nationalities.Sort();
foreach (string nationality in nationalities)
{
    Console.WriteLine(nationality);
}