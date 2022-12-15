using MonoMod.Core.Platforms;
using System;
using System.Reflection;

namespace HarmonyLib
{
	public static class MethodExtensions
	{
		public static IntPtr GetNativeStart<T>(this T method) where T : MethodBase
		{
			return PlatformTriple.Current.Runtime.GetMethodEntryPoint(method);
		}

		public static T Pin<T>(this T method) where T : MethodBase
		{
			PlatformTriple.Current.Runtime.PinMethodIfNeeded(method);
			return method;
		}
	}
}

