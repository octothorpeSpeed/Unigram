// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChannelCreate : TLMessageActionBase 
	{
		public TLMessageActionChannelCreate() { }
		public TLMessageActionChannelCreate(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessageActionChannelCreate; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Title = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x95D2AC92);
			to.Write(Title);
			if (cache) WriteToCache(to);
		}
	}
}