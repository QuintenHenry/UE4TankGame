using UnrealBuildTool;

public class DonutsGameTarget : TargetRules
{
	public DonutsGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DonutsGame");
	}
}
