namespace PhillCRIta.github.io;
class Program
{
    /*I membri con corpo di espressione forniscono una sintassi minima e concisa per definire proprietà e metodi. 
	Aiuta a eliminare il codice boilerplate e aiuta a scrivere codice più leggibile. 
	La sintassi con corpo di espressione può essere utilizzata quando il corpo di un membro è costituito da una sola espressione. 
	Utilizza l'operatore =>(freccia grassa) per definire il corpo del metodo o della proprietà e consente di eliminare le parentesi graffe e la parola chiave return. 
	La funzionalità è stata introdotta per la prima volta in C# 6.*/
    static void Main(string[] args)
    {
        Console.WriteLine("Esempi di Expression Bodied");
        //
        Console.WriteLine("1***** METHODS return, si applica quando il metodo è composto da una sola istruzione e ritorna un valore");
        Console.WriteLine("Area rettangolo 3x2 = " + AreaRettangolo(3, 2));
        Console.WriteLine("-----Funzione usata: static int AreaRettangolo(int lato1, int lato2) => lato1*lato2; ---- AreaRettangolo(3,2)");
        //
        Console.WriteLine("2***** METHODS void, si applica quando il metodo è composto da una sola istruzione e non ritorna il valore");
        Console.WriteLine("Cosa scrivi? ");
        Stampa("ciao");
        Console.WriteLine("-----Funzione usata: static void Stampa(string valore) => Console.WriteLine(\"Hai passato questo valore: \" + valore); ---- Stampa(\"ciao\");");
        //
        Console.WriteLine("3***** PROPERTY, creazione di una proprietà in sola lettura, il getter deve avere una sola istruzione");
        FiguraGeometrica fg = new FiguraGeometrica("a");
        Console.WriteLine("Area rettangolo lato  x lato = " + AreaRettangolo(lato, fg.lato));
        Console.WriteLine("-----static public int lato => 2; ---- AreaRettangolo(lato, fg.lato)");
        //
        Console.WriteLine("4***** PROPERTY, creazione di una proprietà getter e setter, definiti con una sola istruzione");
        fg.numeroMagico = 6;
        Console.WriteLine("Area rettangolo lato  x lato con numero magico = " + AreaRettangolo(fg.numeroMagico, fg.numeroMagico));
        Console.WriteLine("-----get => _numeroMagico; set => _numeroMagico = value;");
        //
        Console.WriteLine("5***** CONSTRUCTOR, costruttore che esegue una sola funzione");
        FiguraGeometrica fg2 = new FiguraGeometrica(7);
        Console.WriteLine("Area rettangolo con costruttore ExpressionBodied = " + AreaRettangolo(fg2.lato, fg2.lato));
        Console.WriteLine("----- costruttore >> public FiguraGeometrica(int latoCost) => latoInterno = latoCost; ");
        //
        Console.WriteLine("6***** INDEXER, accesso a una classe come se fosse un array");
        Console.WriteLine("Estrai il primo nome: " + fg2[0]);
        Console.WriteLine("Estrai il secondo nome: " + fg2[1]);
        Console.WriteLine("----- chiamata >> fg2[0] -- funzione   public string this[int indice]  { get {return listaNomi[indice];}  }");
    }
    //CASO 1
    static int AreaRettangolo(int lato1, int lato2) => lato1 * lato2;
    //CASO 2
    static void Stampa(string valore) => Console.WriteLine("Hai passato questo valore: " + valore);
    //CASO 3
    static public int lato => 3;
    public class FiguraGeometrica
    {
        //CASO 3
        public int lato => latoInterno;
        //CASO 4
        public int numeroMagico
        {
            //get { return _numeroMagico; }
            //set { _numeroMagico = value; }
            get => _numeroMagico;
            set => _numeroMagico = value;
        }
        //CASO 5
        public FiguraGeometrica(int latoCost) => latoInterno = latoCost;
        //CASO 5 DECOSTRUCTOR
        ~FiguraGeometrica() => Console.WriteLine("FiguraGeometrica Destructor");
        //CASO 6 INDEXER
        private List<string> listaNomi = new List<string> { "Andrea", "Marcello", "Pippo" };
        public string this[int indice]
        {
            get {return listaNomi[indice];}
        }

        //MEMBRI DI SUPPORTO
        public FiguraGeometrica(string a) { }
        private int _numeroMagico;
        private int latoInterno = 3;

    }
}

