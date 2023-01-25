using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
    public abstract class StrategyBase:ExecutableBase
    {
        private ExecutableBase? _linkingTo;
        public void LinkTo(ExecutableBase executable)
        {
            _linkingTo= executable;
        }
        public override MoveInfo Execute(GameModelBase gameModel)
        {
            List<TriggerInfoBase> triggerInfos = new();
            bool isTriggerable = false;
            bool isJudgeable = false;
            bool isExecutable = false;
			List<Tuple<TriggerInfoBase?, JudgeInfoBase?>> triggerJudgeTuples = new();
            MoveInfo? result;
			if (this is ITriggerable)
            {
                isTriggerable= true;
                ITriggerable triggerable= (ITriggerable)this;
                triggerInfos = triggerable.Trigger(gameModel);
            }
            if (this is IJudgeable)
            {
                isJudgeable= true;
                IJudgeable judgeable = (IJudgeable)this;
                if (isTriggerable)
                {
                    foreach(var triggerInfo in triggerInfos)
                    {
                        JudgeInfoBase judgeInfo = judgeable.Judge(gameModel, triggerInfo);
                        if (judgeInfo.Succeeded)
                        {
                            triggerJudgeTuples.Add(new Tuple<TriggerInfoBase?, JudgeInfoBase?>(triggerInfo, judgeInfo));
                        }
					}
                }
                else
                {
                    JudgeInfoBase judgeInfo = judgeable.Judge(gameModel, null);
                    if (judgeInfo.Succeeded)
                    {
                        triggerJudgeTuples.Add(new Tuple<TriggerInfoBase?, JudgeInfoBase?>(null, judgeInfo));
                    }
                }
            }
            else
            {
                foreach(var triggerInfo in triggerInfos)
                {
                    triggerJudgeTuples.Add(new Tuple<TriggerInfoBase?, JudgeInfoBase?>(triggerInfo, null));
                }
            }
            if (this is IExecutable)
            {
                isExecutable= true;
                IExecutable executable = (IExecutable)this;
				List<MoveInfo> results = new();
				foreach (var triggerJudgeTuple in triggerJudgeTuples)
                {
                    MoveInfo moveInfo = executable.Execute(gameModel, triggerJudgeTuple.Item1, triggerJudgeTuple.Item2);
                    if (moveInfo.Succeeded)
                    {
                        results.Add(moveInfo);
                    }
                }
                if (results.Count> 0)
                {
					result = results.MaxBy(moveInfo => moveInfo.Rating);
				}
                else
                {
                    result = MoveInfo.Failed;
                }
            }
            else
            {
                if (_linkingTo ==null)
                {
                    throw new Exception($"Strategy '{this.GetType()}' neither implements IExecutable not links to an executable.");
                }
                result = _linkingTo!.Execute(gameModel);
            }
            return result!;
        }
    }
}
