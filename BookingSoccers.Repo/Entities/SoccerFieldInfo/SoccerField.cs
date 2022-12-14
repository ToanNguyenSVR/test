

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookingSoccers.Repo.Entities.UserInfo;

namespace BookingSoccers.Repo.Entities.SoccerFieldInfo
{

    public class SoccerField
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ManagerId")]
        public User user { get; set; }

        [Required]
        public int ManagerId { get; set; }

        [Required]
        [StringLength(100)]
        public string FieldName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TimeSpan OpenHour { get; set; }

        [Required]
        public TimeSpan CloseHour { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        public byte Status { get; set; }

        [Required]
        public int TotalReviews { get; set; }

        [Required]
        public int ReviewScoreSum { get; set; }

        [Required]
        public int BaseTimeInterval { get; set; }
    }
}

