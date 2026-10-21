string[] party = { "Angel", "Fathan", "Fathir", "Nadia", "Empty" };
// Display all party members using a for loop
for (int i = 0; i < party.Length; i++)
{
    Console.WriteLine($"Member {i + 1}: {party[i]}");
}
// Change the third party member
party[4] = "Wildan";
Console.WriteLine($"\nUpdated Member 5: {party[4]}");