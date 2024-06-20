using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Utente
    {
        public string NomeUtente { get; private set; }
        private string Password;
        public bool Logged { get; private set; }
        public DateTime LoginTime { get; private set; }
        public List<DateTime> Accessi { get; private set; }

        public Utente(string nomeUtente, string password)
        {
            NomeUtente = nomeUtente;
            Password = password;
            Logged = false;
            Accessi = new List<DateTime>();
        }

        public void Login(string nomeUtenteInserito, string passwordInserita, string confermaPassword)
        {
            if (Logged)
            {
                Console.WriteLine("Utente già loggato.");
                return;
            }

            if (nomeUtenteInserito != NomeUtente)
            {
                Console.WriteLine("Nome utente errato.");
                return;
            }

            if (passwordInserita != Password)
            {
                Console.WriteLine("Password errata.");
                return;
            }

            if (passwordInserita != confermaPassword)
            {
                Console.WriteLine("Le password non coincidono.");
                return;
            }

            Logged = true;
            LoginTime = DateTime.Now;
            Accessi.Add(LoginTime);
            Console.WriteLine("Login effettuato con successo.");
        }

        public void Logout()
        {
            if (Logged)
            {
                Logged = false;
                Console.WriteLine("Logout avvenuto con successo.");
            }
            else
            {
                Console.WriteLine("L'utente non ha ancora effettuato il login.");
            }
        }

        public void VerificaLogin()
        {
            if (Logged)
            {
                Console.WriteLine($"Ultimo login effettuato il: {LoginTime}");
            }
            else
            {
                Console.WriteLine("Nessun utente attualmente loggato.");
            }
        }

        public void ListaAccessi()
        {
            if (Accessi.Count == 0)
            {
                Console.WriteLine("Nessun accesso registrato.");
                return;
            }

            Console.WriteLine("Storico accessi:");
            for (int i = 0; i < Accessi.Count; i++)
            {
                Console.WriteLine(Accessi[i]);
            }
        }
    }
}
