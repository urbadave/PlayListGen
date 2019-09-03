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
        if (source != null)
        {
            source.ForEach(a =>
            {
                if (!Albums.Contains(a))
                {
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
        if (foundAlbum != null)
        {
            Albums.Remove(foundAlbum);
        }
        return this;
    }

    public TidalAlbumList RemoveAlbums(List<TidalAlbum> source)
    {
        if (source != null)
        {
            TidalAlbum foundAlbum = null;
            source.ForEach(a =>
            {
                foundAlbum = Albums.Find(al => al.Equals(a));
                if (foundAlbum != null) Albums.Remove(foundAlbum);
            });
        }
        return this;
    }

    public TidalAlbumList RandomSublist(int size)
    {
        if (size > Albums.Count)
            throw new ArgumentException("Size cannot exceed library size");

        var retVal = new TidalAlbumList();
        if (size < Albums.Count)
        {
            //create a random list of indexes.
            var indexList = new List<int>();
            Random r = new Random();
            for (var i = 0; i < size; i++)
            {
                int index = r.Next(Albums.Count);
                if (!indexList.Contains(index)) indexList.Add(index);
            }

            //create list of artists used
            var artists = new List<string>();

            //foreach index, add album to list, if artist doesn't appear in hash
            indexList.ForEach(i =>
            {
                var album = Albums[i];
                if (!artists.Contains(album.Artist))
                {
                    retVal.AddAlbum(album);
                    artists.Add(album.Artist);
                }
            });
        }
        return retVal;
    }

}