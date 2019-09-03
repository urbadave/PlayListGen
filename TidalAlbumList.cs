using System;
using System.Collections.Generic;

public class TidalAlbumList
{
    public string Name { get; set; }

    public List<TidalAlbum> Albums { get; set; }

    public TidalAlbumList()
    {
        Name = string.Empty;
        Albums = new List<TidalAlbum>();
    }

    public TidalAlbumList(string name, List<TidalAlbum> source) : this()
    {
        Name = name;
        Albums = new List<TidalAlbum>(source);
        Albums.Sort();
    }

    public TidalAlbumList AddAlbum(TidalAlbum album)
    {
        if (!Albums.Contains(album))
        {
            Albums.Add(album);
            Albums.Sort();
        }
        return this;
    }

    public TidalAlbumList AddAlbums(List<TidalAlbum> source)
    {
        if(source != null){
            source.ForEach(a => {
                if(!Albums.Contains(a)){
                    Albums.Add(a);
                }
            });
            Albums.Sort();
        }
        return this;
    }

    public TidalAlbumList RemoveAlbum(TidalAlbum album)
    {
        var foundAlbum = Albums.Find(a => a.Equals(album));
        if(foundAlbum != null)
        {
            Albums.Remove(foundAlbum);
        }
        return this;
    }

    public TidalAlbumList RemoveAlbums(List<TidalAlbum> source)
    {
        if(source != null)
        {
            TidalAlbum foundAlbum = null;
            source.ForEach(a => {
               foundAlbum = Albums.Find(al => al.Equals(a));
               if(foundAlbum != null) Albums.Remove(foundAlbum);
            });
        }
        return this;
    }
}