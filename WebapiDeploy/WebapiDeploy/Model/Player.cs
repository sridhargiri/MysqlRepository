using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiDeploy.Model
{
    [Table("Players")]
    public class Player
    {
        [Column("PlayerID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int PlayerID { get; set; }

        [Column("PlayerName")]
        [Required]
        [StringLength(100)]
        public string PlayerName { get; set; }
        [Column("Kills")]
        [Required]
        public int Kills { get; set; }
        [Column("Score")]
        [Required]
        public int Score { get; set; }
        [Column("Rank")]
        [Required]
        public int Rank { get; set; }
        [Column("MatchTime")]
        [Required]
        public DateTime MatchTime { get; set; }
    }
    public class PlayerCollection
    {
        public List<Player> PlayerStats { get; set; }
    }
}
