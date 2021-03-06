// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateUserPhoto : TLUpdateBase 
	{
		public TLUserProfilePhotoBase Photo { get; set; }
		public Boolean Previous { get; set; }

		public TLUpdateUserPhoto() { }
		public TLUpdateUserPhoto(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateUserPhoto; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			UserId = from.ReadInt32();
			Date = from.ReadInt32();
			Photo = TLFactory.Read<TLUserProfilePhotoBase>(from, cache);
			Previous = from.ReadBoolean();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x95313B0C);
			to.Write(UserId);
			to.Write(Date);
			to.WriteObject(Photo, cache);
			to.Write(Previous);
			if (cache) WriteToCache(to);
		}
	}
}