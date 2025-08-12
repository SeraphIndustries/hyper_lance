// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class hyper_lance : ModuleRules
{
	public hyper_lance(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"hyper_lance",
			"hyper_lance/Variant_Platforming",
			"hyper_lance/Variant_Combat",
			"hyper_lance/Variant_Combat/AI",
			"hyper_lance/Variant_SideScrolling",
			"hyper_lance/Variant_SideScrolling/Gameplay",
			"hyper_lance/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
