using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
// FEITO

Iphone i1 = new Iphone("4444-444","iPhone 14", "123456789012345", 128);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Claro"); 

Nokia n1 = new Nokia ("5555-555", "Nokia12", "45855555888", 128);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Youtube");
