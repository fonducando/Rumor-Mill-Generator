using System.IO;


namespace Rumor_Mill_Generator
{ 
    public class RumorGenerator
    { 
    
        public static Random name1 = new Random(), verb1 = new Random(), name2 = new Random(), verb2 = new Random(), noun1 = new Random(), name3 = new Random();

        public static string GenerateRandomPhrase()
        {
        int name1num = name1.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/names.txt").Count()));
        int name2num = name2.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/names.txt").Count()));
        int name3num = name2.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/names.txt").Count()));
        int verb1num = verb1.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/verbs1.txt").Count()));     
        int verb2num = verb2.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/verbs2.txt").Count()));
        int noun1num = noun1.Next(1, (File.ReadAllLines(Directory.GetCurrentDirectory() + "/nouns.txt").Count()));

        string stringtowrite = ((File.ReadAllLines("names.txt")[name1num]) + " said " + (File.ReadAllLines("names.txt")[name2num]) + " " + (File.ReadAllLines(Directory.GetCurrentDirectory() + "/verbs1.txt")[verb1num]) + " " + ((File.ReadAllLines("names.txt")[name3num])) + " " + (File.ReadAllLines(Directory.GetCurrentDirectory() + "/verbs2.txt")[verb2num]) + " " + (File.ReadAllLines(Directory.GetCurrentDirectory() + "/nouns.txt")[noun1num]));
       
        return stringtowrite;
        }
    }
}
