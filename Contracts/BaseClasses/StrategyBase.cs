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
        public override MoveInfo ExecuteModule(GameModelBase gameModel, ArgBase? arg)
        {
            List<ArgBase> triggerArgs = new();
            bool isTriggerable = false;
            bool isJudgeable = false;
            bool isExecutable = false;
            List<ArgBase> args = new();
            MoveInfo? result;
			if (this is ITriggerable)
            {
                isTriggerable= true;
                ITriggerable triggerable= (ITriggerable)this;
                triggerable.Trigger(gameModel, arg, out triggerArgs);
            }
            if (this is IJudgeable)
            {
                isJudgeable= true;
                IJudgeable judgeable = (IJudgeable)this;
                if (isTriggerable)
                {
                    foreach(var triggerArg in triggerArgs)
                    {
                        bool succeeded = judgeable.Judge(gameModel, triggerArg, out ArgBase judgeArg);
                        if (succeeded)
                        {
                            args.Add(judgeArg);
                        }
					}
                }
                else
                {
                    bool succeeded = judgeable.Judge(gameModel, null, out ArgBase judgeArg);
                    if (succeeded)
                    {
                        args.Add(judgeArg);
                    }
                }
            }
            else
            {
                foreach(var triggerArg in triggerArgs)
                {
                    args.Add(triggerArg);
                }
            }
            if (this is IExecutable)
            {
                isExecutable= true;
                IExecutable executable = (IExecutable)this;
				List<MoveInfo> results = new();
				foreach (var oneArg in args)
                {
                    MoveInfo moveInfo = executable.Execute(gameModel, oneArg);
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
				List<MoveInfo> results = new();
				foreach (var oneArg in args)
				{
					MoveInfo moveInfo = _linkingTo!.ExecuteModule(gameModel, oneArg);
					if (moveInfo.Succeeded)
					{
						results.Add(moveInfo);
					}
				}
				if (results.Count > 0)
				{
					result = results.MaxBy(moveInfo => moveInfo.Rating);
				}
				else
				{
					result = MoveInfo.Failed;
				}
            }
            return result!;
        }
    }
}
