using DemoExpressionLambda;

// Passer un comportement en paramètre à une fonction : Callback 
static bool EstPair(int x)
{
    return x % 2 == 0;
}

List<int> nombres = new List<int> { 1, 2, 3, 4, 5, 6, 7 };



//les types délégués générieuqe func  et action : contenir une fonction

Action<string> print = Console.Writeline

// Les types délégués génériques Func et Action : une variable qui va contenir une fonction.

// Lambda
func<int, bool> fctEstPair = x => x % 2 ==0;;

// Expression lambda en Callback (retour à FindAll)
list<int> NombresPaire = nombres.FindAll(<int,bool> x => x % 2 == 0)
    foreach (int x in nombrePairs){
    Console.WriteLine(x);    
}

// LINQ et expressions lambda


// Exercice

List<Client> clients = new()
{
    new Client { Id = 1, Prenom = "Léo", Ville = "Gatineau" },
    new Client { Id = 2, Prenom = "Wilona",   Ville = "Montréal" },
    new Client { Id = 3, Prenom = "Rohan",  Ville = "Gatineau" },
    new Client { Id = 4, Prenom = "Luca", Ville = "Ottawa" },
    new Client { Id = 5, Prenom = "Julien",  Ville = "Montréal" },
    new Client { Id = 6, Prenom = "Junior",     Ville = "Sherbrooke" },
    new Client { Id = 7, Prenom = "Jonathan",Ville = "Gatineau" },
    new Client { Id = 8, Prenom = "Kevin",   Ville = "Montréal" }
};

// q1
list<Client> clientsGatineau = clients.Where(clients => clients.Ville == "Gatineau")

//q2
list<Client> clientsPrenoms = clients.Select(clients => clients.Prenom)

//q3
list<Client> clientsTries = clients.OrderBy(clients => clients.Prenom)
foreach(Client client in clientsTries){
    print(client)
}
    

//q4
int NbMontrealais = clients.Count(clients => clients.Ville == "Montréal")
print(NbMontrealaisNbMontrealais)

//q5
bool clientQuebecExiste = clients.Any(clients => client.ville =="Québec")
print(clientQuebecExiste)
    
//q6
Client clientA = clients.FirstOrDefault(clients => clients.Prenom[0] == 'A')