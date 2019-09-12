
using System;
using System.Collections.Generic;

public class Playlist
{
    public TidalAlbumList Albums {get; set;}
    public string Name { get; set; }
    
    public Playlist()
    {
        Albums = new TidalAlbumList(){State = ListState.random};
    }

    public Playlist(string name): this()
    {
        Name = name;
    }

    public void SetAlbums(List<TidalAlbum> albums)
    {
        Albums.Clear();
        Albums.AddAlbums(albums);
    }
}