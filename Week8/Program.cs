// See https://aka.ms/new-console-template for more information

using Week8;

Console.WriteLine("Hello, World!");
DeliveryItem letter1 = new Letter("1234", 1.0);
DeliveryItem letter2 = new Letter("1345", 17.4);
DeliveryItem percel1 = new Percel("7425", 110.9, "10*12*31");
DeliveryItem percel2 = new Percel("7490", 1.2, "15*4*25");
letter1.PrintInfo();
percel1.PrintInfo();
CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
myCargo.AddItem(letter1);
myCargo.AddItem(letter2);
myCargo.AddItem(percel1);
myCargo.AddItem(percel2);
Console.WriteLine(myCargo.GetTotalCost());
