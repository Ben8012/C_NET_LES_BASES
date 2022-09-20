/*
* IF ... ELSE ...
*/

//Console.WriteLine("Entrez votre age : ");

//if ( double.TryParse(Console.ReadLine(), out double age) )
//{
//    if ( age >= 18 )
//    {
//        Console.WriteLine("Vous êtes majeur.");
//    }
//    else
//    {
//        Console.WriteLine("Vous êtes mineur.");
//    }
//}
//else
//{
//    Console.WriteLine("Valeur incorrecte.");
//}


/*
* IF ... ELSE IF ... ELSE ...
*/

//Console.WriteLine("Entrez votre taille : ");

//if (int.TryParse(Console.ReadLine(), out int taille))
//{
//    if (taille >= 190)
//    {
//        Console.WriteLine("Vous êtes de grandes tailles.");
//    }
//    else if (taille >= 170)
//    {
//        Console.WriteLine("Vous êtes de tailles moyennes.");
//    }
//    else if (taille >= 150)
//    {
//        Console.WriteLine("Vous êtes de petites tailles.");
//    }
//    else
//    {
//        Console.WriteLine("Taille non repertoriée.");
//    }
//}


/*
* SWITCH
*/

// <!> BREAK obligatoire pour chaque case et default

//Console.WriteLine("Entrez le numéro d'une saison : (0 : printemps => 3 : hiver)");
//int saison = int.Parse(Console.ReadLine());

//switch ( saison )
//{
//    case 0:
//        Console.WriteLine("C'est le printemps !");
//        break;
//    case 1:
//        Console.WriteLine("C'est l'été !");
//        break;
//    case 2:
//        Console.WriteLine("C'est l'automne !");
//        break;
//    case 3:
//        Console.WriteLine("C'est l'hiver !");
//        break;
//    default:
//        Console.WriteLine("Aucune saison associée");
//        break;
//}

Console.WriteLine("Entrez le nom d'un fruit : ");
string fruit = Console.ReadLine();

switch ( fruit )
{
    case "cerise":
        Console.WriteLine("Le prix est de 14€");
        break;
    case "pomme":
        Console.WriteLine("Le prix est de 6€");
        break;
    case "mangue":
    case "papaye":
        Console.WriteLine("Le prix est de 23€");
        break;
    default:
        Console.WriteLine("Fruit non reconnu.");
        break;

}
