using System.Collections.Generic;

namespace BussinesLogic.Interfaces
{
    public interface IBuilderPasswordGeneratorTransformSigns
    {
        IEnumerable<int> GetIndexes();
        IEnumerable<char> GetSigns();
        int GetIndexBySign(char sign);
        char GetSignByIndex(int index);
    }
}