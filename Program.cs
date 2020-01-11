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
			using (StreamReader reader = new StreamReader("Data2.txt")){
			   var line = reader.ReadLine();
			   while(line != null){
				   var parts = line.Split('\t');
				   masterList.AddAlbum(new TidalAlbum(parts[0],parts[1],null));
				   line = reader.ReadLine();
			   }
			}
			
			var startNumber = 56;
			var availableCount = masterList.AvailableList().Count;

			using (StreamWriter writer = new StreamWriter("Playlist2.txt",false))
			{
				while(availableCount > 16)
				{
					var playList = masterList.AvailableList().RandomSublist(16);
					var playListName = $"PL{startNumber++}";
					playList.Name = playListName;
					playList.ForEach(ta => ta.PlayList = playListName);
					masterList.AssignPlaylist(playList, playListName);
					var outPut = playList.ToStringList();
					outPut.ForEach(l => writer.WriteLine(l));
					availableCount = masterList.AvailableList().Count;
					writer.WriteLine();
				}
			}
        }
    }
}
