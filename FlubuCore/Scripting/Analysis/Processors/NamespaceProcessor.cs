﻿namespace FlubuCore.Scripting.Analysis.Processors
{
    public class NamespaceProcessor : IScriptProcessor
    {
        public bool Process(ScriptAnalyzerResult analyzerResult, string line, int lineIndex)
        {
            if (line.TrimStart().StartsWith("namespace"))
            {
                analyzerResult.NamespaceIndex = lineIndex;
                return false;
            }

            return false;
        }
    }
}
