# Informatica - Classi Terze - Lezione 4 - Console Applications

In questa esercitazione andremo a esaminare il tipo di dato `array` e come
lo possiamo usare per effettuare operazioni su insiemi di dati omogenei.

L'obiettivo finale &egrave; di implementare una suite di sotto-programmi e
funzioni per eseguire le operazioni pi&uacute; comuni sugli array.

> Ogni vettore viene acquisito secondo input dal terminale: il primo numero rappresenta la
> dimensione dell'array, gli altri i valori nell'array stesso.

In particolare occorre implementare le funzioni (la cui firma trovate nel 
file `Program.cs`). Ogni funzione è collegata a una voce di un men&uacute;
che va costruito:

1. Stampa a video di un array
2. Stampa a video delle celle di un array di indice pari
3. Stampa a video delle celle di un array di indice dispari, separate da una virgola
4. Stampa a video l'inverso dell'array ricevuto in input
5. Verificare se gli elementi di un vettore sono ordinati, specificando se l'ordinamento &egrave; crescente o decrescente
   > Suggerimento: non bisogna usare il ciclo `for`, in quanto l'algoritmo termina quando si trovano due elementi non ordinati.
6. Contare il numero di volte in cui un valore X ricevuto in input compare tra gli elementi del vettore ricevuto in input.

Eccovi alcuni suggerimenti per passare i test:
> 1. Evitate i `Console.ReadKey()` al fondo del programma
> 2. Quando stampate gli array, includete uno e un solo `Console.WriteLine()` per andare a capo alla fine della stampa
> 3. Ricordate che nei vettori **gli indici partono da zero!**
> 4. Tranne dove diversamente specificato, in ogni stampa a video gli elementi vanno separati da uno spazio.
>    Esempio: `1 2 3 4`

## Il tipo di dato `array` (vettore)

Gli array (o vettori) sono strutture dati fondamentali che consentono di archiviare e gestire una raccolta di elementi
dello stesso tipo.

### Dichiarazione e Inizializzazione

Per dichiarare un array, si specifica il tipo degli elementi seguito da parentesi quadre. Ad esempio, per dichiarare un array di interi:

```csharp
const int SIZE = 10
int[] numbers = new int[SIZE];
```

Per inizializzare l'array con valori (notare come la dimensione non è necessaria):

```csharp
int[] numbers = {1, 2, 3, 4, 5};
```

Gli elementi di un array sono accessibili tramite l'indice, che parte da 0. Ad esempio, per accedere al primo elemento:

```csharp
int firstNumber = numbers[0]; // 1
```

È possibile modificare il valore di un elemento specifico utilizzando il suo indice:

```csharp
numbers[0] = 10;
```

Per ottenere il numero di elementi in un array, si utilizza la proprietà `Length`:

```csharp
int numberOfItems = numbers.Length; // 5
```

## Esempi di esecuzione

Eccovi qualche esempio di esecuzione:

#### INPUT (scelta non valida)

```
-1
```

#### OUTPUT

```
Scelta non valida
```

---

#### INPUT (scelta non valida)

```
1
-1
```

#### OUTPUT

```
Inserisci una dimensione maggiore di 0
```

---

#### INPUT (scelta 1, array di 2 elementi)

```
1
2
10
5
```

#### OUTPUT

```
10 5
```

---

#### INPUT (scelta 2, array di 5 elementi)

```
2
5
10
5
1
4
5
```

#### OUTPUT

```
10 1 5
```

---

#### INPUT (scelta 3, array di 5 elementi)

```
3
5
10
5
1
4
5
```

#### OUTPUT

```
5,4
```

---

#### INPUT (scelta 4, array di 3 elementi)

```
4
3
1
2
3
```

#### OUTPUT

```
3 2 1
```

---

#### INPUT (scelta 5, array di 5 elementi, ordinato crescente)

```
5
5
1
2
3
4
5
```

#### OUTPUT

```
L'array è ordinato in modo crescente
```

---

#### INPUT (scelta 5, array di 5 elementi, ordinato decrescente)

```
5
5
5
4
3
2
1
```

#### OUTPUT

```
L'array è ordinato in modo decrescente
```

---

#### INPUT (scelta 5, array di 5 elementi, non ordinato)

```
5
5
5
2
1
4
2
```

#### OUTPUT

```
L'array non è ordinato
```

---

#### INPUT (scelta 6, array di 5 elementi, numero input 4)

```
6
5
1
2
3
4
5
4
```

#### OUTPUT

```
Il numero 4 compare 1 volta nel vettore 1 2 3 4 5
```

---

#### INPUT (scelta 6, array di 5 elementi, numero input 3)

```
6
5
3
3
3
4
5
3
```

#### OUTPUT

```
Il numero 3 compare 3 volte nel vettore 3 3 3 4 5
```

---

#### INPUT (scelta 6, array di 5 elementi, numero input 1 - non presente)

```
6
5
9
2
3
4
5
1
```

#### OUTPUT

```
Il numero 1 non compare nel vettore 9 2 3 4 5
```
