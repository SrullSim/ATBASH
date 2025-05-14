namespace atbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
        }



        //     decrypted the text
        static string decrypt(string input)
        {
            return "";
        }

        //checked for dangerous words in the text
        static (string , int) LooksDangerousWords(string input)
        {
            return ("",0);
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
