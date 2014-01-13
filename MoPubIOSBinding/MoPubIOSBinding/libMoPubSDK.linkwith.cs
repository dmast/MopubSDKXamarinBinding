using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMoPubSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
