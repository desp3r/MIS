using MIS.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MIS.Data.Models
{
    public class User : IEntity
    {
        public Guid Id { get; set; }

        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Password { get; set; } = null!;

        public DateTime? CreatedAt { get; set; } = null!;
        public DateTime? UpdatedAt { get; set; } = null!;

    }
}
