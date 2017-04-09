using System.Collections.Generic;

namespace BussinesLogic.Interfaces
{
    public interface IBuilderPasswordGeneratorTransformSigns
    {
        IEnumerable<int> GetIndexes();
        IEnumerable<char> GetSigns();
        ICollection<char> GetSignsByIndexes(IEnumerable<int> indexes);
        int GetLastIndex();
        int GetIndexBySign(char sign);
        char GetSignByIndex(int index);
    }
}