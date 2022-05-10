using System.IO;


namespace Rumor_Mill_Generator
{ 
    public class RumorGenerator
    { 
    
        public static System.Random name1 = new System.Random(), verb1 = new System.Random(), name2 = new System.Random(), verb2 = new System.Random(), noun1 = new System.Random(), name3 = new System.Random();

        public static string GenerateRandomPhrase()
        {
        int name1num = name1.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/names.txt").Length));
        int name2num = name2.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/names.txt").Length));
        int name3num = name2.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/names.txt").Length));
        int verb1num = verb1.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/verbs1.txt").Length));     
        int verb2num = verb2.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/verbs2.txt").Length));
        int noun1num = noun1.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/nouns.txt").Length));

        string stringtowrite = ((File.ReadAllLines("names.txt")[name1num]) + " said " + (File.ReadAllLines("names.txt")[name2num]) + " " + (File.ReadAllLines(Directory.GetCurrentDirectory() + "/verbs1.txt")[verb1num]) + " " + ((File.ReadAllLines("names.txt")[name3num])) + " " + (File.ReadAllLines(Directory.GetCurrentDirectory() + "/verbs2.txt")[verb2num]) + " " + (File.ReadAllLines(Directory.GetCurrentDirectory() + "/nouns.txt")[noun1num]));
       
        return stringtowrite;
        }
    }
}
