using System;
using System.Collections.Generic;
using System.Linq;

public enum ListState { sorted, random };

public class TidalAlbumList : List<TidalAlbum>
{
    public string Name { get; set; }

    public ListState State { get; set; }

    public int? _maxArtistLength;
    public int MaxArtistLength
    {
        get
        {
            if(_maxArtistLength == null && this.Any())
            {
                 _maxArtistLength = this.AsEnumerable().Max(a => a.Artist.Length);
            }
            return _maxArtistLength.Value;
        }
    }

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
            _maxArtistLength = null;
            if (State == ListState.sorted)
                Sort();
        }
        return this;
    }

    public TidalAlbumList AddAlbums(List<TidalAlbum> source)
    {
        if (source != null)
        {
            _maxArtistLength = null;
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
            _maxArtistLength = null;
            Remove(foundAlbum);
        }
        return this;
    }

    public TidalAlbumList RemoveAlbum(int index)
    {
        if (index < Count)
        {
            _maxArtistLength = null;
            RemoveAt(index);
        }
        return this;
    }

    public TidalAlbumList RemoveAlbums(List<TidalAlbum> source)
    {
        if (source != null)
        {
            _maxArtistLength = null;
            TidalAlbum foundAlbum = null;
            source.ForEach(a =>
            {
                foundAlbum = Find(al => al.Equals(a));
                if (foundAlbum != null) Remove(foundAlbum);
            });
        }
        return this;
    }

    public void AssignPlaylist(List<TidalAlbum> source, string playListName)
    {
        TidalAlbum foundAlbum = null;
        if(source != null)
        {
            source.ForEach(a =>
            {
                foundAlbum = Find(al => al.Equals(a));
                if(foundAlbum != null){
                    foundAlbum.PlayList = playListName;
                }
            });
        }
    }

    public TidalAlbumList RandomSublist(int size)
    {
        if (size > Count)
            throw new ArgumentException("Size cannot exceed library size");

        var randomList = RandomCopy();
        var retVal = new TidalAlbumList() { State = ListState.random };

        var index = 0;
        while(retVal.Count < size)
        {
            //if retVal already contains an album with the potential artist, skip, size permitting
            var albumToAdd = randomList.GetAlbumAt(index);

            if(retVal.Any(a => a.Artist == albumToAdd.Artist)){
                //see if we have enough room.
                var stillToAdd = size - retVal.Count;
                var sourceAlbumsLeft = randomList.Count - (index+1);
                //just skip one. If it's that artist again, it was meant to be.
                if(stillToAdd <= sourceAlbumsLeft)
                {
                    index++;
                    albumToAdd = randomList.GetAlbumAt(index);
                }
            }

            retVal.AddAlbum(albumToAdd);
            index++;
        }

        return retVal;
    }

    public TidalAlbumList AvailableList()
    {
        var available = this.AsEnumerable().Where(ta => ta.IsAvailable).ToList();
        return new TidalAlbumList("available", available);
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

    public List<string> ToStringList()
    {
        var crucialValue = this.MaxArtistLength;
        var retVal = new List<string>();
        retVal.Add(Name);
        this.ForEach(ta => retVal.Add(ta.ToPrettyString(crucialValue)));
        return retVal;
    }
}