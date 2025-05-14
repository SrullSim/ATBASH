namespace atbash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(decrypt("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb."));

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
        static (string, int) LooksDangerousWords(string input)
        {
            return ("", 0);
        }

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
