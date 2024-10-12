using System.ComponentModel.DataAnnotations;

namespace WDevOrg.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// The ID of the category this item belongs to
        /// </summary>
        [Required]
        public int CategoryId { get; set; }
        /// <summary>
        /// The project this category belongs to
        /// </summary>
        [Required]
        public required Category Parent;

        /// <summary>
        /// The name of the item
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public required string Name { get; set; }


        /// <summary>
        /// The item's content
        /// </summary>
        [Required]
        public required EditorJson Content { get; set; }

    }
}
