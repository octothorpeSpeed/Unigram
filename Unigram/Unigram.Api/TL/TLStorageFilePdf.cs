// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLStorageFilePdf : TLStorageFileTypeBase 
	{
		public TLStorageFilePdf() { }
		public TLStorageFilePdf(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.StorageFilePdf; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xAE1E508D);
			if (cache) WriteToCache(to);
		}
	}
}