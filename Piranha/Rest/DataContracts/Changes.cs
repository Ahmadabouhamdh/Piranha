﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace Piranha.Rest.DataContracts
{
	[DataContract()]
	public class Changes
	{
		[DataMember()]
		public List<Sitemap> Sitemap { get ; set ; }
		[DataMember()]
		public List<Page> Pages { get ; set ; }
		[DataMember()]
		public List<Post> Posts { get ; set ; }
		[DataMember()]
		public List<Category> Categories { get ; set ; }
		[DataMember()]
		public List<Content> Content { get ; set ; }
		[DataMember()]
		public List<PageTemplate> PageTemplates { get ; set ; }
		[DataMember()]
		public List<PostTemplate> PostTemplates { get ; set ; }
		[DataMember()]
		public IList<MediaFolder> MediaFolders { get ; set ; }
		[DataMember()]
		public Deleted Deleted { get ; set ; }
		[DataMember()]
		public string Timestamp { get ; set ; }

		public Changes() {
			Sitemap = new List<Sitemap>() ;
			Pages = new List<Page>() ;
			Posts = new List<Post>() ;
			Categories = new List<Category>() ;
			Content = new List<Content>() ;
			PageTemplates = new List<PageTemplate>() ;
			PostTemplates = new List<PostTemplate>() ;
			MediaFolders = new List<MediaFolder>() ;
			Deleted = new Deleted() ;
		}
	}
}
