/// 
///  ReasonViewModel class is the model which stores info about the reasons
///  joining BHHC
///  
///  This is a simple project so it's alaso the ViewModel for
///  presenting the info.
///   
/// Fields:
/// Id          -> key
/// Title       -> title (Index page)
/// Explanation -> detailed text (Detail page)
///

using System.ComponentModel.DataAnnotations;

namespace bhccsolution.Models
{
    /// <summary>
    ///     Stores & presents reasons info 
    /// </summary>
    public class ReasonViewModel
    {
        /// <summary>
        ///     Id 
        /// </summary>

        [Key]
        public uint Id { get; set; }

        /// <summary>
        ///     Title is a short description
        /// </summary>
        
        [Required]
        public string Title { get; set; }

        /// <summary>
        ///     Detailed text
        /// </summary>

        [Required]
        public string Explanation { get; set; }
    }
}