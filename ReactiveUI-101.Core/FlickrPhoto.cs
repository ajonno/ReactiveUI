namespace ReactiveUI_101.Core
{
	// Create a simple model class to store our Flickr results - since we will 
	// never update the properties once we create the object, we don't have to
	// use ReactiveObject, just good-old auto-properties.
	public class FlickrPhoto
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
	}
}