using System;
int points = 0;
int played = 0;
void clear(){       //denna kod är en metod som, när den blir kallad så tar den bort all text som var på skärmen så den nya texten kommer att komma länst 
    Console.Clear();
}

Boolean repeatplayed = true;
while(repeatplayed){
    Console.WriteLine("Have you finished any of the Dark Souls games?");
    Console.WriteLine("Yes or No");
    string playedornot = Console.ReadLine();
    playedornot = playedornot.ToLower();
    if(playedornot == "yes" || playedornot == "no" || playedornot == "y" || playedornot == "n"){
        repeatplayed = false;
    }   
    if(playedornot == "no" || playedornot == "n"){
        played = 0;
    }
    else(playedornot == "yes" || playedornot == "y"){
        played ++;
    }
}

clear();


Boolean repeat = true;
while(repeat){
    Console.WriteLine("Question one:");
    Console.WriteLine("What is the name of the director who made Dark Souls?");
    Console.WriteLine("A: Hidetaka Miyazaki");
    Console.WriteLine("B: Hideo Kojima");
    Console.WriteLine("C: Masahiro Sakurai");
    string one = Console.ReadLine();
    one = one.ToLower();
    if(one == "a" || one == "b" || one == "c" ){
        repeat = false;
    }
}

clear();

Boolean repeat2 = true;
while(repeat2){
    Console.WriteLine("Question two:");
    Console.WriteLine("What is your player character called in Dark Souls 3?");
    Console.WriteLine("A: Chosen undead");
    Console.WriteLine("B: Bearer of the curse");
    Console.WriteLine("C: Ashen one");
    string two = Console.ReadLine();    
    two = two.ToLower();    
    if(two == "a" || two == "b" || two == "c" ){
        repeat2 = false;
    }
}

clear();

Boolean repeat3 = true;
while(repeat3){
    Console.WriteLine("Question three:");
    Console.WriteLine("Who was it that started the age of fire?");
    Console.WriteLine("A: King Vendrick");
    Console.WriteLine("B: Gwyn lord of cinders");
    Console.WriteLine("C: Demon of hatred");
    string three = Console.ReadLine();
    three = three.ToLower();
    if(three == "a" || three == "b" || three == "c" ){
        repeat3 = false;
    }
}

clear();

Boolean repeat4 = true;
while(repeat4){
    Console.WriteLine("Question four:");
    Console.WriteLine("What is the name of the blacksmith that you meet in both Dark Souls 1 and 3?");
    Console.WriteLine("A: Andre");
    Console.WriteLine("B: Patches");
    Console.WriteLine("C: Siegward");
    string four = Console.ReadLine();
    four = four.ToLower();
    if(four == "a" || four == "b" || four == "c" ){
        repeat4 = false;
    }
}

clear();

Boolean repeat5 = true;
while(repeat5){
    Console.WriteLine("Question five:");
    Console.WriteLine("What covenant does Solaire of Astora belong to?");
    Console.WriteLine("A: Blades of the Darkmoon");
    Console.WriteLine("B: Warriors of sunlight");
    Console.WriteLine("C: Spears of the church");
    string five = Console.ReadLine();
    five = five.ToLower();
    if(five == "a" || five == "b" || five == "c" ){
        repeat5 = false;
    }
}

clear();

Boolean repeat6 = true;
while(repeat6){
    Console.WriteLine("Question six:");
    Console.WriteLine("Who is a traitor to their own race?");
    Console.WriteLine("A: Darkstalker Kaath");
    Console.WriteLine("B: Annalise queen of the vilebloods");
    Console.WriteLine("C: Seath the scaleless");
    string six = Console.ReadLine();
    six = six.ToLower();
    if(six == "a" || six == "b" || six == "c" ){
        repeat6 = false;
    }
}

clear();

Boolean repeat7 = true;
while(repeat7){
    Console.WriteLine("Question seven:");
    Console.WriteLine("Where does Dark Souls 1 take place?");
    Console.WriteLine("A: Lothric");
    Console.WriteLine("B: Lordran");
    Console.WriteLine("C: Yharnam");
    string seven = Console.ReadLine();
    seven = seven.ToLower();
    if(seven == "a" || seven == "b" || seven == "c" ){
        repeat7 = false;
    }
}

clear();

if(played == 0 && points = 4){
Console.WriteLine("Congrats you got ");
Console.ReadLine();
}