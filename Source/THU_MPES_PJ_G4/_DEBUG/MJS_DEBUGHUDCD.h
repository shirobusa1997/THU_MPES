// Fill out your copyright notice in the Description page of Project Settings.

#pragma once


#include "CoreMinimal.h"
#include "GameFramework/HUD.h"
#include "Kismet/GameplayStatics.h"
// #include "DEBUG_INTERFACE.h"
#include "Components/InputComponent.h"

#ifdef IMGUI_API
#define WITH_IMGUI 1
#else
#define WITH_IMGUI 0
#endif	// IMGUI_API

#define GRAPHCACHESIZE 90

#if WITH_IMGUI
#include <imgui.h>
#include <ImGuiDelegates.h>
#include <ImGuiModule.h>
#endif

#include "MJS_DEBUGHUDCD.generated.h"

/**
 * 
 */
UCLASS(BlueprintType)
class THU_MPES_PJ_G4_API AMJS_DEBUGHUDCD : public AHUD
{
	GENERATED_BODY()
private:
	float currentMoveForwardAxis;
	float currentMoveRightAxis;
	float currentLookUpAxis;
	float currentTurnAxis;

	void InitializeParam();

public:
	AMJS_DEBUGHUDCD();
	~AMJS_DEBUGHUDCD();

	// virtual void BeginPlay() override;
	// virtual void BeginDestroy() override;
	// virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
	// virtual void Tick(float DeltaTime) override;

	// void MoveForward(float AxisValue);
	// void MoveRight(float AxisValue);
	// void PitchCamera(float AxisValue);
	// void YawCamera(float AxisValue);
};
