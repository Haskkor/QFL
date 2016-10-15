using System;

namespace QFL
{
	public class Poursuiveur : Joueur
	{
		public Poursuiveur(String lastname, String firstname, int ageJoueur, bool sex, int strBd, int strBg, int dexBd, 
		                 int dexBg, int ini, int stamina, int percep, int magic, int charisma, int luck, int flight, 
		                 int sight, int height, int weight)
		{
			this.nom = lastname;
			this.prenom = firstname;
			this.age = ageJoueur;
			this.sexe = sex;
		
			this.forceBd = strBd;
			this.forceBg = strBg;
		
			this.dextBd = dexBd; 
			this.dextBg = dexBg;
		
			this.init = ini;
		
			this.endu = stamina;
		
			this.perc = percep;
			this.magie = magic;
			this.cha = charisma;
			this.chance = luck;
			this.vol = flight;
			this.vue = sight;
		
			this.taille = height;
			this.poids = weight;
		
			this.pv = weight;
			this.pm = weight;
		}
		
		/* PASSE MAIN GAUCHE. Un joueur lance le Souafle en direction d'un autre joueur. Force : distance ; Dextérité : 
		 * précision. */
		public void passeMG()
		{
		}
		
		/* PASSE MAIN DROITE. Un joueur lance le Souafle en direction d'un autre joueur. Force : distance ; Dextérité : 
		 * précision. */
		public void passeMD()
		{
		}
		
		/* TIR MAIN GAUCHE. Un joueur lance le Souafle en dirction des cercles de buts. Force : distance ; Dextérité : 
		 * précision. */
		public void tirMG()
		{
		}
		
		/* TIR MAIN DROITE. Un joueur lance le Souafle en dirction des cercles de buts. Force : distance ; Dextérité : 
		 * précision. */
		public void tirMD()
		{
		}
		
		/* RATRAPPER MAIN GAUCHE. Un joueur rattrape le Souafle lancé par un autre joueur. Initiative : réaction ; 
		 * Dextérité : rattraper ; Perception : si le joueur n'est pas de face. */
		public void ratrapperMG()
		{
		}
		
		/* RATRAPPER MAIN DROITE. Un joueur rattrape le Souafle lancé par un autre joueur. Initiative : réaction ; 
		 * Dextérité : rattraper ; Perception : si le joueur n'est pas de face. */
		public void ratrapperMD()
		{
		}
		
		/* FRAPPE-SOUAFLE. Un joueur tape dans le Souafle qu'un autre joueur tient afin de lui subtiliser. Force : force du 
		 * renvoi ; Dextérité : précision du renvoi, réussir à frapper dans le Souafle. */
		public void frapSouafle()
		{
		}
		
		/* TIR LONG MAIN GAUCHE. Dégager le Souafle à grande distance. Force : distance ; Dextérité : précision. */
		public void tirLongMG()
		{
		}
		
		/* TIR LONG MAIN DROITE. Dégager le Souafle à grande distance. Force : distance ; Dextérité : précision. */
		public void tirLongMD()
		{
		}
		
		/* TREMBLANTE DE WOOLONGONG. Se déplacer en zig-zag. Dextérité : réussir à rester sur le balai ; Vol : réussir 
		 * l'acrobatie. */
		public void tremblanteWoo()
		{
		}
		
		/* ATTAQUE EN FAUCON. Trois poursuiveurs côte à côte , celui du centre légèrement en avant. Vol : pour les trois 
		 * poursuiveurs (offre des bonus de dextérité , de distance et de charisme). */
		public void attFaucon()
		{
		}
		
		/* FEINTE DE PORSKOFF. Le joueur monte en chandelle pour que les adversaires le suivent puis lache le Souafle à un 
		 * partenaire en dessous. Dextérité : réussir à rester sur le balai ; Vol : réussir l'acrobatie ; Force : distance ; 
		 * Dextérité : précision. */
		public void feintePors()
		{
		}
		
		/* FEINTE DEFENSIVE DE WRONSKI. Le joueur plonge vers le sol pour forcer un autre joueur à le suivre et remonte au 
		 * dernier moment. Dextérité : réussir à rester sur le balai ; Vol : réussir l'acrobatie. */
		public void feinteWrons()
		{
		}
		
		/* PASSE ARRIERE MAIN GAUCHE. Le joueur passe le Souafle vers l'arrière. Force : distance ; Dextérité : précision. */
		public void passArrMG()
		{
		}
		
		/* PASSE ARRIERE MAIN DROITE. Le joueur passe le Souafle vers l'arrière. Force : distance ; Dextérité : précision. */
		public void passArrMD()
		{
		}
		
		/* PENALTY. Le joueur tire un penalty. Force : distance ; Dextérité : précision. */
		public void penalty()
		{
		}
		
		/* FOURBERIE DE FINBOURGH. Frapper le souaffle avec la queue du balai. Dextérité : toucher le souafle, direction 
		 * du souafle; Vol : réussi le mouvement; */
		public void fourbFinb()
		{
		}
		
		/* CHARGE DE CHELMONDISTO. Salto avant pour tirer en extension et retomber sur le balai. Vol : réussir le mouvement; 
		 * Dextérité : réussir le mouvement, direction du souafle. */
		public void chargeChelm()
		{
		}
		
		/* PLONGEON DE DYONISOS. Smash dans le souafle. Dextérité : direction du souafle, toucher le souafle. */
		public void plongeonDyo()
		{
		}
		
		/* PINCE DE PARKIN. 2 poursuiveurs se collent à un poursuiveur adverse et le troisième lui fonce dessus. Vol pour 
		 * les trois joueurs : réussite de l'action (bonus d'initiative et de chance). */
		public void pinceParkin()
		{
		}
		
		/* TASSEBUT. Deux joueurs écartent le gardien adverse pour laisser un troisième joueur marquer. Force : réussir à 
		 * tirer le gardien ; Dextérité : réussir à attraper le gardien ; Chance : l'arbitre ne voit pas l'action. */
		public void tasseBut()
		{
		}
		
		/* CROC-EN-MANCHE. Accrocher le manche d'un adversaire avec le sien pour lui faire changer de direction. Dextérité : 
		 * réussir à accrocher le balai ; Vol : réssir à garder son cap ; Chance : l'arbitre ne voit pas l'action. */
		public void crocManche()
		{
		}
		
		/* PINCEVIF. Un autre joueur que l'attrapeur touche le Vif-d'Or. Chance : l'arbitre ne voit pas l'action. */
		public void pinceVif()
		{
		}
		
		/* POGNENSAC. Le joueur passe le Souafle dans les buts dans le lacher. Chance : l'arbitre ne voit pas l'action ; 
		 * Dextérité : réussir à mettre le Souafle dans un anneau. */
		public void pognenSac()
		{
		}
		
	}
}
