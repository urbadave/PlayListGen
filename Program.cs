using System;

namespace PlayListGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var masterList = new TidalAlbumList();
            masterList.AddAlbum(new TidalAlbum("B.o.B.", "Strange Clouds"))
            .AddAlbum(new TidalAlbum("Alphaville", "Forever Young"))
            .AddAlbum(new TidalAlbum("Amy Winehouse", "Back To Black"));

            var count = masterList.Albums.Count;
        }
    }
}
