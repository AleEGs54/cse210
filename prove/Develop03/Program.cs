using System;

class Program
{
    static void Main(string[] args)
    {
        //First, create a Reference object otherwise, we wont have anything to fullfil as parameter
        Reference reference1 = new Reference(book: "John", chapter: 3, verse: 5);

        //Then, create a variable with the scriptur within
        string scriptureText = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";

        //Finally create a Scripture object
        Scripture scripture1  = new Scripture(Reference: reference1, text: scriptureText);
    }
}