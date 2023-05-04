using System;
namespace MortalKombatApi.Models
{
	public class Character
	{
		public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Sex { get; set; } = string.Empty;

        public string Skill { get; set; } = string.Empty;

    }
}

