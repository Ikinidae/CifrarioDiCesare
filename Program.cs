//Realizzare un programma in grado di CRIPTARE e DECRIPTARE una stringa inserita dall’utente con la strategia di criptazione nota come “IL CIFRARIO DI CESARE”
//Mi raccomando ci sono diversi modi di integrarlo, scegliete una strategia semplice in base a quello che abbiamo spiegato:
//l’utente inserisce una stringa da criptare / decriptare
//l’utente inserisce una chiave numerica per effettuare la criptazione / decriptazione della stringa inserita

//per criptare: ogni lettera corrisponde alla lettera x posizioni dopo (ad es. 3: a = d; e = h)
//per decriptare: ogni lettera corrisponde alla lettera x posizioni prima (ad es. 3: d = a; h = e)


//chiedere all'utente se la frase è da criptare o decriptare e qual è la chiave numerica

Console.WriteLine("La frase è da criptare? Rispondere 'si' o 'no'");
string cript = Console.ReadLine();

Console.WriteLine("Qual è la chiave numerica? Inserire un numero");
int numberKey = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire la frase:");
string input = Console.ReadLine();

Cesare(cript, numberKey, input);


void Cesare(string cript, int numberKey, string input)
{
    char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'z' };
        
    //dividere le singole lettere della stringa ed inserirle in un array [c, i, a, o]
    char[] inputCharArray = input.ToCharArray();

    //se è da criptare
    if (cript == "si")
    {
        string cryptedInput = "";
        for (int i = 0; i < input.Length; i++)
        {
            int j = 0;
            for (; j < alphabet.Length; j++)
            {
                // confronto la lettera iesima della parola con la lettera jesima dell'alfabeto
                if (inputCharArray[i] == alphabet[j])
                {
                    break;
                }
            }
            //usare la chiave numerica per criptare le lettere
            if (j + numberKey > alphabet.Length - 1)
            {
                //riunire le lettere in una stringa
                cryptedInput += alphabet[j + numberKey - alphabet.Length];
            }
            else
            {
                cryptedInput += alphabet[j + numberKey];
            }
        }
        Console.WriteLine(cryptedInput);
    }

    //se è da decriptare
    else
    {
        string decryptedInput = "";
        for (int i = 0; i < input.Length; i++)
        {
            int j = 0;
            for (; j < alphabet.Length; j++)
            {
                if (inputCharArray[i] == alphabet[j])
                {
                    break;
                }
            }
            if (j - numberKey < 0)
            {
                decryptedInput += alphabet[j - numberKey + alphabet.Length];
            }
            else
            {
                decryptedInput += alphabet[j - numberKey];
            }
        }
        Console.WriteLine(decryptedInput);
    }
}