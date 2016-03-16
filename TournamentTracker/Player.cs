﻿/*
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
		private string myFirstName;
		private string myLastName;
		private string myFaction;
		private string myDisplayName;
		public Player()
		{
			
		}
		public Player(string firstNm, string lastNm, string fact)
		{
			this.myFirstName = firstNm;
			this.myLastName = lastNm;
			this.myFaction = fact;
			this.myDisplayName = firstNm + " " + lastNm + " " + " ("+fact+")";	
		}
		public string firstName
        {
            get
            {
                return myFirstName;
            }
            set
            {
                myFirstName = value;
                myDisplayName = myFirstName + " " + myLastName + " " + " ("+myFaction+")";
            }
        }
		
		public string lastName
        {
            get
            {
                return myLastName;
            }
            set
            {
                myLastName = value;
                myDisplayName = myFirstName + " " + myLastName + " " + " ("+myFaction+")";
            }
        }
		public string faction
        {
            get
            {
                return myFaction;
            }
            set
            {
                myFaction = value;
                myDisplayName = myFirstName + " " + myLastName + " " + " ("+myFaction+")";
            }
        }
		public string displayName
        {
            get
            {
                return myDisplayName;
            }
        }
    	
	}
}