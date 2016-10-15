using System;

namespace QFL
{
	public class Batteur : Joueur
	{
		public Batteur(String lastname, String firstname, int ageJoueur, bool sex, int strBd, int strBg, int dexBd, 
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
		
		/* RENVOIE COGNARD ALEATOIRE. Le joueur renvoie le Cognard au hasard. Force : vitesse du Cognard ; Perception : si 
		 * le joueur n'est pas de face ; Dextérité : frapper dans le Cognard. */
		public void renvCognAléa()
		{
		}
		
		/* RENVOIE COGNARD DIRIGE. Le joueur renvoie le Cognard vers un joueur adverse. Force : vitesse du Cognard ; 
		 * Perception : si le joueur n'est pas de face ; Dextérité : frapper dans le Cognard , direction du Cognard. */
		public void renvCognDir()
		{
		}
		
		/* RENVOIE DE COGNARD. Un joueur revoie un Cognard derrière lui pour surprendre ses adversaires. Force : vitesse du 
		 * Cognard ; Perception : si le joueur n'est pas de face ; Dextérité : frapper dans le Cognard. */
		public void reversCogn()
		{
		}
		
		/* DEFENSE EN DOUBLE BATTE. Deux joueurs frappent un Cognard en même temps pour effectuer une attaque plus puissante.
		 * Dextérité pour les deux joueurs : réussir à frapper dans le Cognard ; Force pour les deux joueurs : puissance 
		 * donné au Cognard. */
		public void defDoublBat()
		{
		}
		
		/* FRAPPER JOUEUR AVEC BATTE. Un joueur frappe un autre joueur avec une batte. Force : puissance de l'impact ; 
		 * Dextérité : le joueur réussit son coup ; Chance : l'arbitre ne voit pas l'action. */
		public void frapAcBat()
		{
		}
		
		/* TRANCHEFOULE. Frapper le Cognard en direction de la foule pour arrêter le jeu et empêcher un joueur de marquer.
		 * Force : vitesse du Cognard ; Perception : si le joueur n'est pas de face ; Dextérité : frapper dans le Cognard, 
		 * direction du Cognard. */
		public void tranchFoul()
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
		
		/* PINCE DE PARKIN. 2 poursuiveurs se collent à un poursuiveur adverse et le troisième lui fonce dessus. Vol pour 
		 * les trois joueurs : réussite de l'action (bonus d'initiative et de chance). */
		public void pinceParkin()
		{
		}
		
	}
}
