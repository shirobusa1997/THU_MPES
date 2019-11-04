// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class THU_MPES_PJ_G4 : ModuleRules
{
	public THU_MPES_PJ_G4(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        // Use Imgui modules provided by plugin.
        PublicDependencyModuleNames.AddRange(new string[] { "ImGui" });

        PrivateDependencyModuleNames.AddRange(new string[] { "ImGui" });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}