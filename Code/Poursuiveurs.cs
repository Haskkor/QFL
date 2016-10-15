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
		
		/* PASSE MAIN GAUCHE. Un joueur lance le Souafle en direction d'un autre joueur. Force : distance ; Dext�rit� : 
		 * pr�cision. */
		public void passeMG()
		{
		}
		
		/* PASSE MAIN DROITE. Un joueur lance le Souafle en direction d'un autre joueur. Force : distance ; Dext�rit� : 
		 * pr�cision. */
		public void passeMD()
		{
		}
		
		/* TIR MAIN GAUCHE. Un joueur lance le Souafle en dirction des cercles de buts. Force : distance ; Dext�rit� : 
		 * pr�cision. */
		public void tirMG()
		{
		}
		
		/* TIR MAIN DROITE. Un joueur lance le Souafle en dirction des cercles de buts. Force : distance ; Dext�rit� : 
		 * pr�cision. */
		public void tirMD()
		{
		}
		
		/* RATRAPPER MAIN GAUCHE. Un joueur rattrape le Souafle lanc� par un autre joueur. Initiative : r�action ; 
		 * Dext�rit� : rattraper ; Perception : si le joueur n'est pas de face. */
		public void ratrapperMG()
		{
		}
		
		/* RATRAPPER MAIN DROITE. Un joueur rattrape le Souafle lanc� par un autre joueur. Initiative : r�action ; 
		 * Dext�rit� : rattraper ; Perception : si le joueur n'est pas de face. */
		public void ratrapperMD()
		{
		}
		
		/* FRAPPE-SOUAFLE. Un joueur tape dans le Souafle qu'un autre joueur tient afin de lui subtiliser. Force : force du 
		 * renvoi ; Dext�rit� : pr�cision du renvoi, r�ussir � frapper dans le Souafle. */
		public void frapSouafle()
		{
		}
		
		/* TIR LONG MAIN GAUCHE. D�gager le Souafle � grande distance. Force : distance ; Dext�rit� : pr�cision. */
		public void tirLongMG()
		{
		}
		
		/* TIR LONG MAIN DROITE. D�gager le Souafle � grande distance. Force : distance ; Dext�rit� : pr�cision. */
		public void tirLongMD()
		{
		}
		
		/* TREMBLANTE DE WOOLONGONG. Se d�placer en zig-zag. Dext�rit� : r�ussir � rester sur le balai ; Vol : r�ussir 
		 * l'acrobatie. */
		public void tremblanteWoo()
		{
		}
		
		/* ATTAQUE EN FAUCON. Trois poursuiveurs c�te � c�te , celui du centre l�g�rement en avant. Vol : pour les trois 
		 * poursuiveurs (offre des bonus de dext�rit� , de distance et de charisme). */
		public void attFaucon()
		{
		}
		
		/* FEINTE DE PORSKOFF. Le joueur monte en chandelle pour que les adversaires le suivent puis lache le Souafle � un 
		 * partenaire en dessous. Dext�rit� : r�ussir � rester sur le balai ; Vol : r�ussir l'acrobatie ; Force : distance ; 
		 * Dext�rit� : pr�cision. */
		public void feintePors()
		{
		}
		
		/* FEINTE DEFENSIVE DE WRONSKI. Le joueur plonge vers le sol pour forcer un autre joueur � le suivre et remonte au 
		 * dernier moment. Dext�rit� : r�ussir � rester sur le balai ; Vol : r�ussir l'acrobatie. */
		public void feinteWrons()
		{
		}
		
		/* PASSE ARRIERE MAIN GAUCHE. Le joueur passe le Souafle vers l'arri�re. Force : distance ; Dext�rit� : pr�cision. */
		public void passArrMG()
		{
		}
		
		/* PASSE ARRIERE MAIN DROITE. Le joueur passe le Souafle vers l'arri�re. Force : distance ; Dext�rit� : pr�cision. */
		public void passArrMD()
		{
		}
		
		/* PENALTY. Le joueur tire un penalty. Force : distance ; Dext�rit� : pr�cision. */
		public void penalty()
		{
		}
		
		/* FOURBERIE DE FINBOURGH. Frapper le souaffle avec la queue du balai. Dext�rit� : toucher le souafle, direction 
		 * du souafle; Vol : r�ussi le mouvement; */
		public void fourbFinb()
		{
		}
		
		/* CHARGE DE CHELMONDISTO. Salto avant pour tirer en extension et retomber sur le balai. Vol : r�ussir le mouvement; 
		 * Dext�rit� : r�ussir le mouvement, direction du souafle. */
		public void chargeChelm()
		{
		}
		
		/* PLONGEON DE DYONISOS. Smash dans le souafle. Dext�rit� : direction du souafle, toucher le souafle. */
		public void plongeonDyo()
		{
		}
		
		/* PINCE DE PARKIN. 2 poursuiveurs se collent � un poursuiveur adverse et le troisi�me lui fonce dessus. Vol pour 
		 * les trois joueurs : r�ussite de l'action (bonus d'initiative et de chance). */
		public void pinceParkin()
		{
		}
		
		/* TASSEBUT. Deux joueurs �cartent le gardien adverse pour laisser un troisi�me joueur marquer. Force : r�ussir � 
		 * tirer le gardien ; Dext�rit� : r�ussir � attraper le gardien ; Chance : l'arbitre ne voit pas l'action. */
		public void tasseBut()
		{
		}
		
		/* CROC-EN-MANCHE. Accrocher le manche d'un adversaire avec le sien pour lui faire changer de direction. Dext�rit� : 
		 * r�ussir � accrocher le balai ; Vol : r�ssir � garder son cap ; Chance : l'arbitre ne voit pas l'action. */
		public void crocManche()
		{
		}
		
		/* PINCEVIF. Un autre joueur que l'attrapeur touche le Vif-d'Or. Chance : l'arbitre ne voit pas l'action. */
		public void pinceVif()
		{
		}
		
		/* POGNENSAC. Le joueur passe le Souafle dans les buts dans le lacher. Chance : l'arbitre ne voit pas l'action ; 
		 * Dext�rit� : r�ussir � mettre le Souafle dans un anneau. */
		public void pognenSac()
		{
		}
		
	}
}
