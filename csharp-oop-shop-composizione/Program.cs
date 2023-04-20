/* Esercizio di oggi: CSharp Composizione Shop
 * Nome repo: csharp-oop-shop-composizione
 * L'idea è di creare una classe Negozio che possa contenere una lista dei prodotti trattati per uno (o eventualmente più) shop.
 * --------------------------------------------------------------------------------------------------------------------------------
 * Avvalendosi della "composizione" e usando quanto già fatto nella vostra classe Prodotto, costruite questa nuova classe chiamata
 * "Negozio" (O se volete tenere tutto in Inglese "Shop") con cui poter effettuare dall'esterno le seguenti operazioni:
 * Inizializzare correttamente uno shop (Lo shop deve avere un nome, una citta, un indirizzo, un numero civico).
 * La lista dei prodotti iniziali potrebbe essere vuota al momento, ma ricordatevi almeno di inizializzarla!
 * si possano chiedere ognuna delle informazioni contenute nel negozio
 * si possa modificare alcune delle informazioni dello shop (pensate bene voi a cosa posso far cambiare allo shop o meno)
 * si possa inserire la lista di prodotti inziali o eventualmente una lista di prodotti nuovi che tratterò in più da oggi in poi
 * si possa inserire anche un prodotto singolo in più al negozio
 * si possa chiedere ad uno shop di darmi la sua rappresentazione in stringa e io possa stamparla in Console
 * --------------------------------------------------------------------------------------------------------------------------------
 * A questo punto provate a creare qualche prodotto, ed inserirlo in una lista di prodotti iniziali. Create il vostro shop e 
 * aggiungetegli la lista iniziale dei prodotti. Stampate le informazioni del negozio (avvalendovi del metodo fatto nel negozio) 
 * e assicuratevi che i prodotti iniziali (o aggiunti anche successivamente) vengano stampati bene e in maniera corretta nel modo
 * Provate ad aggiungere un nuovo prodotto allo shop, o una lista nuova di prodotti che volete che lo shop tratti 
 * e provate a ristampare le informazioni del negozio con i nuovi prodotti via via aggiornati in Console.
 * Aggiungete poi ai vostri prodotti anche una Categoria ( o Category ) avvalendovi sempre del metodo della composizione, questa 
 * volta dentro il vostro Prodotto, in modo che potete tenere traccia della categoria di ogni prodotto. 
 * La categoria, oltre al semplice nome, potrebbe avere una descrizione e un codice identificativo ad uso interno.
 */

using csharp_oop_shop_composizione;
Shop Carrefour = new Shop("Carrefour", "Roma", "Via Prassilla", "10");

Product Pane = new Product("Pane", "Integrale", 0.59f);
Product Acqua = new Product("Acqua", "Naturale", 2.10f);
Product Pasta = new Product("Pasta", "Spaghetti", 1.30f);

List<Product> newProductList = new List<Product> { Pane, Acqua, Pasta };
Carrefour.AddNewProductListToShopList(newProductList);

string infoShop = Carrefour.PrintShopInfo();
Console.WriteLine(infoShop);