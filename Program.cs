using System; 
class Complex 
{ 
    int real, imaginary; 
    // Constructor 
    public Complex(int r, int i) 
    { 
        real = r; 
        imaginary = i; 
    } 
    // Operator Overloading 
    public static Complex operator +(Complex c1, Complex c2) 
    { 
        return new Complex(c1.real + c2.real, 
                           c1.imaginary + c2.imaginary); 
    } 
    // Display Method 
    public void Display() 
    { 
        Console.WriteLine(real + " + " + imaginary + "i"); 
    } 
} 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Complex c1 = new Complex(5, 4); 
        Complex c2 = new Complex(3, 2); 
        Console.Write("First Complex Number  : "); 
        c1.Display(); 
        Console.Write("Second Complex Number : "); 
        c2.Display(); 
        Complex c3 = c1 + c2; 
        Console.Write("Result after Addition : "); 
        c3.Display(); 
        Console.ReadKey(); 
    } 
} 
 