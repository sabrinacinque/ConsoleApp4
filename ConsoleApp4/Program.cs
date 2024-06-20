using ConsoleApp4;

internal class Program
{
    static void Main(string[] args)
    {
        Utente utente1 = new Utente("Pippo", "password");

        Console.WriteLine("Benvenuto nel nostro sito");
        Console.WriteLine("Questo è il nostro menu:");
        bool esci = false;

        do
        {
            Console.WriteLine("===============OPERAZIONI==============");
            Console.WriteLine("Scegli l'operazione da effettuare:");
            Console.WriteLine("1.: Login");
            Console.WriteLine("2.: Logout");
            Console.WriteLine("3.: Verifica ora e data di login");
            Console.WriteLine("4.: Lista degli accessi");
            Console.WriteLine("5.: Esci");
            Console.WriteLine("========================================");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci il nome utente: ");
                    string nomeUtente = Console.ReadLine();
                    Console.Write("Inserisci la password: ");
                    string password = Console.ReadLine();
                    Console.Write("Conferma la password: ");
                    string confirmPassword = Console.ReadLine();
                    utente1.Login(nomeUtente, password, confirmPassword);
                    break;

                case "2":
                    utente1.Logout();
                    break;

                case "3":
                    utente1.VerificaLogin();
                    break;

                case "4":
                    utente1.ListaAccessi();
                    break;

                case "5":
                    esci = true;
                    break;

                default:
                    Console.WriteLine("Inserire un valore valido.");
                    break;
            }

        } while (!esci);

        Console.WriteLine("Grazie per aver visitato il nostro sito");
    }
}