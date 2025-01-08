using challenger_poo.Models;

Nokia n1 = new Nokia("172821723", "N2", "192371", 64);
Iphone I1 = new Iphone("12838192", "Iphone 11", "127312", 128);

n1.Ligar("12821");
n1.ReceberLigacao();
n1.InstalarAplicativo("Aplicativo do Nokia");

I1.Ligar("182931");
I1.ReceberLigacao();
I1.InstalarAplicativo("Aplicativo do Iphone");
