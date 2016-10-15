using System;

namespace QFL
{
	public class Joueur : ObjetsTerrain
	{
		public String nom;     // NOM. Nom du joueur.
		public String prenom;  // PRENOM. Prénom du joueur.
		public int age;        // AGE. Age du joueur.
		public bool sexe;      // SEXE. Sexe du joueur. Vrai : femme. Faux : homme.
		public int forceBd;    /* FORCE. Caractéristique influant sur les actions demandant de la puissance physique. Tirs, passes, 
		                        * batte, actes violents. Bras droit. */
		public int forceBg;    // " . Bras gauche.
		public int dextBd;     /* DEXTERITE. Capacité influant sur les actions nécessitant une habileté particulière. Passes, tirs, 
		                        * acrobatie, batter, gardien, attraper vif d'or, attraper souafle. Bras droit. */
		public int dextBg;     // " . Bras gauche.
		public int init;       /* INITIATIVE. Caratéristique influant sur la rapidité à effectuer une action. Déterminer l'ordre 
		                        * dans lequel les joueurs vont agir, rattraper balle (gardien,joueurs) au vol, détourner tir. */
		public int endu;       /* ENDURANCE. Caractéristique influant sur la résistance physique du joueur. Résister aux contacts et
		                        *  aux coups. */
		public int perc;       /* PERCEPTION. Caractérisique déterminant les facultés cognitives du joueur. Voir des renseignements 
		                        * sur les joueurs adverses, voir les joueurs ayant déjà joué, sentir les différentes balles en jeu sans 
		                        * les voir, pressentir un maléfice. */
		public int magie;      /* MAGIE. Caractéristique régissant l'habileté à lancer des sorts. Portée, puissance et durée des 
		                        * sorts, discrétion du lancé, réussite du sort, nombre et type de sorts connus. */
		public int cha;        /* CHARISME. Caractéristique influant sur l'image du joueur auprès du public, de l'arbitre et des 
		                        * autres joueurs. Actions réussies augmentent le moral, arbitre plus conciliant, joueurs adverses 
		                        * impressionés, moins de perte de moral sur actions ratées, total de charisme de l'équipe peut faire
		                        * baisser les prix. */
		public int chance;     /* CHANCE. Caractéristique représentant la possibilité de voir les éléments jouer en la faveur du 
		                        * joueur. Passer inaperçu en trichant, si une action a échouée elle a une autre petite chance de 
		                        * réussir, un très petit nombre d'actions peuvent être automatiquement réussies par match. */
		public int vol;        /* VOL. Caractéristique représentant l'habileté à manier le balai. Acrobaties, distance de vol , 
		                        * angles pris en vol. */
		public int vue;        /* VUE. Caractéristique représentant la vision du joueur. Distance de vue en fonction de la taille 
		                        * des objets et des conditions climatiques.*/
		public int taille;     /* TAILLE. Caractéristique physique du joueur. Influe sur Vitesse / Force et Initiative / Endurance. */
		public int poids;      // POIDS. " . 
		public int pv;         /* POINTS DE VIE. Caractéristique représentant le nombre de blessures pouvant être supportées par le 
		                        * joueur. Déterminés par l'endurance et la chance. */
		public int pm;         /* POINTS DE MORAL. Caractéristique représentant le nombre d'actions qu'un joueur peut effectuer 
		                        * avant de prendre des risques physiques ou d'être découragé. Déterminés par la dextérité et la 
		                        * chance. */
		public int bonMalVit;  /* BONUS OU MALUS DE VITESSE. Modificateur de la caractéristique de vitesse d'un balai du au poids
		                        * et à la taille du joueur. */
		public Balai balJou;   // BALAI DU JOUEUR. Balai associé au joueur.
		
		public Joueur()
		{	 
		}
		
		/* BONUS ET MALUS. Calcul des bonus et des malus infligés par la taille et le poids du joueur aux caractéristiques
		 * de : Force, Dextérité, Initiative, Endurance et Vitesse du balai. */
		public void bonMal()
		{
			
		}
		
		/* POINTS DE VIE ET DE MORAL. Calcul du nombre de points de vie et de moral en fonction respectivement des 
		 * caractéristiques d'Endurance/Chance et de Dextérité/Chance. */
		public void pvPm()
		{
			
		}
		
		/* DEPLACEMENT. Le joueur se déplace sur le terrain. Vol : distance de déplacement. */
		public void deplacement()
		{
		}
		
		/* LANCER UN SORT PERMIS. Le joueur lance un sort dont l'utilisation n'est pas répréhensible. Magie : réussite 
		 * (malus distance etc…), durée du sort. */
		public void lanceSortPermis()
		{
		}
		
		/* VOLER AVEC LES 2 MAINS. Le joueur se déplace dans les airs. Vol : réussite, distance, angle. */
		public void vol2Mains()
		{
		}
		
		/* VOLER AVEC UNE MAIN. Le joueur se déplace dans les airs en ne tenant son balai que d'une main. Vol : réussite, 
		 * distance, angle. */
		public void vol1Main()
		{
		}
		
		/* VOLER SANS LES MAINS. Le joueur se déplace dans les airs en ayant laché son balai. Vol : réussite, distance, 
		 * angle ; Dextérité : maintien sur le balai. */
		public void vol0Mains()
		{
		}
		
		/* ESQUIVER COGNARD. Le joueur esquive un Cognard se dirigeant vers lui. Initiative : vitesse de la réaction ; 
		 * Dextérité : réaction du joueur ; Vol : stabilité sur le balai ; Perception : si le joueur n'est pas de face. */
		public void esquivCognard()
		{
		}
		
		/* ESQUIVER JOUEUR. Le joueur évite un autre joueur se dirigeant vers lui. Initiative : vitesse de la réaction ; 
		 * Dextérité : réaction du joueur ; Vol : stabilité sur le balai ; Perception : si le joueur n'est pas de face. */
		public void esquivJoueur()
		{
		}
		
		/* ENCAISSER UNE ATTAQUE. Le joueur subit une attaque en se préparant à l'encaisser. Endurance : détermine le nombre 
		 * de PV perdus et de PM ; Vol : détermine si le joueur réussit à rester sur son balai. */
		public void encaissAtk()
		{
		}
		
		/* ACROBATIE. Le joueur effectue un mouvement acrobatique. Dextérité : réussir à rester sur le balai ; Vol : réussir 
		 * l'acrobatie (180°, descente en piquée, montée en flèche etc…). */
		public void acrobat()
		{
		}
		
		/* TACLE TRANSYLVANIEN. Un joueur fait semblant de frapper un joueur adverse dans le nez afin de le déconcentrer. 
		 * Dextérité : réussite de l'action ; Chance : le joueur adverse ne prend pas le coup de poing (si échec ,
		 * test d'arbitre). */
		public void tacleTransylv()
		{
		}
		
		/* ROULADE DU PARESSEUX. Un joueur roule vers le bas sur son balai pour éviter une collision. Dextérité : réussir à 
		 * rester sur le balai ; Vol : réussir l'acrobatie. */
		public void rouladeParess()
		{
		}
		
		/* CONTRE-SORT. Un joueur contre un sort qui lui était lancé. Magie : réussite. */
		public void contreSort()
		{
		}
		
		/* BALAI SURFE. Monter debout sur le manche du balai. Dextérité / Vol : tenir sur le balai. */
		public void balaiSurf()
		{
		}
		
		/* LANCER UN SORT DE TRICHE. Le joueur lance un sort interdit en essayant de ne pas se faire voir. Magie : réussite 
		 * (malus distance etc…), durée du sort ; Chance : arbitre ; Charisme : si chance échoue. */
		public void lanceSortTriche()
		{
		}
		
		/* BOUTENCHOC. Le joueur tente de percuter un autre joueur. Force : force de l'impact ; Vol : rester sur son balai ; 
		 * Chance : l'arbitre ne voit pas l'action. */
		public void boutenchoc()
		{
		}
		
		/* COUDOYAGE. Le joueur frappe un autre joueur. Force : force de l'impact ; Dextérité : le joueur réussit son coup ; 
		 * Chance : l'arbitre ne voit pas l'action. */
		public void coudoyage()
		{
		}
		
		/* HOCHEQUEUE. Un joueur retient le balai d'un autre joueur. Force : le joueur réussità retenir le balai ; 
		 * Dextérité : le joueur réussit à attraper le balai ; Initiative : le joueur est assez rapide pour attraper le 
		 * balai ; Vol : le joueur arrive à suivre son adversaire ; Chance : l'arbitre ne voit pas l'action. */
		public void hochequeue()
		{
		}
		
		/* REMBARRAGE. Un joueur bloque les buts avec une partie de son corps pour empêcher le Souafle de passer. Chance 
		 * l'arbitre ne voit pas l'action. */
		public void rembarr()
		{
		}
		
		/* SAUTE-BALAI. Sauter sur un autre balai pour désarçonner l'adversaire. Dextérité : réussir le mouvement; Force : 
		 * faire tomber le joueur adverse; Vol : rester sur le balai adverse. */
		public void sauteBalai()
		{
		}
		
		
	}
}
