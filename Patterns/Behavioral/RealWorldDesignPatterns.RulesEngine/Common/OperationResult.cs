using System.Collections.Generic;
using System.Linq;

namespace RealWorldDesignPatterns.RulesEngine.Common
{
    public class OperationResult
    {
        public bool Success { get; private set; }
        public bool Fail => !Success;
        
        public IReadOnlyList<string> Fails => Errors.ToList();
        private List<string> Errors { get; } = new();

        public OperationResult()
        {
            Success = true;
        }

        public void AddError(string error)
        {
            Success = false;
            Errors.Add(error);
        }
    }
}