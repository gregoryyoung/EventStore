﻿// autogenerated
using System.Threading;

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
namespace EventStore.SourceGenerators.Tests.Messaging.ConcreteWithoutGroup
{
	public partial class A
	{
		private static readonly int TypeId = Interlocked.Increment(ref NextMsgId);
		public override int MsgTypeId => TypeId;
	}
}
