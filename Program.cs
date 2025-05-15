using System.Net.Sockets;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace atbash
{
    class Program
    {



        static void Main(string[] args)
        {
            List<string> list = new List<string>{
                "nukhba" , "fighter", "rocket", "secret"
            };
            Console.WriteLine(run_all("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.", list));
        }

        static string run_all(string input, List<string> dangerousWords)
        {
            string decryptedText = decrypt(input);

            int threatLevel = LooksDangerousWords(decryptedText, dangerousWords);

            return $" {WarningAlert(threatLevel)},\n {decryptedText}";


        }



        //     decrypt the text
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

        //check for dangerous words in the text
        static int LooksDangerousWords(string input, List<string> dangerousWords)
        {
            char[] delimiterChars = [' ', ',', '.', ':', '-'];

            int points = 0;
            List<string> listwords = input.Split(delimiterChars).ToList();


            for (int i = 0; i < listwords.Count; i++)
            {
                if (dangerousWords.Contains(listwords[i]))
                {
                    points++;
                }
            }


            return (points);
        }

        //Assessment of alert level
        static string WarningAlert(int input)
        {
            switch (input)
            {
                case 0:
                    return "Safe message";

                case < 6:
                    return "WARNING";

                case < 11:
                    return "DANGER!";
                    ;
                case < 16:
                    return "ULTRA ALERT!";

                default:
                    return "JUST GET TO THE BOMB SHELTER";

            }
        }

    }
}
