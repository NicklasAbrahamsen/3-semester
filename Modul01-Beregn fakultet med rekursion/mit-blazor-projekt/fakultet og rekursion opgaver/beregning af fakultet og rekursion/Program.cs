// opgave 3

Console.WriteLine(Opgave3.Faculty(5)); // Output skal være '120'.

class Opgave3 {
  public static int Faculty(int n) {
    if (n == 0) {
        return 1;
    }

    return n * Faculty(n - 1);
}
}

/*/
Termineringsregel: 0! = 1
Rekurrensregel: n! = n * (n - 1)! hvor n > 0.
Fakultet er en matematisk funktion, der beregner produktet af alle heltal 
fra 1 til et givet tal. For eksempel er fakultet af 5: 
1 * 2 * 3 * 4 * 5 = 120. Her er en implementering af metoden i C#:
/*/
