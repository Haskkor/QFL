using System;

namespace QFL
{
	public class Attrapeur : Joueur
	{
		public Attrapeur(String lastname, String firstname, int ageJoueur, bool sex, int strBd, int strBg, int dexBd, 
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
		
		/* ATTRAPER VIF-D'OR. Un joueur attrape le Vif-d'Or. Initiative : r�action ; Dext�rit� : rattraper ; Perception : 
		 * si le joueur n'est pas de face. */
		public void attrapVif()
		{
		}
		
		/* TREMBLANTE DE WOOLONGONG. Se d�placer en zig-zag. Dext�rit� : r�ussir � rester sur le balai ; Vol : r�ussir 
		 * l'acrobatie. */
		public void tremblanteWoo()
		{
		}
		
		/* FEINTE DEFENSIVE DE WRONSKI. Le joueur plonge vers le sol pour forcer un autre joueur � le suivre et remonte au 
		 * dernier moment. Dext�rit� : r�ussir � rester sur le balai ; Vol : r�ussir l'acrobatie. */
		public void feinteWrons()
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

	}
}
