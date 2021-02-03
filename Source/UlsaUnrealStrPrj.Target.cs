// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UlsaUnrealStrPrjTarget : TargetRules
{
	public UlsaUnrealStrPrjTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "UlsaUnrealStrPrj" } );
	}
}
