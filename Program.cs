﻿using System;
using System.Collections.Generic;

namespace PlayListGen
{
    class Program
    {
        static void Main(string[] args)
        {
           var sourceList = new List<TidalAlbum>(){new TidalAlbum("Alphaville","Forever Young"),
                new TidalAlbum("Amy Winehouse","Back To Black"),
				new TidalAlbum("Augustana","Augustana"),
				new TidalAlbum("B.o.B.","Strange Clouds"),
				new TidalAlbum("Billy Joel","The Stranger"),
				new TidalAlbum("Blitzen Trapper","VII"),
				new TidalAlbum("Brandi Carlile","Bear Creek"),
				new TidalAlbum("Bruce Springsteen","Darkness On The Edge Of Town"),
				new TidalAlbum("Death Cab For Cutie","Codes And Keys"),
				new TidalAlbum("Evanescence","Fallen"),
				new TidalAlbum("Foster The People","Torches"),
				new TidalAlbum("Gossip","A Joyful Noise"),
				new TidalAlbum("Kasabian","Velociraptor!"),
				new TidalAlbum("KT Tunstall","Eye To The Telescope"),
				new TidalAlbum("Led Zeppelin","Physical Graffiti"),
				new TidalAlbum("Matisyahu","Spark Seeker"),
				new TidalAlbum("Michael Franti","All Rebel Rockers"),
				new TidalAlbum("Pete Townshend","Empty Glass"),
				new TidalAlbum("Pink","Try This"),
				new TidalAlbum("Queen","News Of The World"),
				new TidalAlbum("Red Hot Chili Peppers","Stadium Arcadium"),
				new TidalAlbum("Santana","Supernatural"),
				new TidalAlbum("The Cars","Candy-O"),
				new TidalAlbum("The Killers","Hot Fuss"),
				new TidalAlbum("Volbeat","Guitar Gangsters & Cadillac Blood"),
				new TidalAlbum("Wissin Y Yandel","Líderes"),
				new TidalAlbum("ZZ Top","Eliminator"),
				new TidalAlbum("2pac","All Eyez On Me"),
				new TidalAlbum("Adele","21"),
				new TidalAlbum("Alanis Morissette","Jagged Little Pill"),
				new TidalAlbum("Awolnation","Here Come The Runts"),
				new TidalAlbum("Band Of Skulls","Baby Darling Doll Face Honey"),
				new TidalAlbum("Bebe","Un Pokito De Rocanrol"),
				new TidalAlbum("Billy Joel","52nd Street"),
				new TidalAlbum("Blue Oyster Cult","Cultosauros Erectus"),
				new TidalAlbum("Bob Dylan","Blood On The Tracks"),
				new TidalAlbum("Bonde do Rolê","Tropicalbacanal"),
				new TidalAlbum("Chris Stapleton","From A Room: Volume 1"),
				new TidalAlbum("Chvrches","Every Open Eye"),
				new TidalAlbum("Chvrches","The Bones Of What You Believe"),
				new TidalAlbum("Divine Fits","A Thing Called Divine Fits"),
				new TidalAlbum("Electric Light Orchestra","Time"),
				new TidalAlbum("Eminem","Kamikaze"),
				new TidalAlbum("Eurythmics","Ultimate Collection"),
				new TidalAlbum("Ferdinand the Bull","Painting Over Pictures"),
				new TidalAlbum("Fitz And The Tantrums","More Than Just A Dream"),
				new TidalAlbum("Gotye","Making Mirrors"),
				new TidalAlbum("Green Day","Uno... Dos... Tré!"),
				new TidalAlbum("Imagine Dragons","Night Visions"),
				new TidalAlbum("Jonsi","Go"),
				new TidalAlbum("Journey","Departure"),
				new TidalAlbum("K.Flay","Every Where Is Some Where"),
				new TidalAlbum("Kansas","Point Of Know Return"),
				new TidalAlbum("Kasabian","West Ryder Pauper Lunatic Asylum"),
				new TidalAlbum("Lorde","Pure Heroine"),
				new TidalAlbum("Lupe Fiasco","Lupe Fiasco's The Cool"),
				new TidalAlbum("Metric","Fantasies"),
				new TidalAlbum("Metric","Synthetica"),
				new TidalAlbum("Mister Wives","Connect The Dots"),
				new TidalAlbum("Muse","The Resistance"),
				new TidalAlbum("Nirvana","Nirvana"),
				new TidalAlbum("Nothing More","The Stories We Tell Ourselves"),
				new TidalAlbum("OneRepublic","Waking Up"),
				new TidalAlbum("Pet Shop Boys","Please"),
				new TidalAlbum("Portishead","Dummy"),
				new TidalAlbum("Prophets of Rage","Prophets or Rage"),
				new TidalAlbum("Shiny Toy Guns","Season Of Poison"),
				new TidalAlbum("Silversun Pickups","Carnavasas"),
				new TidalAlbum("Silversun Pickups","Swoon"),
				new TidalAlbum("Spoon","Ga Ga Ga Ga Ga"),
				new TidalAlbum("Tears For Fears","Sowing The Seeds Of Love"),
				new TidalAlbum("The 1975","The 1975"),
				new TidalAlbum("The Civil Wars","Barton Hollow"),
				new TidalAlbum("The Cure","Kiss Me Kiss Me Kiss Me"),
				new TidalAlbum("The Decemberists","I'll Be Your Girl"),
				new TidalAlbum("The Gaslight Anthem","The '59 Sound"),
				new TidalAlbum("The Shins","Port Of Morrow"),
				new TidalAlbum("Toto","IV"),
				new TidalAlbum("Vic Mensa","The Autobiography"),
				new TidalAlbum("Wisin","Victory"),
				new TidalAlbum("Yaz","Upstairs At Eric's"),
				new TidalAlbum("Yeasayer","Odd Blood"),
				new TidalAlbum("Young the Giant","Home Of The Strange"),
				new TidalAlbum("Arcade Fire","Neon Bible"),
				new TidalAlbum("Arcade Fire","The Suburbs"),
				new TidalAlbum("Band Of Skulls","Love Is All You Love"),
				new TidalAlbum("Bebe","Y."),
				new TidalAlbum("Beck","Odelay"),
				new TidalAlbum("Belly","Immigrant"),
				new TidalAlbum("Blitzen Trapper","Furr"),
				new TidalAlbum("Bruce Springsteen","Wrecking Ball"),
				new TidalAlbum("Dropkick Murpheys","SIGNED And SEALED In BLOOD"),
				new TidalAlbum("Evanescence","Evanescence"),
				new TidalAlbum("Everclear","Invisible Stars"),
				new TidalAlbum("Foals","Everything Not Saved Will Be Lost Part 1"),
				new TidalAlbum("fun.","Some Nights"),
				new TidalAlbum("G. Love And Special Sauce","G. Love And Special Sauce"),
				new TidalAlbum("G. Love And Special Sauce","Yeah, It's That Easy"),
				new TidalAlbum("Gorillaz","Demon Days"),
				new TidalAlbum("Imagine Dragons","Smoke + Mirrors"),
				new TidalAlbum("Jet","Get Born"),
				new TidalAlbum("Julian Casablancas","Phrazes For The Young"),
				new TidalAlbum("LCD Soundsystem","Sound Of Silver"),
				new TidalAlbum("LCD Soundsystem","This Is Happening"),
				new TidalAlbum("Led Zeppelin","III"),
				new TidalAlbum("Lifehouse","Almeria"),
				new TidalAlbum("Linkin Park","Meteora"),
				new TidalAlbum("Logic","Confessions Of A Dangerous Mind"),
				new TidalAlbum("London Grammar","If You Wait"),
				new TidalAlbum("Lupe Fiasco","Lasers"),
				new TidalAlbum("Maroon 5","Hands All Over"),
				new TidalAlbum("Massive Attack","Blue Lines"),
				new TidalAlbum("Metric","Art Of Doubt"),
				new TidalAlbum("Michael Franti","The Sound Of Sunshine"),
				new TidalAlbum("Mumford & Sons","Sigh No More"),
				new TidalAlbum("Murs","A Strange Journey Into The Unimaginable"),
				new TidalAlbum("Neon Trees","Picture Show"),
				new TidalAlbum("Nirvana","Nevermind"),
				new TidalAlbum("Nothing But Thieves","Nothing But Thieves"),
				new TidalAlbum("OneRepublic","Native"),
				new TidalAlbum("Orishas","Gourmet"),
				new TidalAlbum("Plan B","Heaven Before All Hell Breaks Loose"),
				new TidalAlbum("Ryan Bingham","Junky Star"),
				new TidalAlbum("Shaggy","Wah Gwaan?!"),
				new TidalAlbum("Sixpence None The Richer","Lost In Translation"),
				new TidalAlbum("Smashing Pumpkins","Oceania"),
				new TidalAlbum("Snow Patrol","Eyes Open"),
				new TidalAlbum("Spoon","Hot Thoughts"),
				new TidalAlbum("Spoon","Tranference"),
				new TidalAlbum("Sting","Nothing Like The Sun"),
				new TidalAlbum("Supertramp","Crime Of The Century"),
				new TidalAlbum("Switchfoot","Fading West"),
				new TidalAlbum("The Cranberries","In The End"),
				new TidalAlbum("The Doors","L.A. Woman"),
				new TidalAlbum("The Fray","How To Save A Life"),
				new TidalAlbum("The Gaslight Anthem","Handwritten"),
				new TidalAlbum("The Lone Bellow","Walking Into A Storm"),
				new TidalAlbum("The Sheepdogs","Changing Colours"),
				new TidalAlbum("The Shins","Heartworms"),
				new TidalAlbum("The Shins","Wincing The Night Away"),
				new TidalAlbum("The Wallflowers","Glad All Over"),
				new TidalAlbum("The Who","Who's Next"),
				new TidalAlbum("USS (Ubiquitous Synergy Seeker)","Questamation"),
				new TidalAlbum("Violent Femmes","Violent Femmes"),
				new TidalAlbum("Weezer","Teal Album"),
				new TidalAlbum("Weezer","Weezer (Blue Album)"),
				new TidalAlbum("Welshly Arms","No Place Is Home"),
				new TidalAlbum("Young The Giant","Mind Over Matter"),
				new TidalAlbum("Augustana","Life Imitating Life"),
				new TidalAlbum("Blitzen Trapper","Wild And Reckless"),
				new TidalAlbum("Blues Traveller","Hurry Up and Hang Around"),
				new TidalAlbum("Breton","War Room Stories"),
				new TidalAlbum("I Fight Dragons","Kaboom!"),
				new TidalAlbum("Ingird Michaelson","Lights Out"),
				new TidalAlbum("Lifehouse","Who We Are"),
				new TidalAlbum("Michael Jackson","Off The Wall"),
				new TidalAlbum("Neon Trees","Pop Psychology"),
				new TidalAlbum("Snow Patrol","Wildness"),
				new TidalAlbum("St. Vincent","St. Vincent"),
				new TidalAlbum("The Pains Of Being Pure At Heart","Days Of Abandon"),
				new TidalAlbum("Walk Off The Earth","Sing It All Away"),
				new TidalAlbum("Weezer","Black Album"),
				new TidalAlbum("Weezer","Pacific Daydream"),
				new TidalAlbum("Berlin","Love Life"),
				new TidalAlbum("Blondie","Eat To The Beat"),
				new TidalAlbum("Of Monsters And Men","FEVER DREAM")};

            var masterList = new TidalAlbumList();
            masterList.AddAlbums(sourceList);

            var count = masterList.Count;

            var playList = masterList.RandomSublist(16);
			masterList.RemoveAlbums(playList);
        }
    }
}
