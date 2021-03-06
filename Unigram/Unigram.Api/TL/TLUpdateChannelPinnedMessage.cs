// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChannelPinnedMessage : TLUpdateBase 
	{
		public TLUpdateChannelPinnedMessage() { }
		public TLUpdateChannelPinnedMessage(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateChannelPinnedMessage; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			ChannelId = from.ReadInt32();
			Id = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x98592475);
			to.Write(ChannelId);
			to.Write(Id);
			if (cache) WriteToCache(to);
		}
	}
}