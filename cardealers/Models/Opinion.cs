using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace cardealers.Models
{
    public class Opinion
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage ="Username required")]
        [StringLength(100, ErrorMessage ="Username too long" )]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email required")]
        [StringLength(100, ErrorMessage = "Email too long")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message required")]
        [StringLength(5000, ErrorMessage = "Message too long")]
        public string Message { get; set; }
        public bool IsAwatingReply { get; set; }
    }
}
