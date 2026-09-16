using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace lesson
{
    public class Program
    {
        static readonly int numberOfPokémons = 151;
        static readonly string[] pokémonNames = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran ♀ (Female)", "Nidorina", "Nidoqueen", "Nidoran ♂ (Male)", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
        static readonly string[] pokémonImages = { "http://www.serebii.net/pokemongo/pokemon/001.png", "http://www.serebii.net/pokemongo/pokemon/002.png", "http://www.serebii.net/pokemongo/pokemon/003.png", "http://www.serebii.net/pokemongo/pokemon/004.png", "http://www.serebii.net/pokemongo/pokemon/005.png", "http://www.serebii.net/pokemongo/pokemon/006.png", "http://www.serebii.net/pokemongo/pokemon/007.png", "http://www.serebii.net/pokemongo/pokemon/008.png", "http://www.serebii.net/pokemongo/pokemon/009.png", "http://www.serebii.net/pokemongo/pokemon/010.png", "http://www.serebii.net/pokemongo/pokemon/011.png", "http://www.serebii.net/pokemongo/pokemon/012.png", "http://www.serebii.net/pokemongo/pokemon/013.png", "http://www.serebii.net/pokemongo/pokemon/014.png", "http://www.serebii.net/pokemongo/pokemon/015.png", "http://www.serebii.net/pokemongo/pokemon/016.png", "http://www.serebii.net/pokemongo/pokemon/017.png", "http://www.serebii.net/pokemongo/pokemon/018.png", "http://www.serebii.net/pokemongo/pokemon/019.png", "http://www.serebii.net/pokemongo/pokemon/020.png", "http://www.serebii.net/pokemongo/pokemon/021.png", "http://www.serebii.net/pokemongo/pokemon/022.png", "http://www.serebii.net/pokemongo/pokemon/023.png", "http://www.serebii.net/pokemongo/pokemon/024.png", "http://www.serebii.net/pokemongo/pokemon/025.png", "http://www.serebii.net/pokemongo/pokemon/026.png", "http://www.serebii.net/pokemongo/pokemon/027.png", "http://www.serebii.net/pokemongo/pokemon/028.png", "http://www.serebii.net/pokemongo/pokemon/029.png", "http://www.serebii.net/pokemongo/pokemon/030.png", "http://www.serebii.net/pokemongo/pokemon/031.png", "http://www.serebii.net/pokemongo/pokemon/032.png", "http://www.serebii.net/pokemongo/pokemon/033.png", "http://www.serebii.net/pokemongo/pokemon/034.png", "http://www.serebii.net/pokemongo/pokemon/035.png", "http://www.serebii.net/pokemongo/pokemon/036.png", "http://www.serebii.net/pokemongo/pokemon/037.png", "http://www.serebii.net/pokemongo/pokemon/038.png", "http://www.serebii.net/pokemongo/pokemon/039.png", "http://www.serebii.net/pokemongo/pokemon/040.png", "http://www.serebii.net/pokemongo/pokemon/041.png", "http://www.serebii.net/pokemongo/pokemon/042.png", "http://www.serebii.net/pokemongo/pokemon/043.png", "http://www.serebii.net/pokemongo/pokemon/044.png", "http://www.serebii.net/pokemongo/pokemon/045.png", "http://www.serebii.net/pokemongo/pokemon/046.png", "http://www.serebii.net/pokemongo/pokemon/047.png", "http://www.serebii.net/pokemongo/pokemon/048.png", "http://www.serebii.net/pokemongo/pokemon/049.png", "http://www.serebii.net/pokemongo/pokemon/050.png", "http://www.serebii.net/pokemongo/pokemon/051.png", "http://www.serebii.net/pokemongo/pokemon/052.png", "http://www.serebii.net/pokemongo/pokemon/053.png", "http://www.serebii.net/pokemongo/pokemon/054.png", "http://www.serebii.net/pokemongo/pokemon/055.png", "http://www.serebii.net/pokemongo/pokemon/056.png", "http://www.serebii.net/pokemongo/pokemon/057.png", "http://www.serebii.net/pokemongo/pokemon/058.png", "http://www.serebii.net/pokemongo/pokemon/059.png", "http://www.serebii.net/pokemongo/pokemon/060.png", "http://www.serebii.net/pokemongo/pokemon/061.png", "http://www.serebii.net/pokemongo/pokemon/062.png", "http://www.serebii.net/pokemongo/pokemon/063.png", "http://www.serebii.net/pokemongo/pokemon/064.png", "http://www.serebii.net/pokemongo/pokemon/065.png", "http://www.serebii.net/pokemongo/pokemon/066.png", "http://www.serebii.net/pokemongo/pokemon/067.png", "http://www.serebii.net/pokemongo/pokemon/068.png", "http://www.serebii.net/pokemongo/pokemon/069.png", "http://www.serebii.net/pokemongo/pokemon/070.png", "http://www.serebii.net/pokemongo/pokemon/071.png", "http://www.serebii.net/pokemongo/pokemon/072.png", "http://www.serebii.net/pokemongo/pokemon/073.png", "http://www.serebii.net/pokemongo/pokemon/074.png", "http://www.serebii.net/pokemongo/pokemon/075.png", "http://www.serebii.net/pokemongo/pokemon/076.png", "http://www.serebii.net/pokemongo/pokemon/077.png", "http://www.serebii.net/pokemongo/pokemon/078.png", "http://www.serebii.net/pokemongo/pokemon/079.png", "http://www.serebii.net/pokemongo/pokemon/080.png", "http://www.serebii.net/pokemongo/pokemon/081.png", "http://www.serebii.net/pokemongo/pokemon/082.png", "http://www.serebii.net/pokemongo/pokemon/083.png", "http://www.serebii.net/pokemongo/pokemon/084.png", "http://www.serebii.net/pokemongo/pokemon/085.png", "http://www.serebii.net/pokemongo/pokemon/086.png", "http://www.serebii.net/pokemongo/pokemon/087.png", "http://www.serebii.net/pokemongo/pokemon/088.png", "http://www.serebii.net/pokemongo/pokemon/089.png", "http://www.serebii.net/pokemongo/pokemon/090.png", "http://www.serebii.net/pokemongo/pokemon/091.png", "http://www.serebii.net/pokemongo/pokemon/092.png", "http://www.serebii.net/pokemongo/pokemon/093.png", "http://www.serebii.net/pokemongo/pokemon/094.png", "http://www.serebii.net/pokemongo/pokemon/095.png", "http://www.serebii.net/pokemongo/pokemon/096.png", "http://www.serebii.net/pokemongo/pokemon/097.png", "http://www.serebii.net/pokemongo/pokemon/098.png", "http://www.serebii.net/pokemongo/pokemon/099.png", "http://www.serebii.net/pokemongo/pokemon/100.png", "http://www.serebii.net/pokemongo/pokemon/101.png", "http://www.serebii.net/pokemongo/pokemon/102.png", "http://www.serebii.net/pokemongo/pokemon/103.png", "http://www.serebii.net/pokemongo/pokemon/104.png", "http://www.serebii.net/pokemongo/pokemon/105.png", "http://www.serebii.net/pokemongo/pokemon/106.png", "http://www.serebii.net/pokemongo/pokemon/107.png", "http://www.serebii.net/pokemongo/pokemon/108.png", "http://www.serebii.net/pokemongo/pokemon/109.png", "http://www.serebii.net/pokemongo/pokemon/110.png", "http://www.serebii.net/pokemongo/pokemon/111.png", "http://www.serebii.net/pokemongo/pokemon/112.png", "http://www.serebii.net/pokemongo/pokemon/113.png", "http://www.serebii.net/pokemongo/pokemon/114.png", "http://www.serebii.net/pokemongo/pokemon/115.png", "http://www.serebii.net/pokemongo/pokemon/116.png", "http://www.serebii.net/pokemongo/pokemon/117.png", "http://www.serebii.net/pokemongo/pokemon/118.png", "http://www.serebii.net/pokemongo/pokemon/119.png", "http://www.serebii.net/pokemongo/pokemon/120.png", "http://www.serebii.net/pokemongo/pokemon/121.png", "http://www.serebii.net/pokemongo/pokemon/122.png", "http://www.serebii.net/pokemongo/pokemon/123.png", "http://www.serebii.net/pokemongo/pokemon/124.png", "http://www.serebii.net/pokemongo/pokemon/125.png", "http://www.serebii.net/pokemongo/pokemon/126.png", "http://www.serebii.net/pokemongo/pokemon/127.png", "http://www.serebii.net/pokemongo/pokemon/128.png", "http://www.serebii.net/pokemongo/pokemon/129.png", "http://www.serebii.net/pokemongo/pokemon/130.png", "http://www.serebii.net/pokemongo/pokemon/131.png", "http://www.serebii.net/pokemongo/pokemon/132.png", "http://www.serebii.net/pokemongo/pokemon/133.png", "http://www.serebii.net/pokemongo/pokemon/134.png", "http://www.serebii.net/pokemongo/pokemon/135.png", "http://www.serebii.net/pokemongo/pokemon/136.png", "http://www.serebii.net/pokemongo/pokemon/137.png", "http://www.serebii.net/pokemongo/pokemon/138.png", "http://www.serebii.net/pokemongo/pokemon/139.png", "http://www.serebii.net/pokemongo/pokemon/140.png", "http://www.serebii.net/pokemongo/pokemon/141.png", "http://www.serebii.net/pokemongo/pokemon/142.png", "http://www.serebii.net/pokemongo/pokemon/143.png", "http://www.serebii.net/pokemongo/pokemon/144.png", "http://www.serebii.net/pokemongo/pokemon/145.png", "http://www.serebii.net/pokemongo/pokemon/146.png", "http://www.serebii.net/pokemongo/pokemon/147.png", "http://www.serebii.net/pokemongo/pokemon/148.png", "http://www.serebii.net/pokemongo/pokemon/149.png", "http://www.serebii.net/pokemongo/pokemon/150.png", "http://www.serebii.net/pokemongo/pokemon/151.png" };
        static readonly string[] pokémonTypes = { "Grass,Poison", "Grass,Poison", "Grass,Poison", "Fire", "Fire", "Fire,Flying", "Water", "Water", "Water", "Bug", "Bug", "Bug,Flying", "Bug,Poison", "Bug,Poison", "Bug,Poison", "Normal,Flying", "Normal,Flying", "Normal,Flying", "Normal", "Normal", "Normal,Flying", "Normal,Flying", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison,Ground", "Poison", "Poison", "Poison,Ground", "Normal", "Normal", "Fire", "Fire", "Normal", "Normal", "Poison,Flying", "Poison,Flying", "Grass,Poison", "Grass,Poison", "Grass,Poison", "Bug,Grass", "Bug,Grass", "Bug,Poison", "Bug,Poison", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water,Fighting", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass,Poison", "Grass,Poison", "Grass,Poison", "Water,Poison", "Water,Poison", "Rock,Ground", "Rock,Ground", "Rock,Ground", "Fire", "Fire", "Water,Psychic", "Water,Psychic", "Electric", "Electric", "Normal,Flying", "Normal,Flying", "Normal,Flying", "Water", "Water,Ice", "Poison", "Poison", "Water", "Water,Ice", "Ghost,Poison", "Ghost,Poison", "Ghost,Poison", "Rock,Ground", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass,Psychic", "Grass,Psychic", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground,Rock", "Ground,Rock", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water,Psychic", "Psychic", "Bug,Flying", "Ice,Psychic", "Electric", "Fire", "Bug", "Normal", "Water", "Water,Flying", "Water,Ice", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock,Water", "Rock,Water", "Rock,Water", "Rock,Water", "Rock,Flying", "Normal", "Ice,Flying", "Electric,Flying", "Fire,Flying", "Dragon", "Dragon", "Dragon,Flying", "Psychic", "Psychic" };
        static readonly int[] pokémonCatchResistance = { 31, 96, 99, 75, 99, 100, 43, 97, 100, 5, 82, 98, 5, 56, 95, 5, 5, 87, 5, 59, 5, 85, 5, 93, 79, 100, 5, 97, 5, 92, 99, 5, 92, 99, 8, 99, 78, 100, 61, 99, 5, 58, 5, 94, 100, 5, 93, 5, 93, 60, 99, 14, 98, 5, 92, 8, 97, 8, 99, 5, 87, 99, 58, 98, 100, 51, 97, 100, 5, 93, 100, 19, 92, 5, 93, 100, 49, 99, 5, 97, 29, 98, 98, 48, 78, 72, 99, 95, 100, 48, 99, 21, 95, 100, 90, 5, 90, 5, 94, 35, 98, 22, 99, 39, 98, 98, 98, 99, 80, 99, 37, 98, 99, 78, 100, 5, 97, 5, 92, 5, 97, 100, 86, 65, 93, 90, 5, 88, 5, 100, 100, 100, 5, 99, 99, 99, 99, 86, 100, 90, 100, 99, 99, 100, 100, 100, 70, 98, 100, 100, 100 };
        
        static Random rnd = new Random();

        private static int Menu()
        {
            int choice;
            bool isCorrect = false;

            do
            {
                Console.Clear();

                Console.WriteLine("1 - Consulta il pokédex ");
                Console.WriteLine("2 - Vai a catturare qualche pokémon ");
                Console.WriteLine("3 - Esci ");

                int.TryParse(Console.ReadLine(), out choice);

                if (choice == 1 || choice == 2 || choice == 3)
                {
                    isCorrect = true;
                }

            } while (!isCorrect);

            return choice;
        }

        private static int MenuCattura()
        {
            int choice;
            bool isCorrect = false;

            do
            {
                Console.WriteLine("1 - Lancia Pokéball ");
                Console.WriteLine("2 - Fuggi ");

                int.TryParse(Console.ReadLine(), out choice);

                if (choice == 1 || choice == 2)
                {
                    isCorrect = true;
                }

            } while (!isCorrect);

            return choice;
        }


        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                choice = Menu();

                if(choice == 3)
                {
                    Console.WriteLine("Torna presto!");
                }
                else if(choice == 1)
                {
                    int nPokemon = 0;

                    Console.WriteLine("Inserisci il numero del pokémon di cui vuoi i dettagli ");
                    int.TryParse(Console.ReadLine(), out nPokemon);
    
                    if (nPokemon > 0 && nPokemon <= 151)
                    {
                        nPokemon -= 1;

                        Console.WriteLine("Pokémon N° " + nPokemon);
                        Console.WriteLine(pokémonNames[nPokemon]);
                        Console.WriteLine("Tipo: " + pokémonTypes[nPokemon]);
                        Console.WriteLine("Immagine: " + pokémonImages[nPokemon]);
                        Console.WriteLine("Premi invio per continuare...");

                        if (Console.ReadKey(true).Key == ConsoleKey.Enter) { }

                    }
                    else
                    {
                        Console.WriteLine("Inserisci un numero fra 1 e 151");
                        Console.WriteLine("Premi invio per continuare...");

                        if (Console.ReadKey(true).Key == ConsoleKey.Enter) { }
                    }
                    
                }
                else if (choice == 2)
                {
                    int nPokeballs = 5;
                    int nPokemon = rnd.Next(1, 152);

                    Console.WriteLine("Hai 5 pokéballs e decidi di andare a catturare qualche pokémon...");

                    Console.WriteLine("Appare un " + pokémonNames[nPokemon] + " selvatico!");

                    bool isCatched = false;

                    do
                    {
                        
                        int catchRate = 0;
                        int choiceCatch = MenuCattura();

                        if(choiceCatch == 1)
                        {
                            nPokeballs--;

                            Console.WriteLine("Lanci una pokéball al " + pokémonNames[nPokemon] + " selvatico");
                            Console.WriteLine(".\n..\n...");

                            if(pokémonCatchResistance[nPokemon] <= 0)
                            {
                                Console.WriteLine("Evviva, " + pokémonNames[nPokemon] + " catturato con successo!");
                                isCatched = true;


                                Console.WriteLine("Premi invio per continuare...");
                                if (Console.ReadKey(true).Key == ConsoleKey.Enter) { }
                            }
                            else
                            {
                                Console.WriteLine("Oh no! Il " + pokémonNames[nPokemon] + " selvatico si è liberato!");
                                
                                if(nPokeballs == 0)
                                {
                                    Console.WriteLine("Il " + pokémonNames[nPokemon] + " è fuggito.");
                                    Console.WriteLine("Premi invio per continuare...");
                                    if (Console.ReadKey(true).Key == ConsoleKey.Enter) { }
                                }

                                catchRate = rnd.Next(5, 101);
                                pokémonCatchResistance[nPokemon] -= catchRate;
                            }
                            
                        }
                        else if(choiceCatch == 2)
                        {
                            Console.WriteLine("Scampato Pericolo!");

                            Console.WriteLine("Premi invio per continuare...");
                            if (Console.ReadKey(true).Key == ConsoleKey.Enter) { }

                            isCatched = true;
                        }

                    } while (nPokeballs != 0 && !isCatched);
                }

            } while (choice != 3);
        }
    }
}
