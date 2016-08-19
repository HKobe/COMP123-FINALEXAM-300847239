using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 *Author: Hassan Kobeissi
 * Co-Author: Tom T
 * Date Created: 2016-08-19
 * Date Modified: 2016-08-19
 * Program Description: Create the public properties for the other forms
 */
namespace COMP123_S2016_FinalExam
{
    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }
        //Added new properties First name and Last name
        public string FirstName { get; set; }
        
        public string LastName { get; set; } 
    }
}