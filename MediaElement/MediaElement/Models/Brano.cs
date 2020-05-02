using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MediaElement.Models
{
    public class Brano
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public string Immagine { get; set; }
        public string Mp3 { get; set; }
    }

    public class Brani : ObservableCollection<Brano>
    {
        public Brani()
        {
            Add(new Brano { 
                Autore = "Metre", 
                Titolo = "Sand Dweller", 
                Immagine = "https://files.freemusicarchive.org/storage-freemusicarchive-org/images/artists/Metre_-_2018102225915098.jpg?width=100&height=100", 
                Mp3 = "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/Nul_Tiel_Records/Metre/Motif/Metre_-_03_-_Sand_Dweller.mp3" 
            });

            Add(new Brano { 
                Autore = "Kielokaz", 
                Titolo = "Alte Herren", 
                Immagine = "https://files.freemusicarchive.org/storage-freemusicarchive-org/images/albums/KieLoKaz_-_Free_Ganymed_-_20190912113845208.jpg?method=crop&width=100&height=100", 
                Mp3 = "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/no_curator/KieLoKaz/Free_Ganymed/KieLoKaz_-_07_-_Alte_Herren_Kielokaz_ID_364.mp3"
            });

            Add(new Brano { 
                Autore = "Broke For Free", 
                Titolo = "Night Owl", 
                Immagine = "https://files.freemusicarchive.org/storage-freemusicarchive-org/images/artists/Broke_For_Free_-_2013011621055318.jpg?width=290&height=290", 
                Mp3 = "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/WFMU/Broke_For_Free/Directionless_EP/Broke_For_Free_-_01_-_Night_Owl.mp3" 
            });
        
            Add(new Brano { Autore = "Spot", Titolo = "", Immagine = "", Mp3 = "https://open.spotify.com/track/6WgBIPHwkQhCqMNnR5hQCN?si=_6lUYo3DTvCNUDmo5TSxeA" });

            //Add(new Brano { Autore = "", Titolo = "", Immagine = "", Mp3 = "" });
        }
    }
}
