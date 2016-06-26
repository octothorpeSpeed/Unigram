// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUserFull : TLObject 
	{
		[Flags]
		public enum Flag : int
		{
			Blocked = (1 << 0),
			About = (1 << 1),
			ProfilePhoto = (1 << 2),
			BotInfo = (1 << 3),
		}

		public bool IsBlocked { get { return Flags.HasFlag(Flag.Blocked); } set { Flags = value ? (Flags | Flag.Blocked) : (Flags & ~Flag.Blocked); } }
		public bool HasAbout { get { return Flags.HasFlag(Flag.About); } set { Flags = value ? (Flags | Flag.About) : (Flags & ~Flag.About); } }
		public bool HasProfilePhoto { get { return Flags.HasFlag(Flag.ProfilePhoto); } set { Flags = value ? (Flags | Flag.ProfilePhoto) : (Flags & ~Flag.ProfilePhoto); } }
		public bool HasBotInfo { get { return Flags.HasFlag(Flag.BotInfo); } set { Flags = value ? (Flags | Flag.BotInfo) : (Flags & ~Flag.BotInfo); } }

		public Flag Flags { get; set; }
		public TLUserBase User { get; set; }
		public String About { get; set; }
		public TLContactsLink Link { get; set; }
		public TLPhotoBase ProfilePhoto { get; set; }
		public TLPeerNotifySettingsBase NotifySettings { get; set; }
		public TLBotInfo BotInfo { get; set; }

		public TLUserFull() { }
		public TLUserFull(TLBinaryReader from, TLType type = TLType.UserFull)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UserFull; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UserFull)
		{
			Flags = (Flag)from.ReadInt32();
			User = TLFactory.Read<TLUserBase>(from);
			if (HasAbout) { About = from.ReadString(); }
			Link = TLFactory.Read<TLContactsLink>(from);
			if (HasProfilePhoto) { ProfilePhoto = TLFactory.Read<TLPhotoBase>(from); }
			NotifySettings = TLFactory.Read<TLPeerNotifySettingsBase>(from);
			if (HasBotInfo) { BotInfo = TLFactory.Read<TLBotInfo>(from); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5932FC03);
			to.Write((Int32)Flags);
			to.WriteObject(User);
			if (HasAbout) to.Write(About);
			to.WriteObject(Link);
			if (HasProfilePhoto) to.WriteObject(ProfilePhoto);
			to.WriteObject(NotifySettings);
			if (HasBotInfo) to.WriteObject(BotInfo);
		}
	}
}