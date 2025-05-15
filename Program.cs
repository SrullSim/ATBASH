namespace atbash
{
    class Program
    {
        static void Main(string[] args)
        {
        }



        //     decrypted the text
        static string decrypt(string input)
        {
            Dictionary<char, char> atbash = new Dictionary<char, char>();
           
            for (char c = 'a'; c <= 'z'; c++)
            {
                atbash[c] = (char)('z' - (c - 'a'));
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                atbash[c] = (char)('Z' - (c - 'A'));
            }
            string messageDecrypted = "";
            
            foreach (char c in input)
            {
                if (atbash.ContainsKey(c))
                {
                    messageDecrypted += atbash[c];
                }
                else
                {
                    messageDecrypted += c;
                }
            }
            return messageDecrypted;
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


        //Assessment of alert level
        static string WarningAlert(int input)
        {
            switch (input)
            {
                case 0:
                    return "Safe message";
                    break;
                case < 6:
                    return "WARNING";
                    break;
                case < 11:
                    return "DANGER!";
                    break;
                case < 16:
                    return "ULTRA ALERT!";
                    break;
                default:
                    return "JUST GET TO THE BOMB SHELTER";
                    break;
            }
        }
    }
}
