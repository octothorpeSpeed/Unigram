// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLNotifyChats : TLNotifyPeerBase 
	{
		public TLNotifyChats() { }
		public TLNotifyChats(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.NotifyChats; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xC007CEC3);
			if (cache) WriteToCache(to);
		}
	}
}