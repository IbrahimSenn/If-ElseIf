int time = DateTime.Now.Hour;

if ( time>=6 && time<11 )

    Console.WriteLine("günaydın");
else if( time<=18 )

    Console.WriteLine("iyi günler");
else

    Console.WriteLine("iyi geceler");

string sonuc = time<=18 ? "İyi günler" : "İyi geceler" ;

    Console.WriteLine(sonuc );