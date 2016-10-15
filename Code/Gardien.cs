using System;

namespace QFL
{
	public class Gardien : Joueur
	{
		public Gardien(String lastname, String firstname, int ageJoueur, bool sex, int strBd, int strBg, int dexBd, 
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
		
		/* PLONGER. Le joueur plonge pour arr�ter le Souafle. Initiative : vitesse de la r�action ; Dext�rit� : r�ussite 
		 * du plongeon ; Vol : rester sur le balai ; Perception : si le joueur n'est pas de face. */
		public void plonger()
		{
		}
		
		/* DETOURNER TIR. Le joueur d�tourne le tir. Initiative : vitesse de la r�action ; Dext�rit� : r�ussite du 
		 * plongeon ; Vol : rester sur le balai ; Perception : si le joueur n'est pas de face. */
		public void detTir()
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
		
		/* DOUBLE-HUIT. Un joueur se d�place en effectuant des boucles devant les buts pour couvrir plus de surface. Vol : 
		 * r�ussite du mouvement (bonus d'initiative). */
		public void doubleHuit()
		{
		}
		
		/* ETOILE DE MER. Le joueur ne se tient que par un pied et une main � son balai pour couvrir une plus large surface.
		 * Dext�rit� : r�ussir � rester accrocher au balai ; Vol : r�ussir � faire dy surplace et � bien se placer. */
		public void etoilMer()
		{
		}
		
		/* PINCEVIF. Un autre joueur que l'attrapeur touche le Vif-d'Or. Chance : l'arbitre ne voit pas l'action. */
		public void pinceVif()
		{
		}
		
	}
}
