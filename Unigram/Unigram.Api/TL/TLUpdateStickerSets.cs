// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateStickerSets : TLUpdateBase 
	{
		public TLUpdateStickerSets() { }
		public TLUpdateStickerSets(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateStickerSets; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x43AE3DEC);
			if (cache) WriteToCache(to);
		}
	}
}