
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WDevOrg.Models
{
    /// <summary>
    ///  A single project
    /// </summary>
    public class Project
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// The name of this project
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public required string Name { get; set; }
        /// <summary>
        /// Whether the project is visible to all registered users
        /// </summary>
        public bool IsPublic { get; set; } = true;
        /// <summary>
        /// The users allowed to view the project.
        ///
        /// Only takes effect if IsPublic is false
        /// </summary>
        public List<IdentityUser> AllowedUsers = new ();


        /// <summary>
        /// The categories inside the project
        /// </summary>
        public List<Category> Categories { get; set; } = new ();
    }
}
