using System.Net.WebSockets;
using System;
int points = 0;
string haveplayed;
string questionYN(string question){

    while(true){
        Console.WriteLine(question);
        Console.WriteLine("Yes or No");
        string playedornot = Console.ReadLine();
        playedornot = playedornot.ToLower();
        if(playedornot == "no" || playedornot == "n"){
            return "no";
        }
        else if(playedornot == "yes" || playedornot == "y"){
            return "yes";
        }
    }
}

string questionABC(string questionName, string questionabc, string answerA, string answerB, string answerC){
    Console.Clear();
    while(true){
        Console.WriteLine(questionName);
        Console.WriteLine(questionabc);
        Console.WriteLine(answerA);
        Console.WriteLine(answerB);
        Console.WriteLine(answerC);
        string answer = Console.ReadLine();
        answer = answer.ToLower();
        if(answer == "a" || answer == "b" || answer == "c"){
            return answer;
        }
    }
}

haveplayed = questionYN("Have you finished more than one of the Dark Souls games?");



string answer;
answer = questionABC("Question one:", "What is the name of the director who made Dark Souls?", 
"A: Hidetaka Miyazaki", "B: Hideo Kojima", "C: Masahiro Sakurai"); 
if(answer == "a"){
    points ++;
}



answer = questionABC("Question two:", "What is your player character called in Dark Souls 3?", 
"A: Chosen undead", "B: Bearer of the curse", "C: Ashen one");
if(answer == "c"){
    points ++;    
}


answer = questionABC("Question three:", "Who was it that started the age of fire?", 
"A: King Vendrick", "B: Gwyn lord of cinders", "C: Demon of hatred");
if(answer == "b"){
    points ++;    
}

answer = questionABC("Question four:", "What is the name of the blacksmith that you meet in both Dark Souls 1 and 3?",
"A: Andre", "B: Patches", "C: Siegward");
if(answer == "a"){
    points ++;    
}

answer = questionABC("Question five:", "What covenant does Solaire of Astora belong to?",
"A: Blades of the Darkmoon", "B: Warriors of sunlight", "C: Spears of the church");
if(answer == "b"){
    points ++;    
}

answer = questionABC("Question six:", "Who is a traitor to their own race?",
"A: Darkstalker Kaath", "B: Annalise queen of the vilebloods", "C: Seath the scaleless");
if(answer == "c"){
    points ++;    
    }

answer = questionABC("Question seven:", "Where does Dark Souls 1 take place?",
"A: Lothric", "B: Lordran", "C: Yharnam");
if(answer == "b"){
    points ++;    
}
Console.Clear();

if(points > 1){
    Console.WriteLine($"You got {points} points out of 7\n");
}
else if(points == 1){
    Console.WriteLine($"You got {points} point out of 7\n");
}

if(haveplayed == "yes" && points <= 2){
    Console.WriteLine("How disappoiting");
}
if(haveplayed == "yes" && points > 2 && points <= 5){
    Console.WriteLine("Not great, not terrible");
}
if(haveplayed == "yes" && points > 5){
    Console.WriteLine("Very good, the ratio is prosperous, very good");
}
if(haveplayed == "no" && points <= 2){
    Console.WriteLine("Good kind of");
}
if(haveplayed == "no" && points > 2 && points <= 5){
    Console.WriteLine("Good of good");
}
if(haveplayed == "no" && points > 5){
    Console.WriteLine("Very good, give me suprised and pleased");
}

//the broken english is from Star War the Third Gathers - Backstroke of the West 



Console.ReadLine();
