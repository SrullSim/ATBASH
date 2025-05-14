namespace atbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> listi = new List<string>() { "fdgf", "jhjyv", "hvjvgc", "jkg", "acfg" }; 
            Console.WriteLine(LooksDangerousWords("acfg jkg kjhvhtcg jhjyv hjbhv", listi));
            
        }



        //     decrypted the text
        static string decrypt(string input)
        {
            return "";
        }

        //checked for dangerous words in the text
        static int LooksDangerousWords(string input,List<string> dengrusWords)
        {
            int points = 0;
            List<string> listwords = input.Split(' ').ToList();


            for (int i = 0; i < listwords.Count;  i++)
            {
                if (dengrusWords.Contains(listwords[i]))
                {
                    points++;
                }
            }


            return (points);
        }

        //Sends alert based on assessment
        static string WarningAlert(string input)
        {
            return "";
        }


    }
}
