using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Angelo", "Dalo", 23);
            Persona persona2 = new Persona("Angelo2", "Dalo2", 24);
            //La proprietaà statica sarà uguale per tutti
            Console.WriteLine(Persona.numeroPersone);
            Persona.Saluta();
        }
    }

    class Persona
    {
        private string nome; //proprietà
        public string cognome;
        public int eta;
        //numero Persone viene condiviso, diventa proprietà della classe
        static public int numeroPersone = 0;
        //COSTRUTTORE
        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            Persona.numeroPersone++;
        }

        static public void Saluta()
        {
            Console.WriteLine("ciao " + Persona.numeroPersone);
        }
    }
}


