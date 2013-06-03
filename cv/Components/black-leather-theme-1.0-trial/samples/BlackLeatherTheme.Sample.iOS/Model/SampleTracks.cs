using System;
using System.Collections.Generic;
using MonoTouch.UIKit;

namespace ThemeSample
{
	public static class SampleTracks
	{
		public static IEnumerable<Track> GetTracks()
		{
			yield return new Track
			{
				TrackName = "Love the way you lie",
				ArtistName = "Eminem feat. Rihanna",
				AlbumImage = new UIImage ("album-small.jpg"),
				AlbumImageLarge = new UIImage ("album-large.jpg"),
				Length = "3 mins 46 secs",
				Genre = "Hip Hop"
			};
			
			yield return new Track
			{
				TrackName = "The Fame",
				ArtistName = "Lady Gaga",
				AlbumImage =  new UIImage ("album-small-1.png"),
				AlbumImageLarge = new UIImage ("album-large-1.png"),
				Length = "4 mins 20 secs",
				Genre = "Dance"
			};
			
			yield return new Track
			{
				TrackName = "Speed of Sound",
				ArtistName = "Coldplay",
				AlbumImage = new UIImage ("album-small-2.png"),
				AlbumImageLarge = new UIImage ("album-large-2.png"),
				Length = "4 mins 20 secs",
				Genre = "Dance"
			};
			
			yield return new Track
			{
				TrackName = "I am Sasha - Fierce",
				ArtistName = "Beyonce",
				AlbumImage = new UIImage ("album-small-3.png"),
				AlbumImageLarge = new UIImage ("album-large-3.png"),
				Length = "3 mins 35 secs",
				Genre = "Dance"
			};
		}
	}
}

