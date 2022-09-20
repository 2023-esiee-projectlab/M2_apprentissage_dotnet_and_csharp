﻿//-Importation des classes système
using System;

//-Importation des classes du projet


//-Projet
class LesBases{

    static void Main(string[] args){

        Console.WriteLine("---[Start]---");  

        //-Création d'articles
        Article article1 = new Article("MacBook Pro 13 2022", 999.99, 10);
        Article article2 = new Article("MacBook Pro 14 2022", 1999.99, 10);
        Article article3 = new Article("MacBook Pro 16 2022", 2999.99, 10);
        
        //-Ajouts
        article1.ajouter(10);
        
        //-Retirer
        article1.retirer(5);
        
        //-Affichage
        article1.afficher();
        article2.afficher();
        article3.afficher();

        Console.WriteLine("---[Stop]---");
    }

}