using System;
using System.Collections.Generic;
using System.IO;

namespace PlayListGen
{
    class Program
    {
        static void Main(string[] args)
        {
			var masterList = new TidalAlbumList(){Name = "From file"};
			using (StreamReader reader = new StreamReader("Data.txt")){
			   var line = reader.ReadLine();
			   while(line != null){
				   var parts = line.Split('\t');
				   masterList.AddAlbum(new TidalAlbum(parts[0],parts[1],null));
				   line = reader.ReadLine();
			   }
			}
			var dataCount = masterList.Count;

            var count = masterList.Count;

            var playList = masterList.RandomSublist(16);
			var playListName = "PLXX";
			playList.ForEach(ta => ta.PlayList = playListName);
			masterList.AssignPlaylist(playList, playListName);
			var afterCount = masterList.AvailableList().Count;

			using (StreamWriter writer = new StreamWriter("Playlist.txt", false))
			{
				playList.ForEach(ta => writer.WriteLine($"{ta.Artist}\t{ta.Title}\t{ta.PlayList}"));
			}

			playList.ForEach(a => Console.WriteLine(a));
			Console.ReadLine();
        }
    }
}
