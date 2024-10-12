using System.ComponentModel.DataAnnotations;

namespace WDevOrg.Models
{
    /// <summary>
    /// A single category inside a project
    /// 
    /// Contains many items
    /// </summary>
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProjectId { get; set; }
        /// <summary>
        /// The project this category belongs to
        /// </summary>
        [Required]
        public required Project Parent;

        /// <summary>
        /// The name of this category
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public required string Name { get; set; }

        /// <summary>
        /// The description of this category as an editor.js JSON object
        /// </summary>
        [Required]
        public required EditorJson Description { get; set; }

        /// <summary>
        /// The items inside this category
        /// </summary>
        [Required]
        public List<Item> Items { get; set; } = new();

    }
}
