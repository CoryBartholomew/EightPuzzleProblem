using System.Collections.Generic;

namespace EightPuzzleGame.SuccessorNodes
{
    public class EightPuzzleSuccessorsForEmptyTileThree : EightPuzzleSuccessorNodesCalculationRuleBase
    {
        public override IEnumerable<INode> GetSuccessors(INode node)
        {
            var result = new List<INode>();

            AddSuccessor((EightPuzzleNode) node, result, 0);
            AddSuccessor((EightPuzzleNode) node, result, 4);
            AddSuccessor((EightPuzzleNode) node, result, 6);

            return result;
        }

        public override bool Match(INode node)
        {
            return ((EightPuzzleNode) node).EmptyTileIndex == 3;
        }
    }
}