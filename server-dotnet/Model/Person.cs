using System;
using System.ComponentModel.DataAnnotations;

namespace server_dotnet
{
    public class Person
    {
        /// <summary>
        ///     The full name of the person.
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///     An optional home address.
        /// </summary>
        [Required]
        public Address? Address { get; set; } = null;

        public string? FavoriteQuote { get; set; }

        public Sport? Interest { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }
    }

    /// <summary>
    ///     Sports that can be practised during free time.
    /// </summary>
    public enum Sport
	{
        /// <summary>
        ///     A game with a ball.
        /// </summary>
        Tennis,

        /// <summary>
        ///     Computer game or board game.
        /// </summary>
        Games,
        
        /// <summary>
        ///     One of the oldest activity.
        /// </summary>
        Walking
	}
}
