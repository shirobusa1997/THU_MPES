// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class THU_MPES_PJ_G4EditorTarget : TargetRules
{
	public THU_MPES_PJ_G4EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "THU_MPES_PJ_G4" } );
	}
}
