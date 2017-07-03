using Joing.Core;

namespace Joing.DTO
{
    public class ConditionDto
    {
        public string Name { get; private set; }
        public object Value { get; private set; }
        public ConditionValueEnum ValueType { get; set; }
        public LogicEnum Logic { get; set; }
    }
}