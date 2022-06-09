// K-On! Quiz by Jordan. A
#nullable disable
Console.Clear();

// WELCOME
Console.WriteLine("WELCOME TO THE K-ON! QUIZ");
double score = 0;
// QUIZ INPUT
Console.WriteLine("\n1. What is the bands name?");
Console.Write("Q1 Answer: ");
string firstQuestion = Console.ReadLine().ToLower();
if (firstQuestion == "ho-kago tea time" || firstQuestion == "hokago tea time" || firstQuestion == "after school tea time") {
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

Console.WriteLine("\n2. Which member plays the bass?");
Console.Write("Q1 Answer: ");
string secondQuestion = Console.ReadLine().ToLower();
if (secondQuestion == "mio" | secondQuestion == "mio akiyama" || secondQuestion == "akiyama") {
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

Console.WriteLine("\n3. Who is the youngest member?");
Console.Write("Q1 Answer: ");
string thirdQuestion = Console.ReadLine().ToLower();
if (thirdQuestion == "azusa" || thirdQuestion == "azusa nakano") {
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

Console.WriteLine("\n4. Who is the president of the club?");
Console.Write("Q1 Answer: ");
string fourthQuestion = Console.ReadLine().ToLower();
if (fourthQuestion == "ritsu" || fourthQuestion == "ritsu tainaka") {
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

// OUTPUT RESULTS
Console.WriteLine("\nYOUR RESULTS:");
double grade = (score / 4) * 100;
Console.WriteLine($"{score} / 4 ({grade}%)");
if (score > 2) {
    Console.WriteLine("Good Job!");
} else {
    Console.WriteLine("You need to study!");
}