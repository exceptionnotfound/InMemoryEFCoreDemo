using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreInMemoryDemo.Web.Models
{
    public class BoardGame
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DisplayName("Publishing Company")]
        public string PublishingCompany { get; set; }

        [DisplayName("Min Players")]
        public int MinPlayers { get; set; }

        [DisplayName("Max Players")]
        public int MaxPlayers { get; set; }
    }
}
