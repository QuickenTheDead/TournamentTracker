/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 13/03/2016
 * Time: 8:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TournamentTracker
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public class Player
	{
		public string firstName;
		public string lastName;
		public string faction;
		public Player()
		{
			
		}
		public Player(string firstNm, string lastNm, string fact)
		{
			firstName = firstNm;
			lastName = lastNm;
			faction = fact;
			
		}
		public void SetFirstName(string newFirstName)
   		{
        	firstName = newFirstName;
   		}
		public void SetLastName(string newLastName)
   		{
        	lastName = newLastName;
   		}
		public void SetFaction(string newFactionName)
   		{
        	faction = newFactionName;
   		}
		public String getFirstName() {
        return firstName;
    	}
		public String getLastName() {
        return lastName;
    	}
		public String getFaction() {
        return faction;
    	}
	}
}
