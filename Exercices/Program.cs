using Exercices;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Exercices.Utility;


//Les basiques

//1. Afficher Hello et World sur 2 lignes
void q1()
{
	Console.WriteLine("Hello");
	Console.WriteLine("World");
}

//2.Créez 2 fonctions dans votre classe,
//une pour récupérer l’entrée utilisateur
//en chaine de caractère et l’autre pour récupérer un entier.
//Utilisez ces méthodes dans les prochains exercices
//string GetStringInput(string message)
//{
//	Console.WriteLine(message);
//	return Console.ReadLine();
//}

//int GetIntInput(string message)
//{
//	string input = GetStringInput(message);
//	int res;
//	if (int.TryParse(input, out res))
//	{
//		return res;
//	}
//	else { return 0; }
//}


//3.Faites rentrer 3 mots à l’utilisateur et afficher les dans l’ordre inverse de la saisie
void q3()
{
	string mot1 = GetStringInput("Entrer le mot 1 : ");
	string mot2 = GetStringInput("Entrer le mot 2 : ");
	string mot3 = GetStringInput("Entrer le mot 3 : ");
	Console.WriteLine(mot3 + " " + mot2 + " " + mot1);
}

//4.Affichez si les 2 nombres rentrés par l’utilisateur sont égaux
void q4()
{
	int int1 = GetIntInput("Saisir un nombre :");
	int int2 = GetIntInput("Saisir un nombre :");
	if (int1 == int2)
	{ Console.WriteLine("int1 = " + int1 + " et int2 = " + int2 + " sont égaux"); }
}

//5.Créez 2 nombres, les afficher, les intervertir avec une variable temporaire et les réafficher
void q5()
{
	int i = 12;
	int j = 23;
	Console.WriteLine("i =" + i + " j = " + j);
	int temp;
	temp = i;
	i = j;
	j = temp;
	Console.WriteLine("i =" + i + " j = " + j);
}

//6.Affichez le résultat de l’ajout, la soustraction, 
//la multiplication et la division de 2 nombres rentrés par l’utilisateur
void q6()
{
	int int1 = GetIntInput("Saisir un nombre :");
	int int2 = GetIntInput("Saisir un nombre :");
	int sum = int1 + int2;
	int mult = int1 * int2;
	double div;
	Console.WriteLine("int1 + int2 = " + sum);
	Console.WriteLine("int1 * int2 = " + mult);
	if (int2 == 0) Console.WriteLine("division impossible");
	else
	{
		Console.WriteLine("int1 / int2 = " + (double)int1 / int2);
	}
}

//7.Affichez la moyenne de 4 nombres rentrés par l’utilisateur
void q7()
{
	int int1 = GetIntInput("Saisir un nombre :");
	int int2 = GetIntInput("Saisir un nombre :");
	int int3 = GetIntInput("Saisir un nombre :");
	int int4 = GetIntInput("Saisir un nombre :");
	double moy = (double)(int1 + int2 + int3 + int4) / 4;
	Console.WriteLine("moyenne = " + moy);
}

//8.Affichez le nombre le plus grand de 4 nombres rentrés par l’utilisateur
void q8()
{
	int int1 = GetIntInput("Saisir un nombre :");
	int int2 = GetIntInput("Saisir un nombre :");
	int int3 = GetIntInput("Saisir un nombre :");
	int int4 = GetIntInput("Saisir un nombre :");

	int GetMax2(int i, int j)
	{
		int max = i;
		if (i < j) max = j;
		return max;
	}
	int GetMax4(int i, int j, int k, int l)
	{
		int maxA = GetMax2(i, j);
		int maxB = GetMax2(k, l);
		return GetMax2(maxA, maxB);
	}
	Console.WriteLine(GetMax4(int1, int2, int3, int4));
}

//9.Savoir si le nombre rentré est négatif ou positif
void q9()
{
	int int1 = GetIntInput("Saisir un nombre :");
	void IsPositive(int i)
	{
		if (i < 0)
		{
			Console.WriteLine(i + " est négatif");
		}
		else
		{
			if (i > 0)
			{
				Console.WriteLine(i + " est positif");
			}
			else Console.WriteLine(i + " est égal à zéro");
		}
	}
	IsPositive(int1);
}

//10.Savoir si le nombre donné est pair ou impair
void q10()
{
	int int1 = GetIntInput("Saisir un nombre :");
	bool isPair(int i)
	{
		bool res;
		res = i % 2 == 0 ? true : false;
		return res;
	}
	Console.WriteLine("est-ce que le nombre est pair ? " + isPair(int1));
}

//11.Rentrez un nombre en Celsius et le convertir en Kelvin (celsius + 273.15)
//et Fahrenheit (celsius * 18 / 10 + 32)
void q11()
{
	double celsius = GetIntInput("Saisir un nombre en Celsius :");
	double kelvin, fahr;
	kelvin = celsius + 273.15;
	fahr = celsius * (double)18 / 10 + 32;
	Console.WriteLine("temp en Kelvin = " + kelvin);
	Console.WriteLine("temp en Fahrenheit = " + fahr);
}
//q11();

//12. Rentrez un chiffre et dire de quel
//jour il s’agit sous forme de texte avec un switch (1 => lundi, etc.)
void q12()
{
	int numJour = GetIntInput("Saisir un chiffre du jour : ");
	string jourSemaine = null;
	switch (numJour)
	{
		case 1: jourSemaine = "lundi"; break;
		case 2: jourSemaine = "mardi"; break;
		case 3: jourSemaine = "mercredi"; break;
		case 4: jourSemaine = "jeudi"; break;
		case 5: jourSemaine = "vendredi"; break;
		case 6: jourSemaine = "samedi"; break;
		case 7: jourSemaine = "dimanche"; break;
	}
	Console.WriteLine("Le jour de la semaine est :" + jourSemaine);
}
//q12();

//13.Rentrez un jour et dire de quel chiffre il s’agit (Lundi => 1, etc.)
void q13()
{
	string jourSemaine = GetStringInput("Saisir un jour de la semaine : ");
	int numJour = 0;
	switch (jourSemaine)
	{
		case "lundi": numJour = 1; break;
		case "mardi": numJour = 2; break;
		case "mercredi": numJour = 3; break;
		case "jeudi": numJour = 4; break;
		case "vendredi": numJour = 5; break;
		case "samedi": numJour = 6; break;
		case "dimanche": numJour = 7; break;
	}
	Console.WriteLine("Le chiffre de la semaine est : " + numJour);
}
//q13();

//14.Rentrez un nombre, puis un signe (+ - * /), puis un autre nombre,
//affichez ensuite le résultat de l’opération (avec un switch)
void q14()
{
	int nb1 = GetIntInput("Saisir un nombre : ");
	string signe = GetStringInput("Saisir un signe + - * / : ");
	int nb2 = GetIntInput("Saisir un nombre : ");

	switch (signe)
	{
		case "+": Console.WriteLine(nb1 + nb2); break;
		case "*": Console.WriteLine(nb1 * nb2); break;
		case "-": Console.WriteLine(nb1 - nb2); break;
		case "/": if (nb2 != 0) Console.WriteLine((double)nb1 / nb2); else Console.WriteLine("erreur"); break;
		default: Console.WriteLine("erreur"); break;
	}
}

//15. Afficher les 10 premiers chiffres à partir de 0 (avec une boucle for)
void q15()
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine(i);
	}
}

//16. Donnez la table de multiplication des 10 premiers chiffres
void q16()
{
	for (int i = 0; i < 11; i++)
	{
		Console.WriteLine(" ");
		for (int j = 0; j < 11; j++)
		{
			Console.Write(i + "*" + j + "=" + i * j + " ");
		}
	}
}
//q16();

//17. Rentrez une lettre et une taille et l’afficher sous forme de triangle
//(bien nommer ses variables et faire du debug si ce n’est pas le bon résultat attendu)
void q17()
{
	int taille = GetIntInput("Taille ? : ");
	string lettre = GetStringInput("Lettre ? : ");
	int tailleColonne = taille;
	for (int ligne = 0; ligne < taille; ligne++)
	{
		Console.WriteLine(" ");
		for (int colonne = tailleColonne; colonne > 0; colonne--)
		{
			Console.Write(lettre);
		}
		tailleColonne--;
	}
}
//q17();

//18. Faire une pyramide d’une hauteur donnée - optionnel
void q18()
{
	int hauteur = GetIntInput("Taille ? : ");
	string lettre = GetStringInput("Lettre ? : ");
	int nbColonneTotal = (hauteur * 2) - 1;
	for (int ligne = 0; ligne < hauteur; ligne++)
	{
		Console.WriteLine(" ");

		for (int colonne = 0; colonne <= nbColonneTotal; colonne++)
		{
			Console.Write(" ");
			if (colonne == nbColonneTotal)
				for (int incrLettre = 0; incrLettre < ligne + 1; incrLettre++)
				{
					Console.Write(lettre + " ");
				}
		}
		nbColonneTotal--;
	}
}
//q18();

//19.Faire un losange(1 pyramide vers le haut et 1 vers le bas)
//d’une hauteur donnée - optionnel
void q19()
{
	int hauteur = GetIntInput("Taille ? : ");
	string lettre = GetStringInput("Lettre ? : ");
	int nbColonneTotal1 = (hauteur * 2) - 1;
	for (int ligne = 0; ligne < hauteur; ligne++)
	{
		Console.WriteLine(" ");

		for (int colonne = 0; colonne <= nbColonneTotal1; colonne++)
		{
			Console.Write(" ");
			if (colonne == nbColonneTotal1)
				for (int incrLettre = 0; incrLettre < ligne + 1; incrLettre++)
				{
					Console.Write(lettre + " ");
				}
		}
		nbColonneTotal1--;
	}

	int nbColonneTotal2 = (hauteur * 2) - 1;
	for (int ligne = hauteur + 1; ligne < nbColonneTotal2; ligne++)
	{
		Console.WriteLine(" ");

		for (int colonne = hauteur + 1; colonne <= nbColonneTotal2 + 1; colonne++)
		{
			Console.Write("0");
			if (colonne == nbColonneTotal2)
				for (int incrLettre = 0; incrLettre < ligne + 1; incrLettre++)
				{
					Console.Write(lettre + "1");
				}
		}
		nbColonneTotal2--;
	}


}
//q19();

//20.Créez la date d’aujourd’hui et affichez-la de façon complète puis de façon jour/mois/année
void q20()
{
	int jour = 12;
	int mois = 03;
	int annee = 2014;
	DateTime date = new DateTime(annee, mois, jour);
	Console.WriteLine(date);
}
//q20();

void q20b()
{
	DateTime date = DateTime.Now;
	Console.WriteLine(date.ToShortDateString());
}
//q20b();

//21.Créer une date avec l’utilisateur qui rentre
//l’année, mois, jour, heure, minute et seconde et afficher
//le jour (Lundi, mardi…) | en français ou en anglais
void q21()
{
	int annee = GetIntInput("Année ? : ");
	int mois = GetIntInput("Mois ? : ");
	int jour = GetIntInput("Jour ? : ");
	int heure = GetIntInput("Heure ? : ");
	int minute = GetIntInput("Minute ? : ");
	int seconde = GetIntInput("Seconde ? : ");
	string langue = GetStringInput("FR ou EN ? : ");
	langue = langue.ToUpper();
	DateTime date = new DateTime(annee, mois, jour, heure, minute, seconde);
	if (langue.Equals("FR"))
	{
		switch (date.DayOfWeek)
		{
			case DayOfWeek.Sunday:
				Console.WriteLine("Dimanche"); break;
				break;
			case DayOfWeek.Monday:
				Console.WriteLine("Lundi"); break;
				break;
			case DayOfWeek.Tuesday:
				Console.WriteLine("Mardi"); break;
				break;
			case DayOfWeek.Wednesday:
				Console.WriteLine("Mercredi"); break;
				break;
			case DayOfWeek.Thursday:
				Console.WriteLine("Jeudi"); break;
				break;
			case DayOfWeek.Friday:
				Console.WriteLine("Vendredi"); break;
				break;
			case DayOfWeek.Saturday:
				Console.WriteLine("Samedi"); break;
				break;
			default:
				break;
		}
	}
	else Console.WriteLine(date.DayOfWeek);
}
//q21();

//22.Affichez la différence de temps entre 2 dates avec une soustraction
void q22()
{
	DateTime today = DateTime.Now;
	DateTime finDuMonde = new DateTime(2027, 12, 21);
	TimeSpan delai = finDuMonde - today;
	Console.WriteLine(delai.TotalDays);
}
//q22();

//23.Convertir une chaine de caractère en date
void q23()
{
	string date = "12/03/2024";
	if (DateTime.TryParse(date, out DateTime result)) Console.WriteLine(date);
}
//q23();

//24. Jeu du plus ou moins (un nombre est définit par défaut,
//puis l’utilisateur rentre un chiffre et le programme lui dit si
//le bon nombre est + ou – que celui définit jusqu’à que l’utilisateur trouve)
void q24()
{
	var rand = new Random();
	int randNum = rand.Next(1, 10);
	int input = GetIntInput("Chiffre ? : ");
	bool trouve = false;
	while (trouve != true)
	{
		if (input < randNum) input = GetIntInput("+ grand : ");
		else
		{
			if (input > randNum)
			{
				input = GetIntInput("+ petit : ");
			}
			else
			{
				Console.WriteLine("trouvé!!");
				trouve = true;
			}
		}
	}

}
//q24();

//25.Affichez une chaine donnée en majuscule
void q25()
{
	string chaine = GetStringInput("Chaîne de caractères ? : ");
	Console.WriteLine(chaine.ToUpper());
}
//q25();

//26.Créez une chaine de caractère « hello »,
//remplacez les « l » par des « 1 »
//via la méthode Replace et affichez le résultat

void q26()
{
	string chaine = "hello";
	Console.WriteLine(chaine.Replace('l', '1'));
}
//q26();

//27. Savoir si la chaine de caractère rentrée par
//l’utilisateur contient la lettre « x » via la méthode Contains
void q27()
{
	string chaine = GetStringInput("Chaîne de caractères ? : ");
	Console.WriteLine(chaine.Contains('x'));
}
//q27();

//28. Dire si une chaine est égale à une autre sans prendre en compte la casse
void q28()
{
	string chaine1 = "On ne sait Rien";
	string chaine2 = "On ne Sait RIEN";
	Console.WriteLine(string.Equals(chaine1, chaine2, StringComparison.CurrentCultureIgnoreCase));
}
//q28();

//29. Savoir si la chaine donnée est un palindrome (mot qui se lit dans les deux sens : SOS)
//sans méthode reverse, juste avec un for
void q29()
{
	string chaine = "SOS";
	string reverse = "";
	for (int i = chaine.Length - 1; i > -1; i--)
	{
		reverse = reverse + chaine[i].ToString();
	}
	Console.WriteLine(reverse);
	if (chaine == reverse) { Console.WriteLine("c'est un palindrome!!!!"); }
}
//q29();

//30. Lister les nombres de 1 à 100, en remplaçant le nombre par un mot selon certaines conditions
//a.Le mot Fizz s'il est multiple de 3

void q30()
{
	for (int i = 1; i < 101; i++)
	{
		if (i % 3 == 0)
		{
			Console.Write("Fizz ");
		}
		else Console.Write(i + " ");
	}
}
//q30();

//b. Le mot Buzz s'il est multiple de 5
void q30b()
{
	for (int i = 1; i < 101; i++)
	{
		if (i % 5 == 0)
		{
			Console.Write("Buzz ");
		}
		else Console.Write(i + " ");
	}
}
//q30b();

//Le mot FizzBuzz s'il est multiple de 3 et de 5
void q30c()
{
	for (int i = 1; i < 101; i++)
	{
		if ((i % 5 == 0) && (i % 3 == 0))
		{
			Console.Write("FizzBuzz ");
		}
		else Console.Write(i + " ");
	}
}
//q30c();

//d.Un retour à la ligne tous les 9 éléments
void q30d()
{
	for (int i = 1; i < 101; i++)
	{
		if (i % 10 == 9)
		{
			Console.WriteLine(" ");
		}
		else Console.Write(i + " ");
	}
}

//q30d();

//Exo31: Créez une classe Personne qui comporte trois propriétés, nom, prénom et date de naissance
//Exo32: Ecrivez une méthode « MajPrenom » dans la classe Personne qui écrase l’ancien
//prénom par le prénom en majuscule
//33.Dans votre programme créez une personne avec des valeurs rentrées par l’utilisateur, appelez 
//la méthode créée précédemment et afficher la personne en console

string nom = GetStringInput("Nom ? ");
string prenom = GetStringInput("Prenom ? ");
string ddnString = GetStringInput("Date de naissance ? ");
DateOnly ddn = DateOnly.Parse(ddnString);

Personne personne = new Personne() { Nom = nom, Prenom=prenom, Ddn=ddn};
personne.MajPrenom();
Console.WriteLine($"Nom : {personne.Nom}, prénom : {personne.Prenom}, ddn : {personne.Ddn}");

//34. Créez 1 Personne, l’affecter à une autre variable Personne, les afficher, appeler la méthode
//MajPrenom sur la première personne et les réafficher. Que se passe-t-il au niveau des prénoms ?
Personne personne2 = new Personne()
{
	Nom = "Durand",
	Prenom = "Jack",
	Ddn = DateOnly.Parse("12/08/1987")
};
personne = personne2;
Console.WriteLine($"Nom : {personne.Nom}, prénom : {personne.Prenom}, ddn : {personne.Ddn}");
Console.WriteLine($"Nom2 : {personne2.Nom}, prénom2 : {personne2.Prenom}, ddn2 : {personne2.Ddn}");

//35. Créez une propriété statique Test dans la classe Personne avec une valeur
//par défaut et l’afficher
Console.WriteLine(Personne.Test);

//36.Mettre les 2 méthodes créées au début dans l’exercice 2 (GetStringFromConsole et GetIntFromConsole)
//dans une classe statique et adapter le code existant