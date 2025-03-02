using OOP;

Cat murka = new Cat();
Cat moska = new Cat();


murka.age = 5;
murka.name = "Murka";
murka.color = "белая";
murka.poroda = "сиамская";
murka.height = 30;

moska.age = 9;
moska.name = "moska";
moska.color = "черная";
murka.poroda = "бенгальская";
moska.height = 35;


moska.SetTailLength(10);
murka.SetTailLength(20);

moska.GetTailLength();
murka.GetTailLength();


Child molodoi_chelovek = new Child();
molodoi_chelovek.SetName("petechka");


