# Informatica - Classi Terze - Esercizio 4.1 - Console Applications

Si implementi un men&uacute; con scelta numerica da 1 a 3, a cui ogni scelta corrisponde
un esercizio da implementare come segue:

Dati 2 vettori di interi **univoci** in input, stampare a video:

1. Il vettore ottenuto dalla loro intersezione
2. Il vettore ottenuto dalla loro unione
3. Il vettore ottenuto dalla loro differenza
4. Se il primo vettore è interamente contenuto del secondo vettore

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

#### INPUT (dimensione non valida)

```
1
-1
```

#### OUTPUT

```
Inserisci una dimensione maggiore di 0
```

---

#### INPUT (scelta 1)

```
1
3
1
2
3
4
1
2
3
4
```

#### OUTPUT

```
Il vettore intersezione è 1 2 3
```

---

#### INPUT (scelta 1)

```
1
3
1
2
3
4
4
5
6
7
```

#### OUTPUT

```
Il vettore intersezione è vuoto
```

---

#### INPUT (scelta 2)

```
2
4
5
3
66
7
5
1
2
3
4
5
```

#### OUTPUT

```
Il vettore unione è 5 3 66 7 1 2 4
```

---

#### INPUT (scelta 3)

```
3
4
1
2
3
4
5
99
9
2
4
1
```

#### OUTPUT

```
Il vettore differenza è 3
```

---

#### INPUT (scelta 3)

```
3
2
1
1
3
1
1
2
```

#### OUTPUT

```
Il vettore differenza è vuoto
```
