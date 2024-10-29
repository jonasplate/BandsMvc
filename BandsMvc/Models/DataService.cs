using System.Collections.Generic;
using System.Linq;

namespace BandsMvc.Models
{
    public class DataService
    {
        private List<Band> bands = new List<Band>
        {
            new Band(1, "Justin Bieber", "Belieber Forever", "/images/justin_bieber.jpg"),
            new Band(2, "Micke Målarns Jazzband", "Bästa skivan: EPA LOVERS VOL.2", "/images/Mike.jpg"),
            new Band(3, "Not So Slick - Rick", "Music Vibes Control", "/images/not_so_slick_rick.jpg")
        };

        public Band? GetBandById(int id) => bands.FirstOrDefault(b => b.Id == id);
        public Band[] GetAllBands() => bands.ToArray();
    }
}
