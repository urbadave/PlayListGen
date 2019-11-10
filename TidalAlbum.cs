using System;

public class TidalAlbum: IComparable<TidalAlbum>, IEquatable<TidalAlbum>
{
    public string Artist { get; set; }
    public string Title { get; set; }
    public string PlayList {get; set;}

    public bool IsAvailable{ get {return string.IsNullOrWhiteSpace(PlayList);}}

    public TidalAlbum(){
        Artist = null;
        Title = null;
        PlayList = null;
    }

    public TidalAlbum(string artist, string title){
        Artist = artist;
        Title = title;
    }

    public TidalAlbum(string artist, string title, string playList) : this(artist, title){
        PlayList = playList;
    }


    public int CompareTo(TidalAlbum other){
        if(other == null) return -1;

        if(string.Compare(Artist, other.Artist, true) == 0){
            return string.Compare(Title, other.Title, true);
        } else {
            return string.Compare(Artist, other.Artist, true);
        }
    }

    public override string ToString() => $"{Artist} - {Title}";
    
    public bool Equals(TidalAlbum other){
        if (other == null) return false;

        return (string.Compare(Artist, other.Artist, true) == 0 && string.Compare(Title, other.Title, true) == 0);
    }

}