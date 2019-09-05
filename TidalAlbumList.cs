using System;
using System.Collections.Generic;

public enum ListState { sorted, random };

public class TidalAlbumList : List<TidalAlbum>
{
    public string Name { get; set; }

    public ListState State { get; set; }

    public TidalAlbumList() : base()
    {
        Name = string.Empty;
        State = ListState.sorted;
    }

    public TidalAlbumList(string name, List<TidalAlbum> source) : this()
    {
        Name = name;
        source.ForEach(a => Add(a));
        Sort();
    }

    public TidalAlbum GetAlbumAt(int index)
    {
        if (index > Count)
            throw new ArgumentException($"{index} greater than album count");
        return this[index];
    }

    public TidalAlbumList AddAlbum(TidalAlbum album)
    {
        if (!Contains(album))
        {
            Add(album);
            if (State == ListState.sorted)
                Sort();
        }
        return this;
    }

    public TidalAlbumList AddAlbums(List<TidalAlbum> source)
    {
        if (source != null)
        {
            source.ForEach(a =>
            {
                if (!Contains(a))
                {
                    Add(a);
                }
            });
            if (State == ListState.sorted)
                Sort();
        }
        return this;
    }

    public TidalAlbumList RemoveAlbum(TidalAlbum album)
    {
        var foundAlbum = Find(a => a.Equals(album));
        if (foundAlbum != null)
        {
            Remove(foundAlbum);
        }
        return this;
    }

    public TidalAlbumList RemoveAlbum(int index)
    {
        if (index < Count)
        {
            RemoveAt(index);
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
                foundAlbum = Find(al => al.Equals(a));
                if (foundAlbum != null) Remove(foundAlbum);
            });
        }
        return this;
    }

    public TidalAlbumList RandomSublist(int size)
    {
        if (size > Count)
            throw new ArgumentException("Size cannot exceed library size");

        var randomList = RandomCopy();
        var retVal = new TidalAlbumList() { State = ListState.random };
        for (var i = 0; i < size; i++)
        {
            retVal.AddAlbum(randomList.GetAlbumAt(i));
        }

        return retVal;
    }

    public TidalAlbumList RandomCopy()
    {
        var retVal = new TidalAlbumList() { State = ListState.random };
        var copy = new TidalAlbumList(Name, this);

        var random = new Random();

        while (copy.Count > 0)
        {
            if (copy.Count == 1)
            {
                retVal.AddAlbum(copy.GetAlbumAt(0));
                copy.RemoveAlbum(0);
            }
            else
            {
                var index = random.Next(copy.Count);
                retVal.AddAlbum(copy.GetAlbumAt(index));
                copy.RemoveAlbum(index);
            }
        }

        return retVal;
    }

}