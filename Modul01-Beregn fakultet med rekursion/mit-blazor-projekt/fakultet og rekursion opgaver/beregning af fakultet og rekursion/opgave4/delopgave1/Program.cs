// Program.cs

Console.WriteLine(Opgave4.sfd(10, 5)); 
Console.WriteLine(Opgave4.potens(5, 4)); 
Console.WriteLine(Opgave4.Multiply(10,5)); 
Console.WriteLine(Opgave4.Reverse("nicklas")); 

class Opgave4 {

//delopgave 4
    public static string Reverse(string s) {
        if (s.Length <= 1) return s;
        else return Reverse(s.Substring(1)) + s[0];
    }

//delopgave 3
public static int Multiply(int a, int b) {
    if (a == 0 || b == 0) {
        return 0;
    }
    if (a == 1) {
        return b;
    }
    return Multiply(a - 1, b) + b;
}

//delopgave 2
    public static int potens(int n, int p) { 
        if (p == 0) {
            return 1;
        } else {
            return potens(n, p - 1) * n;
        }
    }

//delopgave 1
    public static int sfd(int a, int b)
    {
        if (b <= a && a % b == 0) {
            return b;
        } else {
            if (a < b) {
                return sfd(b, a);
            } else {
                return sfd(b, a % b);
            }
        }
    }
}

/*/
Delopgave 1

Skriv en rekursiv metode der implemeterer Euclids algoritme der finder største fælles divisor af to positive heltal. Den største fælles divisor af to tal er det største heltal der går op i begge tal.

Euclids algoritme Største Fælles Divisor, sdf(a,b), kan defineres som:

Termineringsregel: b hvis b <= a og b går op i a.
Rekurrensregel:
sfd(b,a) hvis a < b
sfd(b, a % b) ellers
Bemærk at % betyder “modulu”.
/*/