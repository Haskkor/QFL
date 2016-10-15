using System;

namespace QFL
{
	public class Joueur : ObjetsTerrain
	{
		public String nom;     // NOM. Nom du joueur.
		public String prenom;  // PRENOM. Pr�nom du joueur.
		public int age;        // AGE. Age du joueur.
		public bool sexe;      // SEXE. Sexe du joueur. Vrai : femme. Faux : homme.
		public int forceBd;    /* FORCE. Caract�ristique influant sur les actions demandant de la puissance physique. Tirs, passes, 
		                        * batte, actes violents. Bras droit. */
		public int forceBg;    // " . Bras gauche.
		public int dextBd;     /* DEXTERITE. Capacit� influant sur les actions n�cessitant une habilet� particuli�re. Passes, tirs, 
		                        * acrobatie, batter, gardien, attraper vif d'or, attraper souafle. Bras droit. */
		public int dextBg;     // " . Bras gauche.
		public int init;       /* INITIATIVE. Carat�ristique influant sur la rapidit� � effectuer une action. D�terminer l'ordre 
		                        * dans lequel les joueurs vont agir, rattraper balle (gardien,joueurs) au vol, d�tourner tir. */
		public int endu;       /* ENDURANCE. Caract�ristique influant sur la r�sistance physique du joueur. R�sister aux contacts et
		                        *  aux coups. */
		public int perc;       /* PERCEPTION. Caract�risique d�terminant les facult�s cognitives du joueur. Voir des renseignements 
		                        * sur les joueurs adverses, voir les joueurs ayant d�j� jou�, sentir les diff�rentes balles en jeu sans 
		                        * les voir, pressentir un mal�fice. */
		public int magie;      /* MAGIE. Caract�ristique r�gissant l'habilet� � lancer des sorts. Port�e, puissance et dur�e des 
		                        * sorts, discr�tion du lanc�, r�ussite du sort, nombre et type de sorts connus. */
		public int cha;        /* CHARISME. Caract�ristique influant sur l'image du joueur aupr�s du public, de l'arbitre et des 
		                        * autres joueurs. Actions r�ussies augmentent le moral, arbitre plus conciliant, joueurs adverses 
		                        * impression�s, moins de perte de moral sur actions rat�es, total de charisme de l'�quipe peut faire
		                        * baisser les prix. */
		public int chance;     /* CHANCE. Caract�ristique repr�sentant la possibilit� de voir les �l�ments jouer en la faveur du 
		                        * joueur. Passer inaper�u en trichant, si une action a �chou�e elle a une autre petite chance de 
		                        * r�ussir, un tr�s petit nombre d'actions peuvent �tre automatiquement r�ussies par match. */
		public int vol;        /* VOL. Caract�ristique repr�sentant l'habilet� � manier le balai. Acrobaties, distance de vol , 
		                        * angles pris en vol. */
		public int vue;        /* VUE. Caract�ristique repr�sentant la vision du joueur. Distance de vue en fonction de la taille 
		                        * des objets et des conditions climatiques.*/
		public int taille;     /* TAILLE. Caract�ristique physique du joueur. Influe sur Vitesse / Force et Initiative / Endurance. */
		public int poids;      // POIDS. " . 
		public int pv;         /* POINTS DE VIE. Caract�ristique repr�sentant le nombre de blessures pouvant �tre support�es par le 
		                        * joueur. D�termin�s par l'endurance et la chance. */
		public int pm;         /* POINTS DE MORAL. Caract�ristique repr�sentant le nombre d'actions qu'un joueur peut effectuer 
		                        * avant de prendre des risques physiques ou d'�tre d�courag�. D�termin�s par la dext�rit� et la 
		                        * chance. */
		public int bonMalVit;  /* BONUS OU MALUS DE VITESSE. Modificateur de la caract�ristique de vitesse d'un balai du au poids
		                        * et � la taille du joueur. */
		public Balai balJou;   // BALAI DU JOUEUR. Balai associ� au joueur.
		
		public Joueur()
		{	 
		}
		
		/* BONUS ET MALUS. Calcul des bonus et des malus inflig�s par la taille et le poids du joueur aux caract�ristiques
		 * de : Force, Dext�rit�, Initiative, Endurance et Vitesse du balai. */
		public void bonMal()
		{
			
		}
		
		/* POINTS DE VIE ET DE MORAL. Calcul du nombre de points de vie et de moral en fonction respectivement des 
		 * caract�ristiques d'Endurance/Chance et de Dext�rit�/Chance. */
		public void pvPm()
		{
			
		}
		
		/* DEPLACEMENT. Le joueur se d�place sur le terrain. Vol : distance de d�placement. */
		public void deplacement()
		{
		}
		
		/* LANCER UN SORT PERMIS. Le joueur lance un sort dont l'utilisation n'est pas r�pr�hensible. Magie : r�ussite 
		 * (malus distance etc�), dur�e du sort. */
		public void lanceSortPermis()
		{
		}
		
		/* VOLER AVEC LES 2 MAINS. Le joueur se d�place dans les airs. Vol : r�ussite, distance, angle. */
		public void vol2Mains()
		{
		}
		
		/* VOLER AVEC UNE MAIN. Le joueur se d�place dans les airs en ne tenant son balai que d'une main. Vol : r�ussite, 
		 * distance, angle. */
		public void vol1Main()
		{
		}
		
		/* VOLER SANS LES MAINS. Le joueur se d�place dans les airs en ayant lach� son balai. Vol : r�ussite, distance, 
		 * angle ; Dext�rit� : maintien sur le balai. */
		public void vol0Mains()
		{
		}
		
		/* ESQUIVER COGNARD. Le joueur esquive un Cognard se dirigeant vers lui. Initiative : vitesse de la r�action ; 
		 * Dext�rit� : r�action du joueur ; Vol : stabilit� sur le balai ; Perception : si le joueur n'est pas de face. */
		public void esquivCognard()
		{
		}
		
		/* ESQUIVER JOUEUR. Le joueur �vite un autre joueur se dirigeant vers lui. Initiative : vitesse de la r�action ; 
		 * Dext�rit� : r�action du joueur ; Vol : stabilit� sur le balai ; Perception : si le joueur n'est pas de face. */
		public void esquivJoueur()
		{
		}
		
		/* ENCAISSER UNE ATTAQUE. Le joueur subit une attaque en se pr�parant � l'encaisser. Endurance : d�termine le nombre 
		 * de PV perdus et de PM ; Vol : d�termine si le joueur r�ussit � rester sur son balai. */
		public void encaissAtk()
		{
		}
		
		/* ACROBATIE. Le joueur effectue un mouvement acrobatique. Dext�rit� : r�ussir � rester sur le balai ; Vol : r�ussir 
		 * l'acrobatie (180�, descente en piqu�e, mont�e en fl�che etc�). */
		public void acrobat()
		{
		}
		
		/* TACLE TRANSYLVANIEN. Un joueur fait semblant de frapper un joueur adverse dans le nez afin de le d�concentrer. 
		 * Dext�rit� : r�ussite de l'action ; Chance : le joueur adverse ne prend pas le coup de poing (si �chec ,
		 * test d'arbitre). */
		public void tacleTransylv()
		{
		}
		
		/* ROULADE DU PARESSEUX. Un joueur roule vers le bas sur son balai pour �viter une collision. Dext�rit� : r�ussir � 
		 * rester sur le balai ; Vol : r�ussir l'acrobatie. */
		public void rouladeParess()
		{
		}
		
		/* CONTRE-SORT. Un joueur contre un sort qui lui �tait lanc�. Magie : r�ussite. */
		public void contreSort()
		{
		}
		
		/* BALAI SURFE. Monter debout sur le manche du balai. Dext�rit� / Vol : tenir sur le balai. */
		public void balaiSurf()
		{
		}
		
		/* LANCER UN SORT DE TRICHE. Le joueur lance un sort interdit en essayant de ne pas se faire voir. Magie : r�ussite 
		 * (malus distance etc�), dur�e du sort ; Chance : arbitre ; Charisme : si chance �choue. */
		public void lanceSortTriche()
		{
		}
		
		/* BOUTENCHOC. Le joueur tente de percuter un autre joueur. Force : force de l'impact ; Vol : rester sur son balai ; 
		 * Chance : l'arbitre ne voit pas l'action. */
		public void boutenchoc()
		{
		}
		
		/* COUDOYAGE. Le joueur frappe un autre joueur. Force : force de l'impact ; Dext�rit� : le joueur r�ussit son coup ; 
		 * Chance : l'arbitre ne voit pas l'action. */
		public void coudoyage()
		{
		}
		
		/* HOCHEQUEUE. Un joueur retient le balai d'un autre joueur. Force : le joueur r�ussit� retenir le balai ; 
		 * Dext�rit� : le joueur r�ussit � attraper le balai ; Initiative : le joueur est assez rapide pour attraper le 
		 * balai ; Vol : le joueur arrive � suivre son adversaire ; Chance : l'arbitre ne voit pas l'action. */
		public void hochequeue()
		{
		}
		
		/* REMBARRAGE. Un joueur bloque les buts avec une partie de son corps pour emp�cher le Souafle de passer. Chance 
		 * l'arbitre ne voit pas l'action. */
		public void rembarr()
		{
		}
		
		/* SAUTE-BALAI. Sauter sur un autre balai pour d�sar�onner l'adversaire. Dext�rit� : r�ussir le mouvement; Force : 
		 * faire tomber le joueur adverse; Vol : rester sur le balai adverse. */
		public void sauteBalai()
		{
		}
		
		
	}
}
