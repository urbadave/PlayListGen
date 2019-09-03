using System;

public class TidalAlbum: IComparable<TidalAlbum>
{
    public string Artist { get; set; }
    public string Title { get; set; }

    public TidalAlbum()
    {
        Artist = null;
        Title = null;
    }
    public TidalAlbum(string artist, string title)
    {
        Artist = artist;
        Title = title;
    }

    public int CompareTo(TidalAlbum other){
        if(other == null) return -1;

        if(string.Compare(Artist, other.Artist, true) == 0){
            return string.Compare(Title, other.Title, true);
        } else {
            return string.Compare(Artist, other.Artist, true);
        }
    }

    public override string ToString(){
        return $"{Artist} - {Title}";
    }
}